﻿using DigitalJump.BL.Entities;
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

            var client = Provider.GetClient();

            List<Vacancy> result = null;

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var strResult = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Vacancy>>(strResult);
            }

            return result;
        }

        public async Task<Vacancy> GetVacancyByUidAsync(Guid uid)
        {
            var url = "vacancydata/" + uid.ToString();

            var client = Provider.GetClient();

            Vacancy result = null;

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var strResult = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<Vacancy>(strResult);
            }

            return result;
        }

        
    }
}
