namespace Drivers
{
    public class PurgomalumAPI : APIBase
    {

        public PurgomalumAPI(string apiBaseUrl, string apiEndpoint) : base(apiBaseUrl, apiEndpoint)
        {

        }

        public void SetTextToBeProcessed(string text)
        {
            AddQueryStringParam(APIConstants.TextProcessParam, text);
        }
    }
}