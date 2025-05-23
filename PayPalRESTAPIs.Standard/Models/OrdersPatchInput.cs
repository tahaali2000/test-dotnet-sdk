// <copyright file="OrdersPatchInput.cs" company="APIMatic">
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// OrdersPatchInput.
    /// </summary>
    public class OrdersPatchInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersPatchInput"/> class.
        /// </summary>
        public OrdersPatchInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersPatchInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="body">body.</param>
        public OrdersPatchInput(
            string id,
            string contentType,
            List<Models.Patch> body = null)
        {
            this.Id = id;
            this.ContentType = contentType;
            this.Body = body;
        }

        /// <summary>
        /// The ID of the order to update.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Patch> Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrdersPatchInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrdersPatchInput other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : $"[{string.Join(", ", this.Body)} ]")}");
        }
    }
}