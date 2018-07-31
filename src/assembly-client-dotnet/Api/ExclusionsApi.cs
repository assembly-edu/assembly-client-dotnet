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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace assembly-client-dotnet.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExclusionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ExclusionList</returns>
        ExclusionList GetExclusions (string startDate = null, string endDate = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ExclusionList</returns>
        ApiResponse<ExclusionList> GetExclusionsWithHttpInfo (string startDate = null, string endDate = null, int? page = null, int? perPage = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ExclusionList</returns>
        ExclusionList GetExclusionsStudentId (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ExclusionList</returns>
        ApiResponse<ExclusionList> GetExclusionsStudentIdWithHttpInfo (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ExclusionList</returns>
        System.Threading.Tasks.Task<ExclusionList> GetExclusionsAsync (string startDate = null, string endDate = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ExclusionList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExclusionList>> GetExclusionsAsyncWithHttpInfo (string startDate = null, string endDate = null, int? page = null, int? perPage = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ExclusionList</returns>
        System.Threading.Tasks.Task<ExclusionList> GetExclusionsStudentIdAsync (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </remarks>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ExclusionList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExclusionList>> GetExclusionsStudentIdAsyncWithHttpInfo (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExclusionsApi : IExclusionsApi
    {
        private assembly-client-dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExclusionsApi(String basePath)
        {
            this.Configuration = new assembly-client-dotnet.Client.Configuration { BasePath = basePath };

            ExceptionFactory = assembly-client-dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExclusionsApi(assembly-client-dotnet.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = assembly-client-dotnet.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = assembly-client-dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public assembly-client-dotnet.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public assembly-client-dotnet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ExclusionList</returns>
        public ExclusionList GetExclusions (string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {
             ApiResponse<ExclusionList> localVarResponse = GetExclusionsWithHttpInfo(startDate, endDate, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ExclusionList</returns>
        public ApiResponse< ExclusionList > GetExclusionsWithHttpInfo (string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {

            var localVarPath = "/exclusions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExclusions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExclusionList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExclusionList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExclusionList)));
        }

        /// <summary>
        ///  Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ExclusionList</returns>
        public async System.Threading.Tasks.Task<ExclusionList> GetExclusionsAsync (string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {
             ApiResponse<ExclusionList> localVarResponse = await GetExclusionsAsyncWithHttpInfo(startDate, endDate, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ExclusionList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExclusionList>> GetExclusionsAsyncWithHttpInfo (string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {

            var localVarPath = "/exclusions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExclusions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExclusionList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExclusionList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExclusionList)));
        }

        /// <summary>
        ///  Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ExclusionList</returns>
        public ExclusionList GetExclusionsStudentId (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {
             ApiResponse<ExclusionList> localVarResponse = GetExclusionsStudentIdWithHttpInfo(studentId, startDate, endDate, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ExclusionList</returns>
        public ApiResponse< ExclusionList > GetExclusionsStudentIdWithHttpInfo (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'studentId' is set
            if (studentId == null)
                throw new ApiException(400, "Missing required parameter 'studentId' when calling ExclusionsApi->GetExclusionsStudentId");

            var localVarPath = "/exclusions/{student_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (studentId != null) localVarPathParams.Add("student_id", this.Configuration.ApiClient.ParameterToString(studentId)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExclusionsStudentId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExclusionList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExclusionList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExclusionList)));
        }

        /// <summary>
        ///  Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ExclusionList</returns>
        public async System.Threading.Tasks.Task<ExclusionList> GetExclusionsStudentIdAsync (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {
             ApiResponse<ExclusionList> localVarResponse = await GetExclusionsStudentIdAsyncWithHttpInfo(studentId, startDate, endDate, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.
        /// </summary>
        /// <exception cref="assembly-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ExclusionList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExclusionList>> GetExclusionsStudentIdAsyncWithHttpInfo (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'studentId' is set
            if (studentId == null)
                throw new ApiException(400, "Missing required parameter 'studentId' when calling ExclusionsApi->GetExclusionsStudentId");

            var localVarPath = "/exclusions/{student_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (studentId != null) localVarPathParams.Add("student_id", this.Configuration.ApiClient.ParameterToString(studentId)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExclusionsStudentId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExclusionList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExclusionList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExclusionList)));
        }

    }
}
