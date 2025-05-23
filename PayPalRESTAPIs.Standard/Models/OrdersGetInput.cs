// <copyright file="OrdersGetInput.cs" company="APIMatic">
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
    /// OrdersGetInput.
    /// </summary>
    public class OrdersGetInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersGetInput"/> class.
        /// </summary>
        public OrdersGetInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersGetInput"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fields">fields.</param>
        public OrdersGetInput(
            string id,
            string fields = null)
        {
            this.Id = id;
            this.Fields = fields;
        }

        /// <summary>
        /// The ID of the order for which to show details.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A comma-separated list of fields that should be returned for the order. Valid filter field is `payment_source`.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string Fields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrdersGetInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrdersGetInput other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Fields = {this.Fields ?? "null"}");
        }
    }
}