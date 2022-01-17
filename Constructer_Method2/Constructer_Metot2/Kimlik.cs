using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_Metot2
{
    class Kimlik
    {
        string ad, soyad, memleket;
        int yas;
        char cinsiyet;

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            ad = "";
            soyad = "";
            cinsiyet = ' ';
            yas = 18;
            memleket = "Ankara";
        }

    }
}
