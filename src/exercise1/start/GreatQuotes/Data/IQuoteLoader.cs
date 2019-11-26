using GreatQuotes.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreatQuotes.Data
{
    class IQuoteLoader
    {

        IEnumerable<GreatQuoteViewModel> Load();
        void Save(IEnumerable<GreatQuoteViewModel> quotes);
    }
}
