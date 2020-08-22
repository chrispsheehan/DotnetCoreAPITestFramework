using System;
using RestSharp;
using RestSharp.Serialization.Json;

namespace Drivers
{
    public class APIDriver
    {
        private readonly IRestClient _client;
        private IRestResponse _response;
        private IRestRequest _request;

        public APIDriver()
        {
            _client = new RestClient
            {
                RemoteCertificateValidationCallback = (____, ___, __, _) => true,

                BaseUrl = new Uri("https://www.purgomalum.com")
            };
        }

        public bool ProcessText(string text)
        {
            _request.Parameters.Add(new Parameter("text", text, ParameterType.QueryString));
            _response = _client.Execute(_request);
            return _response.IsSuccessful;
        }

        public void SetService(string serviceName)
        {
            _request = new RestRequest
            {
                Resource = $"/service/{serviceName}",
                Method = Method.GET
            };

            if (string.Equals(serviceName, "containsprofanity", StringComparison.OrdinalIgnoreCase))
            {
                _request.AddHeader("Accept", "text/plain");
            }
        }

        public void AddParam(string parmaName, string paramValue)
        {
            _request.Parameters.Add(new Parameter(parmaName, paramValue, ParameterType.QueryString));
        }

        public bool IsUrlAvailable()
        {
            _request = new RestRequest
            {
                Method = Method.HEAD
            };
            return _client.Execute(_request).IsSuccessful;
        }

        public bool GetResultBool()
        {
            return bool.Parse(_response.Content);
        }

        public string GetResult()
        {
            var deserializer = new JsonDeserializer();
            return deserializer.Deserialize<APIResponse>(_response).Result;
        }
    }
}