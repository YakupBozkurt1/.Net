using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_Metot3
{
    class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();

            Console.WriteLine(isl.bol(20, 5));
            Console.WriteLine(isl.carp(10, 5));
            Console.WriteLine(isl.cıkar(30, 10));
            Console.WriteLine(isl.topla(10, 4));

            Console.Read();
        }
    }
}
