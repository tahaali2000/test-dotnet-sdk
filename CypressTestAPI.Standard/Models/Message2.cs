// <copyright file="Message2.cs" company="APIMatic">
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
    /// Message2.
    /// </summary>
    public class Message2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message2"/> class.
        /// </summary>
        public Message2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message2"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="text">text.</param>
        public Message2(
            int? code = null,
            string text = "")
        {
            this.Code = code;
            this.Text = text;
        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Message2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Message2 other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Text == null && other.Text == null ||
                 this.Text?.Equals(other.Text) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {(this.Code == null ? "null" : this.Code.ToString())}");
            toStringOutput.Add($"Text = {this.Text ?? "null"}");
        }
    }
}