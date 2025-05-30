// <copyright file="MultipleArraysRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CypressTestAPI.Standard;
using CypressTestAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CypressTestAPI.Standard.Models
{
    /// <summary>
    /// MultipleArraysRequest.
    /// </summary>
    public class MultipleArraysRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleArraysRequest"/> class.
        /// </summary>
        public MultipleArraysRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleArraysRequest"/> class.
        /// </summary>
        /// <param name="array1">Array1.</param>
        /// <param name="array2">Array2.</param>
        public MultipleArraysRequest(
            List<string> array1,
            List<int> array2 = null)
        {
            this.Array1 = array1;
            this.Array2 = array2;
        }

        /// <summary>
        /// An array containing items of type string
        /// </summary>
        [JsonProperty("Array1")]
        public List<string> Array1 { get; set; }

        /// <summary>
        /// An array containing items of type integer
        /// </summary>
        [JsonProperty("Array2", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Array2 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MultipleArraysRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MultipleArraysRequest other &&
                (this.Array1 == null && other.Array1 == null ||
                 this.Array1?.Equals(other.Array1) == true) &&
                (this.Array2 == null && other.Array2 == null ||
                 this.Array2?.Equals(other.Array2) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Array1 = {(this.Array1 == null ? "null" : $"[{string.Join(", ", this.Array1)} ]")}");
            toStringOutput.Add($"Array2 = {(this.Array2 == null ? "null" : $"[{string.Join(", ", this.Array2)} ]")}");
        }
    }
}