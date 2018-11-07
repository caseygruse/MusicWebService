using MusicWebService;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace LyricApi
{
    public class LyricService
    {
        HttpClient client = new HttpClient();

        public LyricService()
        {
            client.BaseAddress = new Uri("https://api.lyrics.ovh/v1/");
        }

        /// <summary>
        /// gets song lyrics based on artist and song title.
        /// Returns null if artist or song is not found.
        /// </summary>
        /// <param name="artist">Case insensitive artist name</param>
        /// <param name="songTitle">Case insensitive song title</param>
        /// <returns></returns>
        public LyricData GetLyrics(string artist, string songTitle)
        {
            //"https://api.lyrics.ovh/v1/artist/songTitle"
            HttpResponseMessage response = client.GetAsync($"{artist}/{songTitle}").Result;

            if (response.IsSuccessStatusCode)
            {
                string output = response.Content.ReadAsStringAsync().Result;
                output = output.Replace($"\\n", Environment.NewLine);
                //if conversion fails, every property gets default Value.
                LyricData serviceData = JsonConvert.DeserializeObject<LyricData>(output);
                //object containing lyrics
                return serviceData;
            }
            else
            {
                return null;
            }
        }

    }
}
