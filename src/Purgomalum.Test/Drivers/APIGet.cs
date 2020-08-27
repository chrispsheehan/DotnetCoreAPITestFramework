using Object;
using RestSharp;
using RestSharp.Serialization.Json;

namespace Drivers
{
    public class APIGet : APIBase
    {
        public APIGet()
        {
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