using System;
using NLog;
using RestSharp;

namespace API.Wrapper
{
    public class APIExecute : APIBase
    {
        private readonly Logger _log;

        public APIExecute(string aPIBaseUrl, string endPoint) : base(aPIBaseUrl, endPoint)
        {
            _log = LogManager.GetCurrentClassLogger();
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