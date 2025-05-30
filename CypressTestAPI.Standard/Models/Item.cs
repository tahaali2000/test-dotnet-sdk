// <copyright file="Item.cs" company="APIMatic">
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
    /// Item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="date">date.</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="mDecimal">decimal.</param>
        /// <param name="mLong">long.</param>
        /// <param name="mBool">bool.</param>
        /// <param name="customEnum">CustomEnum.</param>
        /// <param name="jsonObject">jsonObject.</param>
        /// <param name="animal">Animal.</param>
        /// <param name="map">Map.</param>
        /// <param name="status">status.</param>
        public Item(
            Guid id,
            string name,
            DateTime date,
            DateTime dateTime,
            double mDecimal,
            long mLong,
            bool mBool,
            Models.CustomEnum customEnum,
            object jsonObject,
            object animal,
            Dictionary<string, Models.Message> map,
            Models.StatusEnum? status = null)
        {
            this.Id = id;
            this.Name = name;
            this.Date = date;
            this.DateTime = dateTime;
            this.MDecimal = mDecimal;
            this.MLong = mLong;
            this.MBool = mBool;
            this.CustomEnum = customEnum;
            this.Status = status;
            this.JsonObject = jsonObject;
            this.Animal = animal;
            this.Map = map;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets MDecimal.
        /// </summary>
        [JsonProperty("decimal")]
        public double MDecimal { get; set; }

        /// <summary>
        /// Gets or sets MLong.
        /// </summary>
        [JsonProperty("long")]
        public long MLong { get; set; }

        /// <summary>
        /// Gets or sets MBool.
        /// </summary>
        [JsonProperty("bool")]
        public bool MBool { get; set; }

        /// <summary>
        /// Gets or sets CustomEnum.
        /// </summary>
        [JsonProperty("CustomEnum")]
        public Models.CustomEnum CustomEnum { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StatusEnum? Status { get; set; }

        /// <summary>
        /// A generic JSON object
        /// </summary>
        [JsonProperty("jsonObject")]
        public object JsonObject { get; set; }

        /// <summary>
        /// Gets or sets Animal.
        /// </summary>
        [JsonProperty("Animal")]
        public object Animal { get; set; }

        /// <summary>
        /// Gets or sets Map.
        /// </summary>
        [JsonProperty("Map")]
        public Dictionary<string, Models.Message> Map { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Item : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Item other &&
                (this.Id.Equals(other.Id)) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Date.Equals(other.Date)) &&
                (this.DateTime.Equals(other.DateTime)) &&
                (this.MDecimal.Equals(other.MDecimal)) &&
                (this.MLong.Equals(other.MLong)) &&
                (this.MBool.Equals(other.MBool)) &&
                (this.CustomEnum.Equals(other.CustomEnum)) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.JsonObject == null && other.JsonObject == null ||
                 this.JsonObject?.Equals(other.JsonObject) == true) &&
                (this.Animal == null && other.Animal == null ||
                 this.Animal?.Equals(other.Animal) == true) &&
                (this.Map == null && other.Map == null ||
                 this.Map?.Equals(other.Map) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Date = {this.Date}");
            toStringOutput.Add($"DateTime = {this.DateTime}");
            toStringOutput.Add($"MDecimal = {this.MDecimal}");
            toStringOutput.Add($"MLong = {this.MLong}");
            toStringOutput.Add($"MBool = {this.MBool}");
            toStringOutput.Add($"CustomEnum = {this.CustomEnum}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"JsonObject = {(this.JsonObject == null ? "null" : this.JsonObject.ToString())}");
            toStringOutput.Add($"Animal = {(this.Animal == null ? "null" : this.Animal.ToString())}");
            toStringOutput.Add($"Map = {(this.Map == null ? "null" : this.Map.ToString())}");
        }
    }
}