using API.Wrapper;
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