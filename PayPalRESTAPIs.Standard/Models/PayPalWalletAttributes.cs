// <copyright file="PayPalWalletAttributes.cs" company="APIMatic">
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
    /// PayPalWalletAttributes.
    /// </summary>
    public class PayPalWalletAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletAttributes"/> class.
        /// </summary>
        public PayPalWalletAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletAttributes"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="vault">vault.</param>
        public PayPalWalletAttributes(
            Models.PayPalWalletCustomerRequest customer = null,
            Models.PayPalWalletVaultInstruction vault = null)
        {
            this.Customer = customer;
            this.Vault = vault;
        }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletCustomerRequest Customer { get; set; }

        /// <summary>
        /// Gets or sets Vault.
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayPalWalletVaultInstruction Vault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayPalWalletAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayPalWalletAttributes other &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Vault == null && other.Vault == null ||
                 this.Vault?.Equals(other.Vault) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Vault = {(this.Vault == null ? "null" : this.Vault.ToString())}");
        }
    }
}