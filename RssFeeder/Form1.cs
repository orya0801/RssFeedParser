using RssFeeder.Core;
using RssFeeder.Core.RssFeed;
using RssFeeder.Core.XmlModels;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Text.RegularExpressions;

namespace RssFeeder
{
    public partial class Form1 : Form
    {
        ParserWorker<ItemModel[]> parser;
        Timer timer = new Timer();
        string title;


        public Form1()
        {
            InitializeComponent();

            //Настройка парсера
            parser = new ParserWorker<ItemModel[]>(new RssFeedParser())
            {
                Settings = new RssFeedParserSettings()
            };

            parser.OnCompleted += Parser_OnComlpeted;
            parser.OnNewData += Parser_OnNewData;
            parser.OnOpenLink += Parser_OnOpenLink;
            parser.OnDescription += Parser_OnDescription;

            //Установка параметров таймера
            timer.Interval = Properties.Settings.Default.Timer;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MainBox.Items.Clear();
            parser.Start();
        }


        private void Parser_OnDescription(object arg1, ItemModel[] arg2, string title)
        {
            ItemModel currItem = new ItemModel();
            foreach (var item in arg2)
            {
                if (item.Title == title)
                {
                    currItem = item;
                    break;
                }
            }
            DescriptionForm descriptionForm = new DescriptionForm();
            descriptionForm.LabelTitle.Text = currItem.Title;
            currItem.Description = Regex.Replace(currItem.Description, "<[^>]+>", "");
            currItem.Description = Regex.Replace(currItem.Description, "Читать дальше &rarr;", "");
            descriptionForm.LabelDescription.Text = currItem.Description;
            descriptionForm.LabelPubDate.Text = "Дата публикации " + currItem.PubDate.ToString("F");
            descriptionForm.Show();
        }

        private void Parser_OnOpenLink(object arg1, ItemModel[] arg2, string title)
        {
            ItemModel currItem = new ItemModel();
            foreach (var item in arg2)
            {
                if(item.Title == title)
                {
                    currItem = item;
                    break;
                }    
            }
            Process.Start(currItem.Link);
        }

        private void Parser_OnNewData(object arg1, ItemModel[] arg2)
        {
            foreach(var item in arg2)
            {
                try
                {
                    MainBox.Items.Add(item.Title);
                }
                catch
                {
                    MainBox.Items.Add("Неудача");
                }
            }
            
        }

        private void Parser_OnComlpeted(object obj)
        {
            MessageBox.Show("All work has done!");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MainBox.Items.Clear();

            parser.Start();

            timer.Start();
        }

        private void MainBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string title = MainBox.SelectedItem.ToString();

            parser.FindLinkWithTitle(title);
        }

        private void ButtonDescription_Click(object sender, EventArgs e)
        {
            try
            {
                title = MainBox.SelectedItem.ToString();
                parser.OpenDescription(title);
            }
            catch
            {
                return;
            }
        }
    }
}
