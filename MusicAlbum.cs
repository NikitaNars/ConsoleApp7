﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MusicAlbum
    {
        public string Executor { get; set; }
        public int CountTrack { get; set; }
        MusicAlbum(string Executor, int CountTrack) 
        {
            this.Executor = Executor;
            this.CountTrack = CountTrack;
        }
    }
}
