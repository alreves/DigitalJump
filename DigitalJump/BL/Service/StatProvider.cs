using DigitalJump.BL.Entities;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigitalJump.BL.Service
{
    public class StatProvider: ProviderBase
    {
        public async Task<MainStat> GetStatAsync()
        {
            var url = "stat";
            return await CallApiOperation<MainStat>(url);
        }
    }
}
