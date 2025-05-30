// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using CypressTestAPI.Standard;
using CypressTestAPI.Standard.Exceptions;
using CypressTestAPI.Standard.Http.Client;
using CypressTestAPI.Standard.Http.Response;
using CypressTestAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace CypressTestAPI.Standard.Controllers
{
    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        internal APIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Generates a new OAuth token with the specified scopes.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        public void CreateOAuthToken(
                Models.TokensRequest body = null)
            => CoreHelper.RunVoidTask(CreateOAuthTokenAsync(body));

        /// <summary>
        /// Generates a new OAuth token with the specified scopes.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CreateOAuthTokenAsync(
                Models.TokensRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/tokens")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new resource in the system.
        /// </summary>
        /// <param name="status">Required parameter: The status of the items to filter by..</param>
        /// <param name="body">Optional parameter: Custom model with additional properties.</param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public ApiResponse<object> Createanitem(
                Models.Status3Enum status,
                Models.Item body = null)
            => CoreHelper.RunTask(CreateanitemAsync(status, body));

        /// <summary>
        /// Creates a new resource in the system.
        /// </summary>
        /// <param name="status">Required parameter: The status of the items to filter by..</param>
        /// <param name="body">Optional parameter: Custom model with additional properties.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public async Task<ApiResponse<object>> CreateanitemAsync(
                Models.Status3Enum status,
                Models.Item body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/items/{status}")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("status", ApiHelper.JsonSerialize(status).Trim('\"')))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiException(_reason, _context)))
                  .Deserializer(_response => _response))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetanitembyID EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: The ID of the item to retrieve.</param>
        /// <param name="mValue">Required parameter: The value of the item to retrieve.</param>
        /// <returns>Returns the ApiResponse of Models.Item response from the API call.</returns>
        public ApiResponse<Models.Item> GetanitembyID(
                string id,
                string mValue)
            => CoreHelper.RunTask(GetanitembyIDAsync(id, mValue));

        /// <summary>
        /// GetanitembyID EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: The ID of the item to retrieve.</param>
        /// <param name="mValue">Required parameter: The value of the item to retrieve.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Item response from the API call.</returns>
        public async Task<ApiResponse<Models.Item>> GetanitembyIDAsync(
                string id,
                string mValue,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Item>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/items/{id}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id).Required())
                      .Query(_query => _query.Setup("value", mValue).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint accepts a complex structure with multiple arrays.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        public void TestEndpointwithArrays(
                Models.MultipleArraysRequest body = null)
            => CoreHelper.RunVoidTask(TestEndpointwithArraysAsync(body));

        /// <summary>
        /// This endpoint accepts a complex structure with multiple arrays.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task TestEndpointwithArraysAsync(
                Models.MultipleArraysRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/multiple-arrays")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}