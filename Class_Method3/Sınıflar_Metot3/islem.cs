using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_Metot3
{
    class islem
    {
        public int topla( int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        public int cıkar( int s3, int s4)
        {
            int sonuc = s3 - s4;
            return sonuc;
        }

        public int carp ( int s1, int s2)
        {
            int sonuc = s1 * s2;
            return sonuc;
        }

        public int bol ( int s1, int s2)
        {
            int sonuc = s1 / s2;
            return sonuc;
        }
    }
}
