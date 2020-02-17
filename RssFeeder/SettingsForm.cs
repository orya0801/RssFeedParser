using System;
using System.Windows.Forms;
using System.Xml;

namespace RssFeeder
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            TextBoxRssFeed.Text = Properties.Settings.Default.Url;

            TextBoxUpdateFreq.Text = (Properties.Settings.Default.Timer / (60 * 1000)).ToString();
        }

        private void ButtonUpdateRssFeed_Click(object sender, EventArgs e)
        {
            string newFeed = TextBoxRssFeed.Text;
            //Проверка на совпадение с предыдущим url-адресом
            if (Properties.Settings.Default.Url == newFeed)
            {
                return;
            }
            try
            {
                //Проверка существования указанного url-адреса
                //В случае ошибки подключения в функции xml.Load(doc) идет обработка исключения
                XmlDocument xml = new XmlDocument();
                xml.Load(newFeed);

                Properties.Settings.Default.Url = newFeed;
                Properties.Settings.Default.Save();
                MessageBox.Show("URL was changed successfully.The program will restart");
            }
            catch
            {
                TextBoxRssFeed.Text = Properties.Settings.Default.Url;
                MessageBox.Show($"Rss Feed {newFeed} wasn't found. Check the link!");
                return;
            }

        }

        private void ButtonUpdateFreq_Click(object sender, EventArgs e)
        {
            try
            {
                int newFreq = int.Parse(TextBoxUpdateFreq.Text);
                //Проверка на ввод нового значения частоты обновления приложения
                if (Properties.Settings.Default.Timer == newFreq * 60 * 1000)
                {
                    return;
                }
                //Проверка на ввод положительного числа
                if (newFreq > 0)
                {
                    newFreq *= 1000 * 60;
                    Properties.Settings.Default.Timer = newFreq;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Update frequency was changed successfully. Press Start button to activate changes or wait for automatic program update");
                }
                else
                {
                    TextBoxUpdateFreq.Text = (Properties.Settings.Default.Timer / (60000)).ToString();
                    MessageBox.Show("This field can only take integer positive values.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error! Enter an integer number of minutes");
                return;
            }
        }
    }
}
