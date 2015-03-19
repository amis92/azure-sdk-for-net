// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Defines a function that boosts scores of documents with string values
    /// matching a given list of tags.  (see
    /// https://msdn.microsoft.com/library/azure/dn798928.aspx for more
    /// information)
    /// </summary>
    public partial class TagScoringFunction : ScoringFunction
    {
        private TagScoringParameters _parameters;
        
        /// <summary>
        /// Required. Gets parameter values for the tag scoring function.
        /// </summary>
        public TagScoringParameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TagScoringFunction class.
        /// </summary>
        public TagScoringFunction()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the TagScoringFunction class with
        /// required arguments.
        /// </summary>
        public TagScoringFunction(TagScoringParameters parameters, string fieldName, double boost)
            : this()
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (fieldName == null)
            {
                throw new ArgumentNullException("fieldName");
            }
            this.Parameters = parameters;
            this.FieldName = fieldName;
            this.Boost = boost;
        }
    }
}
