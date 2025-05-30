// <copyright file="OAuthScopeOAuthACGEnum.cs" company="APIMatic">
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
    /// OAuthScopeOAuthACGEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthScopeOAuthACGEnum
    {
        /// <summary>
        /// EnumFileRequestsread.
        /// </summary>
        [EnumMember(Value = "file_requests.read")]
        EnumFileRequestsread,

        /// <summary>
        /// Zahra.
        /// </summary>
        [EnumMember(Value = "zahra")]
        Zahra,

        /// <summary>
        /// Test1.
        /// </summary>
        [EnumMember(Value = "test1")]
        Test1,

        /// <summary>
        /// Selection.
        /// </summary>
        [EnumMember(Value = "selection")]
        Selection
    }
}