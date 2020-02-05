using RssFeeder.Core.XmlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;

namespace RssFeeder.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        XmlLoader xmlLoader;

        T items;

        bool isActive;

        #region Properties

        public IParser <T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                xmlLoader = new XmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        public T Items
        {
            get
            {
                return items;
            }
            set
            {
                Items = value;
            }
        }
        #endregion

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        public event Action<object, T, string> OnOpenLink;
        public event Action<object, T, string> OnDescription;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }
    
        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private void Worker()
        {
            if (!isActive)
            {
                OnCompleted?.Invoke(this);
                return;
            }


            items = Loader();

            OnNewData?.Invoke(this, items);

            OnCompleted?.Invoke(this);
        }

        public void FindLinkWithTitle(string title)
        { 
            OnOpenLink?.Invoke(this, items, title);
        }

        public void OpenDescription(string title)
        {
            OnDescription?.Invoke(this, items, title);
        }

        private T Loader()
        {
            var source = xmlLoader.Url;

            var document = new XmlDocument();

            document.Load(source);

            var list = parser.Parse(document);

            return list;
        }
    }
}
