using DigitalJump.BL.Entities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigitalJump.BL.Service
{
    public class CandidateProvider : ProviderBase
    {    

        public async Task<Candidate> GetCandidateAsync(Guid uid)
        {
            var url = "kandidat/" + uid.ToString();

            var client = Provider.GetClient();

            Candidate result = null;

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var strResult = await response.Content.ReadAsStringAsync();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<Candidate>(strResult);
            }

            return result;
        }
    }
}
