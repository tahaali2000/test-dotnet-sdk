// <copyright file="BLIKOneClickPaymentObject.cs" company="APIMatic">
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
    /// BLIKOneClickPaymentObject.
    /// </summary>
    public class BLIKOneClickPaymentObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BLIKOneClickPaymentObject"/> class.
        /// </summary>
        public BLIKOneClickPaymentObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BLIKOneClickPaymentObject"/> class.
        /// </summary>
        /// <param name="consumerReference">consumer_reference.</param>
        public BLIKOneClickPaymentObject(
            string consumerReference = null)
        {
            this.ConsumerReference = consumerReference;
        }

        /// <summary>
        /// The merchant generated, unique reference serving as a primary identifier for accounts connected between Blik and a merchant.
        /// </summary>
        [JsonProperty("consumer_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BLIKOneClickPaymentObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BLIKOneClickPaymentObject other &&
                (this.ConsumerReference == null && other.ConsumerReference == null ||
                 this.ConsumerReference?.Equals(other.ConsumerReference) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ConsumerReference = {this.ConsumerReference ?? "null"}");
        }
    }
}