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
    ///  Class for testing NamedSpacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NamedSpacesApiTests
    {
        private NamedSpacesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NamedSpacesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NamedSpacesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NamedSpacesApi
            //Assert.IsInstanceOfType(typeof(NamedSpacesApi), instance, "instance is a NamedSpacesApi");
        }

        
        /// <summary>
        /// Test GetUserSpaces
        /// </summary>
        [Test]
        public void GetUserSpacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string role = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetUserSpaces(userId, role, offset, limit);
            //Assert.IsInstanceOf<GenericDataRepresentationListSpaceData> (response, "response is GenericDataRepresentationListSpaceData");
        }
        
    }

}
