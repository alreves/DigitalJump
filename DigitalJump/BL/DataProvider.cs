using System;
using System.Net.Http;
using System.Net.Http.Headers;

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
}
