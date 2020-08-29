using Purgomalum.Service.Object;

namespace Purgomalum.Service
{
    public class PurgomalumReplaceAPI
    {
        private ProcessedResponse _purgomalResponse;
        private readonly PurgomalumAPI _purgomalumAPI;

        public PurgomalumReplaceAPI(PurgomalumAPI purgomalumAPI)
        {
            _purgomalumAPI = purgomalumAPI;
        }

        public void ProcessText(string text)
        {
            _purgomalumAPI.SetTextToBeProcessed(text);

            _purgomalResponse = _purgomalumAPI.ExecuteReturnType<ProcessedResponse>();
        }

        public string GetProcessedText()
        {
            return _purgomalResponse.Result;
        }
    }
}