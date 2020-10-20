using NLog;
using Purgomalum.Service.Object;
using Purgomulum.Service.Object;

namespace Purgomalum.Service
{
    public class PurgomalumReplaceService
    {
        private ProcessedResponse _purgomalResponse;
        private readonly Logger _log;
        private readonly PurgomalumSettings _purgomalumSettings;
        private readonly PurgomalumServiceBase _purgomalumServiceBase;

        public PurgomalumReplaceService(PurgomalumSettings purgomalumSettings, PurgomalumServiceBase purgomalumServiceBase)
        {
            _log = LogManager.GetCurrentClassLogger();

            _purgomalumSettings = purgomalumSettings;

            _purgomalumServiceBase = purgomalumServiceBase;
        }

        public void SetDefaultService()
        {
            _log.Trace($"Using default {_purgomalumSettings.DefaultDataType} service");

            _purgomalumServiceBase.SetService(_purgomalumSettings.DefaultDataType);
        }

        public void SetCharacterReplacementService(string replacementCharacter)
        {
            _log.Trace("Using character replacement service");

            SetDefaultService();

            _purgomalumServiceBase.AddQueryStringParam(_purgomalumSettings.ReplaceCharacterService, replacementCharacter);
        }

        public void SetStringReplacementService(string replacementString)
        {
            _log.Trace("Using string replacement service");

            SetDefaultService();

            _purgomalumServiceBase.AddQueryStringParam(_purgomalumSettings.ReplaceStringService, replacementString);
        }

        public void ProcessText()
        {
            _log.Trace("Replacing profanitys...");

            _purgomalResponse = _purgomalumServiceBase.ExecuteReturnType<ProcessedResponse>();
        }

        public string GetProcessedText()
        {
            _log.Trace("Returning processed text");

            return _purgomalResponse.Result;
        }
    }
}