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
            return await CallApiOperation<Candidate>(url);
        }
    }
}
