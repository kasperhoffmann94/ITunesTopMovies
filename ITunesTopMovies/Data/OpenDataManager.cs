using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ITunesTopMovies.Data
{
    class OpenDataManager
    {
        private string URL = "https://itunes.apple.com/us/rss/topmovies/limit=25/json";

        public OpenDataManager()
        {

        }

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            //login information and confirmation


            client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;
        }

        public async Task<OpenDataItem> GetAll()
        {
            HttpClient client = GetClient();
            string StrResult = await client.GetStringAsync(URL);
            return JsonConvert.DeserializeObject<OpenDataItem>(StrResult);

        }
    }
}
