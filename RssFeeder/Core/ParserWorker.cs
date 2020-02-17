using System;
using System.Xml;

namespace RssFeeder.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        RssLoader xmlLoader;

        T items;

        bool isActive;

        #region Properties

        public IParser<T> Parser
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
                xmlLoader = new RssLoader(value);
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

        //Событие возвращающее спаршенные данные
        public event Action<object, T> OnNewData;
        //Информирование при завершении работы парсера
        public event Action<object> OnCompleted;
        //Событие открывающее браузер с переходом на выбранную статью 
        public event Action<object, T, string> OnOpenLink;
        //Событие открывающее описание статьи
        public event Action<object, T, string> OnDescription;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }
        
        //Запуск парсера rss-ленты
        public void Start()
        {
            isActive = true;
            Worker();
        }

        //Остановка парсера
        public void Abort()
        {
            isActive = false;
        }

        //Контроль процесса парсинга
        private void Worker()
        {
            if (!isActive)
            {
                OnCompleted?.Invoke(this);
                return;
            }

            //Присвоение списку объектов ItemModel новых значений, полученных из rss-ленты
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

        //Загрузка rss-ленты и ее парсинг
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
