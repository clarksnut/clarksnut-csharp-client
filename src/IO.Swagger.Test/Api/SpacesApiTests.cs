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
    ///  Class for testing SpacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SpacesApiTests
    {
        private SpacesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SpacesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SpacesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SpacesApi
            //Assert.IsInstanceOfType(typeof(SpacesApi), instance, "instance is a SpacesApi");
        }

        
        /// <summary>
        /// Test CreateSpace
        /// </summary>
        [Test]
        public void CreateSpaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SpaceRepresentation body = null;
            //instance.CreateSpace(body);
            
        }
        
        /// <summary>
        /// Test GetSpace
        /// </summary>
        [Test]
        public void GetSpaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string spaceId = null;
            //var response = instance.GetSpace(spaceId);
            //Assert.IsInstanceOf<SpaceRepresentation> (response, "response is SpaceRepresentation");
        }
        
        /// <summary>
        /// Test GetSpaces
        /// </summary>
        [Test]
        public void GetSpacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string assignedId = null;
            //string filterText = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetSpaces(assignedId, filterText, offset, limit);
            //Assert.IsInstanceOf<GenericDataRepresentationListSpaceData> (response, "response is GenericDataRepresentationListSpaceData");
        }
        
    }

}
