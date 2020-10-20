using NLog;
using Purgomalum.Service.Object;

namespace Purgomalum.Service
{
    public class PurgomalumContainsService
    {
        private readonly Logger _log;
        private readonly PurgomalumServiceBase _purgomalumServiceBase;
        private readonly PurgomalumSettings _purgomalumSettings;
        private string _purgomalResponse;

        public PurgomalumContainsService(PurgomalumSettings purgomalumSettings, PurgomalumServiceBase purgomalumServiceBase)
        {
            _log = LogManager.GetCurrentClassLogger();

            _purgomalumServiceBase = purgomalumServiceBase;

            _purgomalumSettings = purgomalumSettings;
        }

        public void SetContainsService()
        {
            _log.Trace("Using contains profanity service");

            _purgomalumServiceBase.SetService(_purgomalumSettings.ContainsProfanityService);

            _purgomalumServiceBase.SetDataTypeHeader("text/plain");
        }

        public void ProcessText()
        {
            _log.Trace("Checking if text contains profanity");

            _purgomalResponse = _purgomalumServiceBase.ExecuteReturnContent();
        }

        public bool GetContainsBool()
        {
            bool.TryParse(_purgomalResponse, out bool parsedValue);

            return parsedValue;
        }
    }
}