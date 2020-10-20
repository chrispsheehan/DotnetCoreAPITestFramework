using API.Wrapper;
using Purgomalum.Service.Object;

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