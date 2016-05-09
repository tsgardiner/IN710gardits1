using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningStrikes
{
    public partial class Form1 : Form
    {

        lightningStrikesDBDataContext db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new lightningStrikesDBDataContext();
        }



        private void btnAvgAllStrikes_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<int> averageIntensity = new List<int>();
            //int averageIntensity = 0;

            var allStrikes = from s in db.tblStrikes
                             select s;

            foreach (var item in allStrikes)
            {
                averageIntensity.Add(item.strikeIntensity);
            }

            richTextBox1.AppendText("Average of all lightning strikes: " + averageIntensity.Average().ToString());

        }
                       

        private void btnThreeLargestFires_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var threeFires = (from f in db.tblFires
                             orderby f.fireArea descending
                             select f).Take(3);

            richTextBox1.AppendText("ID " + "\t" +
                                    "Date" + "\t\t" +
                                    "Latitude" + "\t\t" +
                                    "Longitude" + "\t\t" +
                                    "Fire Area" + "\n\n");

            foreach (var item in threeFires)
            {
                richTextBox1.AppendText(item.fireID.ToString() +  "\t" +
                                        item.fireDate.ToShortDateString() + "\t" +
                                        item.fireLatitude.ToString() + "\t\t" +
                                        item.fireLongitude.ToString() + "\t\t" +
                                        item.fireArea.ToString() + "\n\n");
            }
  
        }

        private void btnLatLongPicture_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            var picturesLatLong = from p in db.tblPictures
                                  join s in db.tblStrikes
                                  on p.strikeID equals s.strikeID
                                  select new { p.pictureFileName, s.strikeLatitude , s.strikeLongitude  };

            richTextBox1.AppendText("Filename" + "\t\t\t" +
                                    "Latitude" + "\t\t" +
                                    "Longitude" + "\n\n");

            foreach (var item in picturesLatLong)
            {
                richTextBox1.AppendText(item.pictureFileName + "\t\t" +
                                        item.strikeLatitude.ToString() + "\t\t" +
                                        item.strikeLongitude + "\n\n");               
            }
        }

        private void btnFireLightning_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            var fires = from f in db.tblFires
                        join s in db.tblStrikes
                        on f.fireDate equals s.strikeDate
                        where f.fireLatitude == s.strikeLatitude 
                        &&    f.fireLatitude == s.strikeLatitude
                        select f;

            richTextBox1.AppendText("Fire Area" + "\t\t" +
                                    "Latitude" + "\t\t" +
                                    "Longitude" + "\n\n");

            foreach (var item in fires)
            {
                richTextBox1.AppendText(item.fireArea.ToString() + "\t\t" +
                                        item.fireLatitude.ToString() + "\t\t" +
                                        item.fireLongitude.ToString() + "\n\n");
            }

        }

        
    }
}
