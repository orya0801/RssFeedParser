using RssFeeder.Core.XmlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RssFeeder.Core.RssFeed
{
    class RssFeedParser : IParser<ItemModel[]>
    {
        public List<ItemModel> items;

        public ItemModel[] Parse(XmlDocument xmlDocument)
        {
            ItemModel item;
            items = new List<ItemModel>();

            XmlElement xmlRoot = xmlDocument.DocumentElement;

            foreach (XmlNode xmlNode in xmlRoot)
            {
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name == "item")
                    {
                        item = new ItemModel();
                        foreach (XmlNode secondChildNode in childNode.ChildNodes)
                        {
                            if (secondChildNode.Name == "title")
                                item.Title = secondChildNode.InnerText;
                            if (secondChildNode.Name == "guid")
                                item.Link = secondChildNode.InnerText;
                            if (secondChildNode.Name == "description")
                                item.Description = secondChildNode.InnerText;
                            if (secondChildNode.Name == "pubDate")
                                item.PubDate = DateTime.Parse(secondChildNode.InnerText);
                        }
                        items.Add(item);
                    }
                }
            }

            return items.ToArray();
        }
    }
}
