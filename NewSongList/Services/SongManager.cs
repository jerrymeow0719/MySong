using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NewSongList.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace NewSongList.Services
{
    public class SongManager
    {
        //const string Url = ""; //Database URL

        //private async Task<HttpClient> GetClient()
        //{
        //    HttpClient client = new HttpClient();
        //    client.DefaultRequestHeaders.Add("Accept","application/json");
        //    return client;
        //}

        //public async Task<IEnumerable<MySong>> GetAll()
        //{
        //    HttpClient client = await GetClient();
        //    string result = await client.GetStringAsync(Url);
        //    return JsonConvert.DeserializeObject<IEnumerable<MySong>>(result);
        //}

        //public async Task<MySong> Add(MySong mySong)
        //{
        //    HttpClient client = await GetClient();
        //    var response = await client.PostAsync(Url,
        //        new StringContent(
        //            JsonConvert.SerializeObject(mySong),
        //            Encoding.UTF8, "application/json"));

        //    return JsonConvert.DeserializeObject<MySong>(await response.Content.ReadAsStringAsync());
        //}

        //public async Task Update(MySong mySong)
        //{
        //    HttpClient client = await GetClient();
        //    await client.PutAsync(Url + "/" + mySong.id,
        //        new StringContent(
        //            JsonConvert.SerializeObject(mySong),
        //            Encoding.UTF8, "application/json"));
        //}

        //public async Task Delete(int mySongid)
        //{
        //    HttpClient client = await GetClient();
        //    await client.DeleteAsync(Url + "/" + mySongid);
        //}

    }
}

