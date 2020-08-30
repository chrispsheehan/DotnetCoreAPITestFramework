using System;
using NLog;
using RestSharp;

namespace API.Wrapper
{
    public class APIBase
    {
        private readonly Logger _log;
        private readonly IRestClient _client;
        private readonly string _endPoint;
        private IRestRequest _request;

        public APIBase(Logger log, string aPIBaseUrl, string endPoint)
        {
            _log = log;

            _client = new RestClient
            {
                RemoteCertificateValidationCallback = (____, ___, __, _) => true,

                BaseUrl = new Uri(aPIBaseUrl)
            };

            _endPoint = endPoint;
        }

        public void SetService(string serviceName)
        {
            _request = new RestRequest
            {
                Resource = $"/{_endPoint}/{serviceName}",
                Method = Method.GET
            };
        }

        public void SetHeaderToPlainText()
        {
            _request.AddHeader("Accept", "text/plain");
        }

        public void AddQueryStringParam(string paramName, string paramValue)
        {
            _request.Parameters.Add(new Parameter(paramName, paramValue, ParameterType.QueryString));
        }

        public bool IsAvailable()
        {
            _request = new RestRequest
            {
                Method = Method.HEAD
            };
            return _client.Execute(_request).IsSuccessful;
        }

        public T ExecuteReturnType<T>() where T : new()
        {
            var response = _client.Execute<T>(_request);

            if (response.ErrorException != null)
            {
                const string errorMsg = "Error retrieving response.  Check inner details for more info.";

                _log.Error($"{errorMsg} {response.ErrorException}");

                throw new Exception(errorMsg, response.ErrorException);
            }
            return response.Data;
        }

        public string ExecuteReturnContent()
        {
            var response = _client.Execute(_request);

            if(string.IsNullOrEmpty(response.Content))
            {
                const string errorMsg = "No content found in reponse";

                _log.Error(errorMsg);

                throw new Exception(errorMsg);
            }

            return response.Content;
        }
    }
}