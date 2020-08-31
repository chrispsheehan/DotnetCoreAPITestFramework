using API.Wrapper;
using NLog;
using Purgomulum.Settings;

namespace Purgomalum.Service
{
    public class PurgomalumServiceStatus : APIStatus
    {
        public PurgomalumServiceStatus(PurgomalumSettings purgomalumSettings)
            : base(purgomalumSettings.BaseUrl, purgomalumSettings.Endpoint)
        {

        }
    }
}