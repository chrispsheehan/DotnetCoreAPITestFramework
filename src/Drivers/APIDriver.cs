using System;
using System.Net;
using RestSharp;

namespace Drivers
{
    public class APIDriver
    {
        private readonly RestClient _client;

        private RestRequest _restRequest;

        public APIDriver()
        {
            _client = new RestClient
            {
                BaseUrl = new Uri("https://www.purgomalum.com")
            };
        }

        public void SetService(string serviceName)
        {
            _restRequest = new RestRequest
            {
                Resource = $"Service/{serviceName}"
            };
        }

        public bool IsAPIAvailable()
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(_client.BaseUrl) as HttpWebRequest;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch
            {
                return false;
            }
        }
    }
}
