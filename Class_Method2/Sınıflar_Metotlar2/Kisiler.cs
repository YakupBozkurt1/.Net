using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_Metotlar2
{
    class Kisiler
    {
        public void kisilistesi(string ad, string year,string job)
        {
            for(int i= 0; i<=10; i++)
            {
                Console.WriteLine(i+1 + ") " + ad + " " + year + " " + job);
            }
        }
    }
}
