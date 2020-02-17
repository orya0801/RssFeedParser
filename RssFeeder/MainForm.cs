using RssFeeder.Core;
using RssFeeder.Core.RssFeed;
using RssFeeder.Core.RssModels;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;



/// <summary>
/// TODO
/// 1. Доделать форму Settings
/// 2. Комментирование кода
/// 3. Код-ревью, поиск ошибок
/// 4. Оптимизация через Task-и
/// </summary>



namespace RssFeeder
{
    public partial class MainForm : Form
    {
        ParserWorker<ItemModel[]> parser;
        Timer timer = new Timer();

        string currRssFeed;
        int currTimerSettings;

        string title;


        public MainForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

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


            currRssFeed = parser.Settings.BaseUrl;
            currTimerSettings = Properties.Settings.Default.Timer;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                MainBox.Items.Clear();

                ChangeRssFeedSettings();

                parser.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Parser_OnDescription(object arg1, ItemModel[] arg2, string title)
        {
            ItemModel currItem = new ItemModel();
            foreach (var item in arg2)
            {
                if ($"{item.Title}. Дата публикации: {item.PubDate.ToString("F")}" == title)
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
            descriptionForm.LabelPubDate.Text = $"Дата публикации: {currItem.PubDate.ToString("F")}";
            descriptionForm.Show();
        }

        private void Parser_OnOpenLink(object arg1, ItemModel[] arg2, string title)
        {
            ItemModel currItem = new ItemModel();
            foreach (var item in arg2)
            {
                if ($"{item.Title}. Дата публикации: {item.PubDate.ToString("F")}" == title)
                {
                    currItem = item;
                    break;
                }
            }
            Process.Start(currItem.Link);
        }

        private void Parser_OnNewData(object arg1, ItemModel[] arg2)
        {
            foreach (var item in arg2)
            {
                try
                {
                    MainBox.Items.Add($"{item.Title}. Дата публикации: {item.PubDate.ToString("F")}");
                }
                catch
                {
                    MainBox.Items.Add("Something goes wrong");
                }
            }

        }

        private void Parser_OnComlpeted(object obj)
        {
            MessageBox.Show("All work has done!");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainBox.Items.Clear();

                ChangeRssFeedSettings();

                parser.Start();

                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        public void ChangeRssFeedSettings()
        {
            if (currRssFeed != Properties.Settings.Default.Url)
            {
                parser = new ParserWorker<ItemModel[]>(new RssFeedParser())
                {
                    Settings = new RssFeedParserSettings()
                };

                parser.OnCompleted += Parser_OnComlpeted;
                parser.OnNewData += Parser_OnNewData;
                parser.OnOpenLink += Parser_OnOpenLink;
                parser.OnDescription += Parser_OnDescription;
            }
            if (currTimerSettings != Properties.Settings.Default.Timer)
            {
                timer.Interval = Properties.Settings.Default.Timer;
                timer.Tick += new EventHandler(timer_Tick);
            }
        }
    }
}
