﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallingServer
{
    internal class ContentDownloader
    {
        private readonly CallingServerClient _client;

        internal ContentDownloader(CallingServerClient client)
        {
            _client = client;
        }

        internal async Task<Response<Stream>> DownloadStreamingInternal(Uri sourceEndpoint, HttpRange range, bool async, CancellationToken cancellationToken)
        {
            Response<Stream> response;
            if (async)
            {
                response = await StartDownloadAsync(sourceEndpoint, range, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                response = StartDownload(sourceEndpoint, range, cancellationToken: cancellationToken);
            }

            Stream stream = RetriableStream.Create(
                response.Value,
                startOffset => StartDownload(sourceEndpoint, range, startOffset, cancellationToken).Value,
                async startOffset => (await StartDownloadAsync(sourceEndpoint, range, startOffset, cancellationToken).ConfigureAwait(false)).Value,
                _client._pipeline.ResponseClassifier,
                Constants.ContentDownloader.RetriableStreamRetries
            );

            return Response.FromValue(stream, response.GetRawResponse());
        }

        internal async Task<Response> StagedDownloadAsync(Uri sourceEndpoint, Stream destinationStream,
            ContentTransferOptions transferOptions = default, bool async = true, CancellationToken cancellationToken = default)
        {
            PartitionedDownloader downloader = new(_client, transferOptions);
            if (async)
            {
                return await downloader.DownloadToAsync(destinationStream, sourceEndpoint, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return downloader.DownloadTo(destinationStream, sourceEndpoint, cancellationToken);
            }
        }

        private async Task<Response<Stream>> StartDownloadAsync(Uri sourceEndpoint, HttpRange range = default, long startOffset = 0,
            CancellationToken cancellationToken = default)
        {
            HttpRange? pageRange = null;

            if (range != default || startOffset != 0)
            {
                pageRange = new HttpRange(
                    range.Offset + startOffset,
                    range.Length.HasValue ?
                        range.Length.Value - startOffset :
                        null);
            }

            HttpMessage message = AmsDirectRequestHelpers.GetHttpMessage(_client, sourceEndpoint, RequestMethod.Get, pageRange);

            await _client._pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 206:
                    {
                        Stream value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _client._clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        private Response<Stream> StartDownload(Uri sourceEndpoint, HttpRange range = default, long startOffset = 0, CancellationToken cancellationToken = default)
        {
            HttpRange? pageRange = null;

            if (range != default || startOffset != 0)
            {
                pageRange = new HttpRange(
                    range.Offset + startOffset,
                    range.Length.HasValue ?
                        range.Length.Value - startOffset :
                        null);
            }

            HttpMessage message = AmsDirectRequestHelpers.GetHttpMessage(_client, sourceEndpoint, RequestMethod.Get, pageRange);
            _client._pipeline.Send(message, cancellationToken);

            switch (message.Response.Status)
            {
                case 200:
                case 206:
                    {
                        Stream value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _client._clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
