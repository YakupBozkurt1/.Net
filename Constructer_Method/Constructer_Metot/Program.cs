using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            string inf;
            Console.Write("İsim - Hayal: ");
            inf = Console.ReadLine();
            Bilgi blg = new Bilgi(inf);

            Console.Read();

        }
    }
}
