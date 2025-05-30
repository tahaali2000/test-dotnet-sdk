// <copyright file="ResponseHttp400.cs" company="APIMatic">
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
    /// ResponseHttp400.
    /// </summary>
    public class ResponseHttp400
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHttp400"/> class.
        /// </summary>
        public ResponseHttp400()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHttp400"/> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        public ResponseHttp400(
            string detail = "")
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseHttp400 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseHttp400 other &&
                (this.Detail == null && other.Detail == null ||
                 this.Detail?.Equals(other.Detail) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Detail = {this.Detail ?? "null"}");
        }
    }
}