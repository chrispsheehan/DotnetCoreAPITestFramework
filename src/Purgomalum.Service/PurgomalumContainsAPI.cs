namespace PurgomalumService
{
    public class PurgomalumContainsAPI
    {
        private string _purgomalResponse;
        private readonly PurgomalumAPI _purgomalumAPI;

        public PurgomalumContainsAPI(PurgomalumAPI purgomalumAPI)
        {
            _purgomalumAPI = purgomalumAPI;
        }

        public void SetContainsService()
        {
            _purgomalumAPI.SetService(APIConstants.ContainsProfanityService);

            _purgomalumAPI.SetHeaderToPlainText();
        }

        public void ProcessText(string text)
        {
            _purgomalumAPI.SetTextToBeProcessed(text);

            _purgomalResponse = _purgomalumAPI.ExecuteReturnContent();
        }

        public bool GetContainsBool()
        {
            bool.TryParse(_purgomalResponse, out bool parsedValue);

            return parsedValue;
        }
    }
}