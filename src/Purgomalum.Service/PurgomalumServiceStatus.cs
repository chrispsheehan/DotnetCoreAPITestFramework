using API.Wrapper;
using NLog;
using Purgomulum.Settings;

namespace Purgomalum.Service
{
    public class PurgomalumServiceStatus : APIStatus
    {
        private readonly Logger _log;

        public PurgomalumServiceStatus(PurgomalumSettings purgomalumSettings) 
            : base(purgomalumSettings.BaseUrl, purgomalumSettings.Endpoint)
        {
            _log = LogManager.GetCurrentClassLogger();
        }
    }
}