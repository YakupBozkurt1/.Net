using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisiler ks = new Kisiler();
            string ads, meslek;
            string yas;

            Console.WriteLine("İsim :");
            ads = Console.ReadLine();
            
            yas = Console.ReadLine();
           
            meslek = Console.ReadLine();
            

            ks.kisilistesi(ads, yas, meslek);
            Console.Read();

        }
    }
}
