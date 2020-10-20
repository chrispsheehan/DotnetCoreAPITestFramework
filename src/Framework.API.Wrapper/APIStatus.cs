using NLog;
using RestSharp;

namespace API.Wrapper
{
    public class APIStatus : APIBase
    {
        private readonly Logger _log;

        public APIStatus(string aPIBaseUrl, string endPoint) : base(aPIBaseUrl, endPoint)
        {
            _log = LogManager.GetCurrentClassLogger();
        }

        public bool IsAvailable()
        {
            _log.Info("Checking service is available");

            _request = new RestRequest
            {
                Method = Method.HEAD
            };

            return _client.Execute(_request).IsSuccessful;
        }
    }
}