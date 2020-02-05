using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssFeeder.Core.RssFeed
{
    class RssFeedParserSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = Properties.Settings.Default.Url;
    }
}
