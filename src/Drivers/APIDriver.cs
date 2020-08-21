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
