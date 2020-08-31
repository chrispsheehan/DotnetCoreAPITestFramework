using API.Wrapper;
using NLog;
using Purgomulum.Settings;

namespace Purgomalum.Service
{
    public class PurgomalumAPI : APIBase
    {
        private readonly Logger _log;
        private readonly PurgomalumSettings _purgomalumSettings;

        public PurgomalumAPI(PurgomalumSettings purgomalumSettings) : base(purgomalumSettings.BaseUrl, purgomalumSettings.Endpoint)
        {
            _log = LogManager.GetCurrentClassLogger();

            _purgomalumSettings = purgomalumSettings;

            _log.Trace($"Initiating API {purgomalumSettings.BaseUrl}/{purgomalumSettings.Endpoint}");
        }

        public void SetTextToBeProcessed(string text)
        {
            _log.Trace($"Setting text '{text}' to be processed");

            AddQueryStringParam(_purgomalumSettings.TextProcessParam, text);
        }

        public void SetDefaultService()
        {
            _log.Trace($"Using default {_purgomalumSettings.DefaultDataType} service");

            SetService(_purgomalumSettings.DefaultDataType);
        }

        public void SetContainsService()
        {
            _log.Trace("Using contains profanity service");

            SetService(_purgomalumSettings.ContainsProfanityService);

            SetHeaderToPlainText();
        }

        public void SetCharacterReplacementService(string replacementCharacter)
        {
            _log.Trace("Using character replacement service");

            SetDefaultService();

            AddQueryStringParam(_purgomalumSettings.ReplaceCharacterService, replacementCharacter);
        }

        public void SetStringReplacementService(string replacementString)
        {
            _log.Trace("Using string replacement service");

            SetDefaultService();

            AddQueryStringParam(_purgomalumSettings.ReplaceStringService, replacementString);
        }
    }
}