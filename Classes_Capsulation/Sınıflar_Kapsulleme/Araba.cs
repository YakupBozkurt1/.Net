using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_Kapsulleme
{
    class Araba : ArabaDetay
    {
        public string renk;
        public double motor;
        public int hız;
        public char durum;
        public int fiyat;

        private int yil;
        private string Marka;

        public int Year
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKASI
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
