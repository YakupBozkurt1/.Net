using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_Metot2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Yakup";
            kml.SOYAD = "Bozkurt";
            kml.MEMLEKET = "Gaziantep";
            kml.CINSIYET = 'E';
            kml.YAS = 20;
            Console.WriteLine(kml.AD + "\n" + kml.SOYAD + "\n" + kml.MEMLEKET + "\n" + kml.CINSIYET + "\n" + kml.YAS);

            Console.Read();
        }
    }
}
