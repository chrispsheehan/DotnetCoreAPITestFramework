using NLog;
using Purgomalum.Service.Object;

namespace Purgomalum.Service
{
    public class PurgomalumReplaceAPI
    {
        private ProcessedResponse _purgomalResponse;
        private readonly Logger _log;
        private readonly PurgomalumAPI _purgomalumAPI;

        public PurgomalumReplaceAPI(PurgomalumAPI purgomalumAPI)
        {
            _log = LogManager.GetCurrentClassLogger();

            _purgomalumAPI = purgomalumAPI;
        }

        public void ProcessText(string text)
        {
            _log.Trace("Replacing profanitys...");

            _purgomalResponse = _purgomalumAPI.ExecuteReturnType<ProcessedResponse>();
        }

        public string GetProcessedText()
        {
            _log.Trace("Returning processed text");

            return _purgomalResponse.Result;
        }
    }
}