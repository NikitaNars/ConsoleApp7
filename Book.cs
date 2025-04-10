﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Book : Media
    {
        public int CountPage { get; set; }
        public string Genre { get; set; }
        public Book(string Title, string Author, int YearPublished, bool IsAvailable, int CountPage, string Genre): base ( Title, Author, YearPublished, IsAvailable)
        {
            this.CountPage = CountPage;
            this.Genre = Genre;
        }
    }
}
