using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace MusicWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //attatching the web api address to the client.
            client.BaseAddress = new Uri("https://api.lyrics.ovh/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            //telling service how we accept data  ( json response. )
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //the app that is making the request.
            client.DefaultRequestHeaders.Add("User-Agent", "My c# App");
        }

        //client communicates with web service.
        HttpClient client = new HttpClient();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string artist = txtArtistName.Text;
            string songTitle = txtSongTitle.Text;
            //"https://api.lyrics.ovh/v1/artist/songTitle"
            HttpResponseMessage response = client.GetAsync($"{artist}/{songTitle}").Result;

            if (response.IsSuccessStatusCode)
            {
                string output = response.Content.ReadAsStringAsync().Result;
                output = output.Replace($"\\n", " ");
                txtLyrics.Text = output;
            }
            else
            {
                txtLyrics.Text = "Not Found";
            }
        }
    }
}
