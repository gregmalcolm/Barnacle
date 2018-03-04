using Barnacle.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Services
{
    public class EliteBgsReader
    {
        private static EliteBgsReader _instance;
        private HttpClient _client;
        
        public static bool IsRunning { get; set; }

        private EliteBgsReader() {
            InitHttpClient();
        }

        private void InitHttpClient()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://elitebgs.kodeblox.com")
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public static void Download()
        {
            if (!IsRunning)
            {
                Instance.DoDownload();
            }
        }

        public static EliteBgsReader Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EliteBgsReader();
                }
                return _instance;
            }
        }

        public void DoDownload()
        {
            new Systems().All.ForEach((system) =>
            {
                GetSystemsAsync(system).GetAwaiter().GetResult();
            });
        }

        public async Task GetSystemsAsync(String system)
        {
            var url = $"/api/ebgs/v4/systems?name={system}";
            HttpResponseMessage response = await _client.GetAsync(url).ConfigureAwait(false);
            HttpContent content = response.Content;

            // ... Read the string.
            string result = await content.ReadAsStringAsync();

            // ... Display the result.
            if (result != null)
            {
                string json = JsonConvert.SerializeObject(result);
            }
        }
    }
}
