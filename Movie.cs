﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Movie : Media
    {
        public double DurationMin { get; set; }
        public string Director { get; set; }
        public Movie(string Title, string Author, int YearPublished, bool IsAvailable, double DurationMin, string Director) : base(Title, Author, YearPublished, IsAvailable)
        {
            this.DurationMin = DurationMin;
            this.Director = Director;
        }
    }
}
