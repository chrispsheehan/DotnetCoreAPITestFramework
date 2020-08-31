using System;
using NLog;
using RestSharp;

namespace API.Wrapper
{
    public class APIBase
    {
        private readonly Logger _log;
        internal readonly IRestClient _client;
        private readonly string _endPoint;
        internal IRestRequest _request;

        public APIBase(string aPIBaseUrl, string endPoint)
        {
            _log = LogManager.GetCurrentClassLogger();

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
    }
}