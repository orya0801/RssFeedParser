using System;

namespace RssFeeder.Core.RssModels
{
    //Представление тега item и его подтегов в виде класса
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
