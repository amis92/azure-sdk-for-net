// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Device importance, determines if the device classified as &apos;crown jewel&apos;. </summary>
    public readonly partial struct DeviceImportance : IEquatable<DeviceImportance>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceImportance"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceImportance(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string LowValue = "Low";
        private const string NormalValue = "Normal";
        private const string HighValue = "High";

        /// <summary> Unknown - Default value. </summary>
        public static DeviceImportance Unknown { get; } = new DeviceImportance(UnknownValue);
        /// <summary> Low. </summary>
        public static DeviceImportance Low { get; } = new DeviceImportance(LowValue);
        /// <summary> Normal. </summary>
        public static DeviceImportance Normal { get; } = new DeviceImportance(NormalValue);
        /// <summary> High. </summary>
        public static DeviceImportance High { get; } = new DeviceImportance(HighValue);
        /// <summary> Determines if two <see cref="DeviceImportance"/> values are the same. </summary>
        public static bool operator ==(DeviceImportance left, DeviceImportance right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceImportance"/> values are not the same. </summary>
        public static bool operator !=(DeviceImportance left, DeviceImportance right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeviceImportance"/>. </summary>
        public static implicit operator DeviceImportance(string value) => new DeviceImportance(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceImportance other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceImportance other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
