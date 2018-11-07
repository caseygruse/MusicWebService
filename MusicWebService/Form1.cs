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
using Newtonsoft.Json;
using LyricApi;

namespace MusicWebService
{
    //http://json2csharp.com/

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ////attatching the web api address to the client.
            //client.BaseAddress = new Uri("https://api.lyrics.ovh/v1/");
            //client.DefaultRequestHeaders.Accept.Clear();
            ////telling service how we accept data  ( json response. )
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ////the app that is making the request.
            //client.DefaultRequestHeaders.Add("User-Agent", "My c# App");
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtLyrics.Clear();
            string artist = txtArtistName.Text;
            string songTitle = txtSongTitle.Text;
            LyricService ls = new LyricService();
            LyricData result = ls.GetLyrics(artist, songTitle);

            if(result != null)
            {
                txtLyrics.Text = result.Lyrics;
            }
            else
            {
                txtLyrics.Text = "song not found";
            }


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLyrics.ScrollBars = ScrollBars.Vertical;
        }
    }
}
