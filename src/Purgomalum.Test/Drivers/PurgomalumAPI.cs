using RestSharp;

namespace Drivers
{
    public class PurgomalumAPI : APIGet
    {
        public PurgomalumAPI()
        {
        }

        public bool ProcessText(string text)
        {
            _request.Parameters.Add(new Parameter(APIConstants.TextProcessParam, text, ParameterType.QueryString));
            _response = _client.Execute(_request);
            return _response.IsSuccessful;
        }

        public void SetContainsProfanityService()
        {
            SetService(APIConstants.ContainsProfanityService);

            _request.AddHeader("Accept", "text/plain");
        }

        public void SetDefaultService()
        {
            SetService(APIConstants.DefaultDataType);
        }

        public void SetCharacterReplacementService(string replacementCharacter)
        {
            SetDefaultService();

            AddParam(APIConstants.ReplaceCharacterService, replacementCharacter);
        }

        public void SetStringReplacementService(string replacementString)
        {
            SetDefaultService();

            AddParam(APIConstants.ReplaceStringService, replacementString);
        }
    }
}