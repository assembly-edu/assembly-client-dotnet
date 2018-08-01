/* 
 * Assembly Developer API
 *
 * The Assembly API is built around the REST and a collection of open standards/protocols in order to comply with as many consumers as possible.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using AssemblyClient.Client;
using AssemblyClient.Api;
using AssemblyClient.Model;

namespace AssemblyClient.Test
{
    /// <summary>
    ///  Class for testing AssessmentPointsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AssessmentPointsApiTests
    {
        private AssessmentPointsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AssessmentPointsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AssessmentPointsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AssessmentPointsApi
            //Assert.IsInstanceOfType(typeof(AssessmentPointsApi), instance, "instance is a AssessmentPointsApi");
        }

        
        /// <summary>
        /// Test AssessmentPoint
        /// </summary>
        [Test]
        public void AssessmentPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.AssessmentPoint(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test AssessmentPointResults
        /// </summary>
        [Test]
        public void AssessmentPointResultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? assessmentPointRank = null;
            //List<int?> students = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.AssessmentPointResults(assessmentPointRank, students, perPage, page);
            //Assert.IsInstanceOf<ResultList> (response, "response is ResultList");
        }
        
        /// <summary>
        /// Test AssessmentPoints
        /// </summary>
        [Test]
        public void AssessmentPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perPage = null;
            //int? page = null;
            //var response = instance.AssessmentPoints(perPage, page);
            //Assert.IsInstanceOf<AssessmentPointList> (response, "response is AssessmentPointList");
        }
        
    }

}
