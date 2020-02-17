namespace RssFeeder.Core.RssFeed
{
    class RssFeedParserSettings : IParserSettings
    {
        //Установка значения url rss-ленты из настроек программы
        public string BaseUrl { get; set; } = Properties.Settings.Default.Url;
    }
}
