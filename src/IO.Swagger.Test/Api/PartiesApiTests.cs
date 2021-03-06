/* 
 * Clarksnut
 *
 * Clarksnut UBL collector
 *
 * OpenAPI spec version: 1.2.0-SNAPSHOT
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PartiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PartiesApiTests
    {
        private PartiesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PartiesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PartiesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PartiesApi
            //Assert.IsInstanceOfType(typeof(PartiesApi), instance, "instance is a PartiesApi");
        }

        
        /// <summary>
        /// Test GetParties
        /// </summary>
        [Test]
        public void GetPartiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? offset = null;
            //int? limit = null;
            //List<string> space = null;
            //var response = instance.GetParties(q, offset, limit, space);
            //Assert.IsInstanceOf<GenericDataRepresentationListPartyData> (response, "response is GenericDataRepresentationListPartyData");
        }
        
    }

}
