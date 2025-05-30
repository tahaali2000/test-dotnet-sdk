// <copyright file="APIControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using CypressTestAPI.Standard;
using CypressTestAPI.Standard.Controllers;
using CypressTestAPI.Standard.Exceptions;
using CypressTestAPI.Standard.Http.Client;
using CypressTestAPI.Standard.Http.Response;
using CypressTestAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace CypressTestAPI.Tests
{
    /// <summary>
    /// APIControllerTest.
    /// </summary>
    [TestFixture]
    public class APIControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private APIController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.APIController;
        }

        /// <summary>
        /// Generates a new OAuth token with the specified scopes..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateOAuthToken()
        {
            // Parameters for the API call
            Standard.Models.TokensRequest body = null;

            // Perform API call
            try
            {
                await this.controller.CreateOAuthTokenAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");
        }

        /// <summary>
        /// This endpoint accepts a complex structure with multiple arrays..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestTestEndpointwithArrays()
        {
            // Parameters for the API call
            Standard.Models.MultipleArraysRequest body = null;

            // Perform API call
            try
            {
                await this.controller.TestEndpointwithArraysAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}