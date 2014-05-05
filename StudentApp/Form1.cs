using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string json;
        IEnumerable<jobs> baseQuery, currentQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            json = new WebClient().DownloadString(@"http://data.cityofnewyork.us/resource/99br-frp6.json");
        }

        private void rbtnq_CheckedChanged(object sender, EventArgs e)
        {
            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            var currentQuery = from j in jobs select j;
            currentQuery = from j in currentQuery where j.borough_community.Contains("Queens") select j;
            listBox1.Items.Clear();
            foreach (var j in currentQuery)
            {
                listBox1.Items.Add(j.agency);
            }
            MessageBox.Show(currentQuery.Count() + " jobs found");
        }

        private void rbtnm_CheckedChanged(object sender, EventArgs e)
        {
            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            var currentQuery = from j in jobs select j;
            currentQuery = from j in currentQuery where j.borough_community.Contains("Manhattan") select j;
            listBox1.Items.Clear();
            foreach (var j in currentQuery)
            {
                listBox1.Items.Add(j.agency);
            }
            MessageBox.Show(currentQuery.Count() + " jobs found");
        }

        private void rbtmbx_CheckedChanged(object sender, EventArgs e)
        {
            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            var currentQuery = from j in jobs select j;
            currentQuery = from j in currentQuery where j.borough_community.Contains("Bronx") select j;
            listBox1.Items.Clear();
            foreach (var j in currentQuery)
            {
                listBox1.Items.Add(j.agency);
            }
            MessageBox.Show(currentQuery.Count() + " jobs found");
        }

        private void rbtnbn_CheckedChanged(object sender, EventArgs e)
        {
            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            var currentQuery = from j in jobs select j;
            currentQuery = from j in currentQuery where j.borough_community.Contains("Brooklyn") select j;
            listBox1.Items.Clear();
            foreach (var j in currentQuery)
            {
                listBox1.Items.Add(j.agency);
            }
            MessageBox.Show(currentQuery.Count() + " jobs found");
        }

        private void rbtnst_CheckedChanged(object sender, EventArgs e)
        {
            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            var currentQuery = from j in jobs select j;
            currentQuery = from j in currentQuery where j.borough_community.Contains("Staten Island") select j;
            listBox1.Items.Clear();
            foreach (var j in currentQuery)
            {
                listBox1.Items.Add(j.agency);
            }
            MessageBox.Show(currentQuery.Count() + " jobs found");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            //var currentQuery = from j in currentQuery select j;
            //MessageBox.Show(j.contact_number);
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=-15.800513,-47.91378&zoom=11&size=200x200&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
            requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/streetview?size=200x200&location=40.720032,-73.988354&heading=235&sensor=false");
             repsonsePic = requestPic.GetResponse();
             map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox2.Image = map;
        }
    }
}
