/*
 * FouleFactoryApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/14/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FouleFactoryApi.PCL;
using FouleFactoryApi.PCL.Http.Request;
using FouleFactoryApi.PCL.Http.Response;
using FouleFactoryApi.PCL.Http.Client;
using FouleFactoryApi.PCL.Exceptions;
using FouleFactoryApi.PCL.Models;

namespace FouleFactoryApi.PCL.Controllers
{
    public partial class TasksController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TasksController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TasksController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TasksController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Validate task
        /// </summary>
        /// <param name="task">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateTasksValidate(TaskValidationWriterServiceModel task, string acceptLanguage = "fr")
        {
            Task<dynamic> t = UpdateTasksValidateAsync(task, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Validate task
        /// </summary>
        /// <param name="task">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateTasksValidateAsync(TaskValidationWriterServiceModel task, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/tasks");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(task);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get task answer choices by task id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetTasksGetAnswerChoices(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetTasksGetAnswerChoicesAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get task answer choices by task id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetTasksGetAnswerChoicesAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/tasks/{id}/taskAnswerChoices");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get task answer texts by task id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetTasksGetAnswerTexts(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetTasksGetAnswerTextsAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get task answer texts by task id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetTasksGetAnswerTextsAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/tasks/{id}/taskAnswerTexts");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get task by id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetTasksGet(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetTasksGetAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get task by id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetTasksGetAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/tasks/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 