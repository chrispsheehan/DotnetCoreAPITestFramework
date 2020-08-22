using System;
using System.Net;
using RestSharp;

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

        public bool Process(string text)
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

        public bool IsUrlAvailable()
        {
            HttpWebResponse response;

            try
            {
                HttpWebRequest request = WebRequest.Create(_client.BaseUrl) as HttpWebRequest;
                request.Method = "HEAD";
                response = request.GetResponse() as HttpWebResponse;
                bool result = response.StatusCode == HttpStatusCode.OK;
                response.Close();
                return result;
            }
            catch
            {
                return false;
            }
        }
    }
}
