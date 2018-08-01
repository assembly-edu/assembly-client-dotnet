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
    ///  Class for testing AssessmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AssessmentsApiTests
    {
        private AssessmentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AssessmentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AssessmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AssessmentsApi
            //Assert.IsInstanceOfType(typeof(AssessmentsApi), instance, "instance is a AssessmentsApi");
        }

        
        /// <summary>
        /// Test Assessment
        /// </summary>
        [Test]
        public void AssessmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.Assessment(id);
            //Assert.IsInstanceOf<Assessment> (response, "response is Assessment");
        }
        
        /// <summary>
        /// Test AssessmentGradeSets
        /// </summary>
        [Test]
        public void AssessmentGradeSetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.AssessmentGradeSets(id, perPage, page);
            //Assert.IsInstanceOf<GradeSet> (response, "response is GradeSet");
        }
        
        /// <summary>
        /// Test AssessmentResults
        /// </summary>
        [Test]
        public void AssessmentResultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //List<int?> students = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.AssessmentResults(id, students, perPage, page);
            //Assert.IsInstanceOf<ResultList> (response, "response is ResultList");
        }
        
        /// <summary>
        /// Test Assessments
        /// </summary>
        [Test]
        public void AssessmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? misMappings = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.Assessments(misMappings, perPage, page);
            //Assert.IsInstanceOf<AssessmentList> (response, "response is AssessmentList");
        }
        
    }

}
