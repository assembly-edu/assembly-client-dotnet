/* 
 * assembly.education
 *
 * Developer API for assembly.education.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
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

using assembly-client-dotnet.Client;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Model;

namespace assembly-client-dotnet.Test
{
    /// <summary>
    ///  Class for testing SubjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubjectsApiTests
    {
        private SubjectsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubjectsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubjectsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubjectsApi
            //Assert.IsInstanceOfType(typeof(SubjectsApi), instance, "instance is a SubjectsApi");
        }

        
        /// <summary>
        /// Test GetSubjects
        /// </summary>
        [Test]
        public void GetSubjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? misMappings = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetSubjects(misMappings, page, perPage);
            //Assert.IsInstanceOf<SubjectList> (response, "response is SubjectList");
        }
        
    }

}
