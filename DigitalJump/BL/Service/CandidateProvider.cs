using DigitalJump.BL.Entities;
using System;
using System.Collections.Generic;
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

        public async Task<List<Candidate>> GetCandidats(string specUid)
        {
            if (string.IsNullOrEmpty(specUid))
            {
                specUid = "c829dd7e-9a84-11e9-ab55-00155d853f43";
            }
            var url = "speckandidats/" + specUid;
            return await CallApiOperation<List<Candidate>>(url);
        }
    }
}
