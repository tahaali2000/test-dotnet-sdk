// <copyright file="ResponseHttp404.cs" company="APIMatic">
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
    /// ResponseHttp404.
    /// </summary>
    public class ResponseHttp404
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHttp404"/> class.
        /// </summary>
        public ResponseHttp404()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHttp404"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        public ResponseHttp404(
            string id = "")
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseHttp404 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseHttp404 other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
        }
    }
}