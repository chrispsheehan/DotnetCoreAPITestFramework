using System;
using Object;
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

                BaseUrl = new Uri(APIConstants.APIBaseUrl)
            };
        }

        public bool ProcessText(string text)
        {
            _request.Parameters.Add(new Parameter(APIConstants.TextProcessParam, text, ParameterType.QueryString));
            _response = _client.Execute(_request);
            return _response.IsSuccessful;
        }

        private void SetService(string serviceName)
        {
            _request = new RestRequest
            {
                Resource = $"/{APIConstants.Endpoint}/{serviceName}",
                Method = Method.GET
            };
        }

        public void SetContainsProfanityService()
        {
            SetService(APIConstants.ContainsProfanityService);

            _request.AddHeader("Accept", "text/plain");
        }

        public void SetDefaultService()
        {
            SetService(APIConstants.DefaultDataType);
        }

        public void SetCharacterReplacementService(string replacementCharacter)
        {
            SetDefaultService();

            AddParam(APIConstants.ReplaceCharacterService, replacementCharacter);
        }

        public void SetStringReplacementService(string replacementString)
        {
            SetDefaultService();

            AddParam(APIConstants.ReplaceStringService, replacementString);
        }

        private void AddParam(string parmaName, string paramValue)
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
            return deserializer.Deserialize<Response>(_response).Result;
        }
    }
}