using GreatQuotes.ViewModels;
using System;
using System.Collections.Generic;

namespace GreatQuotes.Data {
    public class GreatQuote {
        private string _author;
        private string _quoteText;

        public string Author {
            get => _author;
            set => _author = value; 
        }

        public string QuoteText {
            get => _quoteText;
            set => _quoteText = value;
        }

        public GreatQuote() : this("Unknown", "Quote goes here..") {
        }

        public GreatQuote(GreatQuote copy) {
            this.QuoteText = copy.QuoteText;
            this.Author = copy.Author;
        }

        public GreatQuote(string author, string quoteText) {
            Author = author;
            QuoteText = quoteText;
        }

        public class QuoteManager
        {
            static readonly Lazy<QuoteManager> instance = new Lazy<QuoteManager>(() => new QuoteManager());

            private IQuoteLoader loader;
            public static QuoteManager Instance { get => instance.Value; }

            public IList<GreatQuoteViewModel>Quotes { get; set; }
            
            private QuoteManager()
            {
                Loader = QuoteLoaderFactory.Creater();
                Quotes = New ObservableCollection<GreateQuoteVIewModel>(loader.Load());
            }

            public void Save()
            {
                loader.Save(Quotes);
            }
        }
    }
}