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
    ///  Class for testing StudentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StudentsApiTests
    {
        private StudentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StudentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StudentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StudentsApi
            //Assert.IsInstanceOfType(typeof(StudentsApi), instance, "instance is a StudentsApi");
        }

        
        /// <summary>
        /// Test GetStudents
        /// </summary>
        [Test]
        public void GetStudentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string yearCode = null;
            //string students = null;
            //string date = null;
            //bool? demographics = null;
            //bool? contacts = null;
            //bool? senNeeds = null;
            //bool? addresses = null;
            //bool? care = null;
            //bool? languages = null;
            //int? page = null;
            //int? perPage = null;
            //string ifModifiedSince = null;
            //var response = instance.GetStudents(yearCode, students, date, demographics, contacts, senNeeds, addresses, care, languages, page, perPage, ifModifiedSince);
            //Assert.IsInstanceOf<StudentList> (response, "response is StudentList");
        }
        
        /// <summary>
        /// Test GetStudentsStudentId
        /// </summary>
        [Test]
        public void GetStudentsStudentIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string studentId = null;
            //string date = null;
            //bool? demographics = null;
            //bool? contacts = null;
            //bool? senNeeds = null;
            //bool? addresses = null;
            //bool? care = null;
            //bool? languages = null;
            //string ifModifiedSince = null;
            //var response = instance.GetStudentsStudentId(studentId, date, demographics, contacts, senNeeds, addresses, care, languages, ifModifiedSince);
            //Assert.IsInstanceOf<Student> (response, "response is Student");
        }
        
    }

}
