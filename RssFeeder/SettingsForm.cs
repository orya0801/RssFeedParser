using RssFeeder.Core;
using RssFeeder.Core.RssFeed;
using RssFeeder.Core.XmlModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssFeeder
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ButtonUpdateRssFeed_Click(object sender, EventArgs e)
        {
            string newFeed = TextBoxRssFeed.Text;
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(newFeed);
                Properties.Settings.Default.Url = newFeed;
                Properties.Settings.Default.Save();
                MessageBox.Show("URL changed successfully.The program will restart");
            }
            catch
            {
                MessageBox.Show($"Rss Feed {newFeed} wasn't found. Check the link!");
                return;
            }
            
        }

        private void ButtonUpdateFreq_Click(object sender, EventArgs e)
        {
            try
            {
                int newFreq = int.Parse(TextBoxUpdateFreq.Text);
                newFreq *= 1000 * 60;
                Properties.Settings.Default.Timer = newFreq;
                Properties.Settings.Default.Save();
                MessageBox.Show("URL changed successfully. Press Start button to activate changes or wait for automatic program update");
            }
            catch
            {
                MessageBox.Show($"Error! Enter an integer number of minutes");
                return;
            }
        }
    }
}
