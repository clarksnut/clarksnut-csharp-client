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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPartiesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get parties
        /// </summary>
        /// <remarks>
        /// This will search parties on allowed spaces and current user
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>GenericDataRepresentationListPartyData</returns>
        GenericDataRepresentationListPartyData GetParties (string q = null, int? offset = null, int? limit = null, List<string> space = null);

        /// <summary>
        /// Get parties
        /// </summary>
        /// <remarks>
        /// This will search parties on allowed spaces and current user
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>ApiResponse of GenericDataRepresentationListPartyData</returns>
        ApiResponse<GenericDataRepresentationListPartyData> GetPartiesWithHttpInfo (string q = null, int? offset = null, int? limit = null, List<string> space = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get parties
        /// </summary>
        /// <remarks>
        /// This will search parties on allowed spaces and current user
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>Task of GenericDataRepresentationListPartyData</returns>
        System.Threading.Tasks.Task<GenericDataRepresentationListPartyData> GetPartiesAsync (string q = null, int? offset = null, int? limit = null, List<string> space = null);

        /// <summary>
        /// Get parties
        /// </summary>
        /// <remarks>
        /// This will search parties on allowed spaces and current user
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>Task of ApiResponse (GenericDataRepresentationListPartyData)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenericDataRepresentationListPartyData>> GetPartiesAsyncWithHttpInfo (string q = null, int? offset = null, int? limit = null, List<string> space = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PartiesApi : IPartiesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PartiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartiesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PartiesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Get parties This will search parties on allowed spaces and current user
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>GenericDataRepresentationListPartyData</returns>
        public GenericDataRepresentationListPartyData GetParties (string q = null, int? offset = null, int? limit = null, List<string> space = null)
        {
             ApiResponse<GenericDataRepresentationListPartyData> localVarResponse = GetPartiesWithHttpInfo(q, offset, limit, space);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get parties This will search parties on allowed spaces and current user
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>ApiResponse of GenericDataRepresentationListPartyData</returns>
        public ApiResponse< GenericDataRepresentationListPartyData > GetPartiesWithHttpInfo (string q = null, int? offset = null, int? limit = null, List<string> space = null)
        {

            var localVarPath = "/api/parties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (q != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "q", q)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (space != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("multi", "space", space)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetParties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GenericDataRepresentationListPartyData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GenericDataRepresentationListPartyData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenericDataRepresentationListPartyData)));
        }

        /// <summary>
        /// Get parties This will search parties on allowed spaces and current user
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>Task of GenericDataRepresentationListPartyData</returns>
        public async System.Threading.Tasks.Task<GenericDataRepresentationListPartyData> GetPartiesAsync (string q = null, int? offset = null, int? limit = null, List<string> space = null)
        {
             ApiResponse<GenericDataRepresentationListPartyData> localVarResponse = await GetPartiesAsyncWithHttpInfo(q, offset, limit, space);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get parties This will search parties on allowed spaces and current user
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q">Search text (optional)</param>
        /// <param name="offset">First result (optional, default to 0)</param>
        /// <param name="limit">Max result (optional, default to 10)</param>
        /// <param name="space">Spaces Id where to search parties (optional)</param>
        /// <returns>Task of ApiResponse (GenericDataRepresentationListPartyData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GenericDataRepresentationListPartyData>> GetPartiesAsyncWithHttpInfo (string q = null, int? offset = null, int? limit = null, List<string> space = null)
        {

            var localVarPath = "/api/parties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (q != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "q", q)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (space != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("multi", "space", space)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetParties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GenericDataRepresentationListPartyData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GenericDataRepresentationListPartyData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GenericDataRepresentationListPartyData)));
        }

    }
}
