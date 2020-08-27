using System;
using Drivers;
using RestSharp;

namespace Drivers
{
    public class APIBase
    {
        public readonly IRestClient _client;
        public IRestResponse _response;
        public IRestRequest _request;

        public APIBase()
        {
            _client = new RestClient
            {
                RemoteCertificateValidationCallback = (____, ___, __, _) => true,

                BaseUrl = new Uri(APIConstants.APIBaseUrl)
            };
        }

        internal void SetService(string serviceName)
        {
            _request = new RestRequest
            {
                Resource = $"/{APIConstants.Endpoint}/{serviceName}",
                Method = Method.GET
            };
        }

        internal void AddParam(string parmaName, string paramValue)
        {
            _request.Parameters.Add(new Parameter(parmaName, paramValue, ParameterType.QueryString));
        }
    }
}