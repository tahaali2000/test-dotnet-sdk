// <copyright file="TokensRequest.cs" company="APIMatic">
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
    /// TokensRequest.
    /// </summary>
    public class TokensRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensRequest"/> class.
        /// </summary>
        public TokensRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensRequest"/> class.
        /// </summary>
        /// <param name="scopes">scopes.</param>
        public TokensRequest(
            List<Models.OAuthScopeOAuthACGEnum> scopes)
        {
            this.Scopes = scopes;
        }

        /// <summary>
        /// List of scopes that apply to the OAuth token
        /// </summary>
        [JsonProperty("scopes")]
        public List<Models.OAuthScopeOAuthACGEnum> Scopes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokensRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TokensRequest other &&
                (this.Scopes == null && other.Scopes == null ||
                 this.Scopes?.Equals(other.Scopes) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Scopes = {(this.Scopes == null ? "null" : $"[{string.Join(", ", this.Scopes)} ]")}");
        }
    }
}