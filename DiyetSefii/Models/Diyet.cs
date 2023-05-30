using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiyetSefii.Models
{
    public class Diyet
    {
        public int yaş { get; set; }
        public int ağırlık { get; set; }
        public int cinsiyet { get; set; }
        public int aktivite { get; set; }
        public int sekerHastasi { get; set; }
        public int kalpHastasi { get; set; }
        public int suiçimi { get; set; }
        public int tansiyonHastasi { get; set; }
        public int egzersizalışkanlığı { get; set; }
        public int farkliKulturlerden { get; set; }
        public int hedef { get; set; }

    }
}