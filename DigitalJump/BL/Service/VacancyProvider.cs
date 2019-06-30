using DigitalJump.BL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigitalJump.BL.Service
{
    public class VacancyProvider : ProviderBase
    {
        public async Task<List<Vacancy>> GetVacancyAsync()
        {
            var url = "activevacancy";
            return await CallApiOperation<List<Vacancy>>(url);
        }

        public async Task<Vacancy> GetVacancyByUidAsync(Guid uid)
        {
            var url = "vacancydata/" + uid.ToString();
            return await CallApiOperation<Vacancy>(url);
        }        
    }
}
