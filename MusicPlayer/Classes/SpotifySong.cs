using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Threading;

namespace MusicPlayer.Classes
{
    public class SpotifySong
    {
        private static string SpotifyToken = "BQD8FuYNVWP3SuVl1N8yRTdXPu3yzSWxFnRgUK-fPEvHnTiq7KEgl_BoEnDsLBg-jdmwGuyKiK7x6AmA8brNUWyaavGErVelJQLSUFvPv6GPXlQIX0PF2vnZs2Ugi8U8ff9rpyIvRGH_QZfsKYs0Z8OU_oUhTP61n33tDX02qT3t2rePf4JXmI4D3YEHZXI";
        private const string EndpointUrl = "https://api.spotify.com/v1/";

        public string id;
        public string name;
        public string artist;
        public string album;
        public string cover_url;

        public static void SetSpotifyToken(string token)
        {
            SpotifySong.SpotifyToken = token;
        }

        public static List<SpotifySong> Search(string query)
        {
            List<SpotifySong> songs = new List<SpotifySong>();

            //string result = SendRequestAsync("search?q=" + query + "&type=track").Result;
            //dynamic answer = JsonConvert.DeserializeObject(result);

            //if (answer.ContainsKey("error"))
            //{
            //    System.Windows.Forms.MessageBox.Show(result);
            //    File.WriteAllText("errore_" + query + ".txt", result);
            //}
            //else
            //{
            //    if (answer.ContainsKey("tracks"))
            //    {
            //        if (answer.tracks.ContainsKey("items"))
            //        {
            //            JArray items = answer.tracks.items;

            //            foreach (var item in items)
            //            {
            //                SpotifySong song = new SpotifySong();

            //                if (item.Contains("id")) song.id = item.Value<string>("id");
            //                if (item.Contains("name")) song.name = item.Value<string>("name");

            //                if (item.Contains("artists"))
            //                {
            //                    JArray artists = item.Value<JArray>("artists");

            //                    if (artists.Count > 0) song.artist = artists[0].Value<string>("name");
            //                }

            //                if (item.Contains("album"))
            //                {
            //                    var album = item.Value<JObject>("album");

            //                    song.album = album.Value<string>("name");

            //                    if (album.ContainsKey("images"))
            //                    {
            //                        JArray images = album.Value<JArray>("image");

            //                        if (images.Count > 0) song.cover_url = images[0].Value<string>("url");
            //                    }
            //                }

            //                songs.Add(song);
            //            }
            //        }
            //    }
            //}


            return songs;
        }

        public static string Search_Async(string query)
        {
            //var result = SendRequestAsync("search?q=" + query + "&type=track");

            return "";
        }

        public static async void SendRequestAsync(string parametrs)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(EndpointUrl)
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SpotifyToken);
            client.Timeout = TimeSpan.FromSeconds(10);

            var response = await client.GetAsync(parametrs);
            var result = await response.Content.ReadAsStringAsync();
        }
    }
}