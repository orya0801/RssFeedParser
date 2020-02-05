using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssFeeder.Core.XmlModels
{
    public class ItemModel
    {
        public string Title { get; set; } 
        public string Link { get; set; } 
        public string Description { get; set; } 
        public DateTime PubDate { get; set; }

        public ItemModel() { }

        public ItemModel(string title, string link, string description, DateTime pubDate)
        {
            Title = title;
            Link = link;
            Description = description;
            PubDate = pubDate;
        }
    }
}
