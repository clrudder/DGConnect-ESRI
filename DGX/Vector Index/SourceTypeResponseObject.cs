﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SourceTypeResponseObject.cs" company="DigitalGlobe">
//   Copyright 2015 DigitalGlobe
//   
//      Licensed under the Apache License, Version 2.0 (the "License");
//      you may not use this file except in compliance with the License.
//      You may obtain a copy of the License at
//   
//          http://www.apache.org/licenses/LICENSE-2.0
//   
//      Unless required by applicable law or agreed to in writing, software
//      distributed under the License is distributed on an "AS IS" BASIS,
//      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//      See the License for the specific language governing permissions and
//      limitations under the License.
// </copyright>
// <summary>
//   The source type response object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dgx.Vector_Index
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The source type response object.
    /// </summary>
    public class SourceTypeResponseObject
    {
        /// <summary>
        /// Gets or sets the shards.
        /// </summary>
        [JsonProperty(PropertyName = "shards")]
        public int Shards { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public List<SourceType> Data { get; set; }
    }
}