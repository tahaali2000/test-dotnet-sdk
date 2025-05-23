// <copyright file="AuthorizationsReauthorizeInput.cs" company="APIMatic">
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
    /// AuthorizationsReauthorizeInput.
    /// </summary>
    public class AuthorizationsReauthorizeInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationsReauthorizeInput"/> class.
        /// </summary>
        public AuthorizationsReauthorizeInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationsReauthorizeInput"/> class.
        /// </summary>
        /// <param name="authorizationId">authorization_id.</param>
        /// <param name="contentType">Content-Type.</param>
        /// <param name="payPalRequestId">PayPal-Request-Id.</param>
        /// <param name="prefer">Prefer.</param>
        /// <param name="body">body.</param>
        public AuthorizationsReauthorizeInput(
            string authorizationId,
            string contentType,
            string payPalRequestId = null,
            string prefer = "return=minimal",
            Models.ReauthorizeRequest body = null)
        {
            this.AuthorizationId = authorizationId;
            this.ContentType = contentType;
            this.PayPalRequestId = payPalRequestId;
            this.Prefer = prefer;
            this.Body = body;
        }

        /// <summary>
        /// The PayPal-generated ID for the authorized payment to reauthorize.
        /// </summary>
        [JsonProperty("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The server stores keys for 45 days.
        /// </summary>
        [JsonProperty("PayPal-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalRequestId { get; set; }

        /// <summary>
        /// The preferred server response upon successful completion of the request. Value is:<ul><li><code>return=minimal</code>. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the <code>id</code>, <code>status</code> and HATEOAS links.</li><li><code>return=representation</code>. The server returns a complete resource representation, including the current state of the resource.</li></ul>
        /// </summary>
        [JsonProperty("Prefer", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefer { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReauthorizeRequest Body { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AuthorizationsReauthorizeInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AuthorizationsReauthorizeInput other &&
                (this.AuthorizationId == null && other.AuthorizationId == null ||
                 this.AuthorizationId?.Equals(other.AuthorizationId) == true) &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true) &&
                (this.PayPalRequestId == null && other.PayPalRequestId == null ||
                 this.PayPalRequestId?.Equals(other.PayPalRequestId) == true) &&
                (this.Prefer == null && other.Prefer == null ||
                 this.Prefer?.Equals(other.Prefer) == true) &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AuthorizationId = {this.AuthorizationId ?? "null"}");
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
            toStringOutput.Add($"PayPalRequestId = {this.PayPalRequestId ?? "null"}");
            toStringOutput.Add($"Prefer = {this.Prefer ?? "null"}");
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : this.Body.ToString())}");
        }
    }
}