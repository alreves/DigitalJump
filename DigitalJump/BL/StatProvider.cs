using System.Net.Http;
using System.Threading.Tasks;

namespace DigitalJump.BL
{
    public class StatProvider
    {
        private DataProvider Provider
        {
            get; set;
        }

        public StatProvider()
        {
            Provider = new DataProvider();
        }

        public async Task<MainStat> GetStatAsync()
        {
            var url = "stat";

            var client = Provider.GetClient();

            MainStat result = null;

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var strResult = await response.Content.ReadAsStringAsync();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<MainStat>(strResult);
            }

            return result;
        }
    }
}
