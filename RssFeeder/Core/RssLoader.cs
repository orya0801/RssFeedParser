namespace RssFeeder.Core
{
    //Класс назначен для загрузки rss-документа из указанных настроек парсера
    class RssLoader
    {
        readonly string url;

        public RssLoader(IParserSettings settings)
        {
            url = $"{settings.BaseUrl}";
        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                Url = value;
            }
        }
    }
}
