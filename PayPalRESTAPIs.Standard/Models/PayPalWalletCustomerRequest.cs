// <copyright file="PayPalWalletCustomerRequest.cs" company="APIMatic">
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
    /// PayPalWalletCustomerRequest.
    /// </summary>
    public class PayPalWalletCustomerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletCustomerRequest"/> class.
        /// </summary>
        public PayPalWalletCustomerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalWalletCustomerRequest"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="emailAddress">email_address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="merchantCustomerId">merchant_customer_id.</param>
        public PayPalWalletCustomerRequest(
            string id = null,
            string emailAddress = null,
            Models.PhoneWithType phone = null,
            string merchantCustomerId = null)
        {
            this.Id = id;
            this.EmailAddress = emailAddress;
            this.Phone = phone;
            this.MerchantCustomerId = merchantCustomerId;
        }

        /// <summary>
        /// The unique ID for a customer generated by PayPal.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone information.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneWithType Phone { get; set; }

        /// <summary>
        /// Merchants and partners may already have a data-store where their customer information is persisted. Use merchant_customer_id to associate the PayPal-generated customer.id to your representation of a customer.
        /// </summary>
        [JsonProperty("merchant_customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantCustomerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayPalWalletCustomerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayPalWalletCustomerRequest other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.Phone == null && other.Phone == null ||
                 this.Phone?.Equals(other.Phone) == true) &&
                (this.MerchantCustomerId == null && other.MerchantCustomerId == null ||
                 this.MerchantCustomerId?.Equals(other.MerchantCustomerId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"MerchantCustomerId = {this.MerchantCustomerId ?? "null"}");
        }
    }
}