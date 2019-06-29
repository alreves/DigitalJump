using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DigitalJump.BL
{
    public class DataProvider
    {
        private const string ServerUrl = "http://luca/digitalsadygov/hs/hrdata/";

        private HttpClient _client = new HttpClient();

        private void InitClient()
        {
            // Update port # in the following line.
            _client.BaseAddress = new Uri(ServerUrl);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public DataProvider()
        {
            InitClient();
        }

        public HttpClient GetClient()
        {
            return _client;
        }
    }

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

    public class MainStat
    {
        public int VacancyPractic
        {
            get; set;
        }

        public int ResumePractic
        {
            get; set;
        }

        public int AllResume
        {
            get; set;
        }

        public int AllVacancy
        {
            get; set;
        }
    }
}
