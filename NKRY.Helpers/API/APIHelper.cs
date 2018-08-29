using RestSharp;
using System;

namespace NKRY.Helpers.API
{
    public class APIHelper
    {
        #region Variables
        private readonly string _accountName;
        private readonly string _projectName;
        private readonly string _pat;
        private readonly Uri _baseUrl;
        private RestClient _client;
        private RestRequest _request;
        #endregion

        #region Constructors
        public APIHelper(string accountName, string projectName, string privateAccessToken)
        {
            _accountName = accountName;
            _projectName = projectName;
            _pat = privateAccessToken;
            _baseUrl = new Uri($"https://{_accountName}.visualstudio.com/{_projectName}/");
        }
        #endregion

        #region Methods

    }
}