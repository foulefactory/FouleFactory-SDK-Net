/*
 * FouleFactoryApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/14/2016
 */
using System;
using FouleFactoryApi.PCL.Controllers;
using FouleFactoryApi.PCL.Http.Client;

namespace FouleFactoryApi.PCL
{
    public partial class FouleFactoryApiClient
    {

        /// <summary>
        /// Singleton access to TaskAnswerTexts controller
        /// </summary>
        public TaskAnswerTextsController TaskAnswerTexts
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.TaskAnswerTextsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to TaskAnswerChoices controller
        /// </summary>
        public TaskAnswerChoicesController TaskAnswerChoices
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.TaskAnswerChoicesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Projects controller
        /// </summary>
        public ProjectsController Projects
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.ProjectsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to CsvFiles controller
        /// </summary>
        public CsvFilesController CsvFiles
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.CsvFilesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Account controller
        /// </summary>
        public AccountController Account
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.AccountController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Templates controller
        /// </summary>
        public TemplatesController Templates
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.TemplatesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Tasks controller
        /// </summary>
        public TasksController Tasks
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.TasksController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to TaskLines controller
        /// </summary>
        public TaskLinesController TaskLines
        {
            get
            {
                return FouleFactoryApi.PCL.Controllers.TaskLinesController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public FouleFactoryApiClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public FouleFactoryApiClient(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
    }
}