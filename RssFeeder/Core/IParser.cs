using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RssFeeder.Core
{
    interface IParser<T> where T : class
    {
        T Parse(XmlDocument xmlDocument);    
    }
}
