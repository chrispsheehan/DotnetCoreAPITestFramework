using Object;

namespace PurgomalumService
{
    public class PurgomalumReplaceAPI
    {
        private Response _purgomalResponse;
        private readonly PurgomalumAPI _purgomalumAPI;

        public PurgomalumReplaceAPI(PurgomalumAPI purgomalumAPI)
        {
            _purgomalumAPI = purgomalumAPI;

            _purgomalumAPI.SetService(APIConstants.DefaultDataType);
        }

        public void ProcessText(string text)
        {
            _purgomalumAPI.SetTextToBeProcessed(text);

            _purgomalResponse = _purgomalumAPI.ExecuteReturnType<Response>();
        }

        public string GetProcessedText()
        {
            return _purgomalResponse.Result;
        }

        public void SetCharacterReplacementService(string replacementCharacter)
        {
            _purgomalumAPI.AddQueryStringParam(APIConstants.ReplaceCharacterService, replacementCharacter);
        }

        public void SetStringReplacementService(string replacementString)
        {
            _purgomalumAPI.AddQueryStringParam(APIConstants.ReplaceStringService, replacementString);
        }
    }
}