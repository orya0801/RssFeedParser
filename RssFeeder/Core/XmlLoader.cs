using System.Net.Http;

namespace RssFeeder.Core
{
    class XmlLoader
    {
        readonly string url;

        public XmlLoader(IParserSettings settings)
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
