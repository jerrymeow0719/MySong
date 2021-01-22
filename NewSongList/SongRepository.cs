using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NewSongList.Models;
using Newtonsoft.Json;

namespace NewSongList
{
    public class SongRepository
    {
        private readonly string dburl = "https://localhost:5001/api/Song";

        public SongRepository()
        {

        }

        public async Task<IEnumerable<MySong>> GetNewSongAsync()
        {
            List<MySong> List = new List<MySong>();
            string uri = dburl + "?songtype=1";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                string result = await client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<IEnumerable<MySong>>(result);
            }
        }

        public void GetSongRankAsync(int store, string songtype)
        {
        }
    }
}
