using API.Wrapper;
using NLog;
using Purgomulum.Settings;

namespace Purgomalum.Service
{
    public class PurgomalumServiceBase : APIBase
    {
        private readonly Logger _log;
        private readonly PurgomalumSettings _purgomalumSettings;

        public PurgomalumServiceBase(PurgomalumSettings purgomalumSettings)
            : base(purgomalumSettings.BaseUrl, purgomalumSettings.Endpoint)
        {
            _log = LogManager.GetCurrentClassLogger();

            _purgomalumSettings = purgomalumSettings;
        }

        public void SetTextToBeProcessed(string text)
        {
            _log.Trace($"Setting text '{text}' to be processed");

            AddQueryStringParam(_purgomalumSettings.TextProcessParam, text);
        }
    }
}