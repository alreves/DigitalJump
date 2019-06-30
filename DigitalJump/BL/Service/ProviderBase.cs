using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigitalJump.BL.Service
{
    public abstract class ProviderBase
    {
        protected DataProvider Provider
        {
            get; set;
        }

        public ProviderBase()
        {
            Provider = new DataProvider();
        }

        protected async Task<T> CallApiOperation<T>(string url) where T: class
        {
            var client = Provider.GetClient();

            T result = null;

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var strResult = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<T>(strResult);
            }

            return result;
        }
    }
}
