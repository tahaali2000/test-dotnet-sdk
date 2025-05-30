// <copyright file="Status1Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using CypressTestAPI.Standard;
using CypressTestAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace CypressTestAPI.Standard.Models
{
    /// <summary>
    /// Status1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status1Enum
    {
        /// <summary>
        /// Enumvalue1.
        /// </summary>
        [EnumMember(Value = "enumvalue1")]
        Enumvalue1,

        /// <summary>
        /// Enumvalue2.
        /// </summary>
        [EnumMember(Value = "enumvalue2")]
        Enumvalue2,

        /// <summary>
        /// Enumvalue3.
        /// </summary>
        [EnumMember(Value = "enumvalue3")]
        Enumvalue3
    }
}