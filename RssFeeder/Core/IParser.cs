using System.Xml;

namespace RssFeeder.Core
{
    interface IParser<T> where T : class
    {
        T Parse(XmlDocument xmlDocument);
    }
}
