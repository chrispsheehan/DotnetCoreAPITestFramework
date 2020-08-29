using API.Wrapper;
using Purgomulum.Settings;

namespace Purgomalum.Service
{
    public class PurgomalumAPI : APIBase
    {
        private readonly PurgomalumSettings _purgomalumSettings;

        public PurgomalumAPI(PurgomalumSettings purgomalumSettings) : base(purgomalumSettings.BaseUrl, purgomalumSettings.Endpoint)
        {
            _purgomalumSettings = purgomalumSettings;
        }

        public void SetTextToBeProcessed(string text)
        {
            AddQueryStringParam(_purgomalumSettings.TextProcessParam, text);
        }

        public void SetDefaultResourse()
        {
            SetService(_purgomalumSettings.DefaultDataType);
        }

        public void SetContainsService()
        {
            SetService(_purgomalumSettings.ContainsProfanityService);

            SetHeaderToPlainText();
        }

        public void SetCharacterReplacementService(string replacementCharacter)
        {
            SetDefaultResourse();

            AddQueryStringParam(_purgomalumSettings.ReplaceCharacterService, replacementCharacter);
        }

        public void SetStringReplacementService(string replacementString)
        {
            SetDefaultResourse();

            AddQueryStringParam(_purgomalumSettings.ReplaceStringService, replacementString);
        }
    }
}