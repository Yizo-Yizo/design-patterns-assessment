﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GreatQuotes.Data
{
    class QuoteLoaderFactory
    {
        // This must be assigned to a method which creates a new quote loader.
        public static Func<IQuoteLoader> Create { get; set; }
    }
}
