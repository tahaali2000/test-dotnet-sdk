// <copyright file="CustomEnum.cs" company="APIMatic">
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
    /// CustomEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomEnum
    {
        /// <summary>
        /// VALUE1.
        /// </summary>
        [EnumMember(Value = "VALUE1")]
        VALUE1,

        /// <summary>
        /// VALUE2.
        /// </summary>
        [EnumMember(Value = "VALUE2")]
        VALUE2,

        /// <summary>
        /// VALUE3.
        /// </summary>
        [EnumMember(Value = "VALUE3")]
        VALUE3
    }
}