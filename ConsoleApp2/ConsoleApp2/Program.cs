using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{

    class Program
    {
        static void Main(string[] args)
        {
            Auto hundaif320 = new Auto("hundai", "f320", "4", "передняя")
            {
                Price = 400000,
                HasWarranty = 1
            };
            hundaif320.PrintInfo();
            Auto hundaiz34m = new Auto("hundai", "z34modified", "3", "полный привод")
            {
                Price = 350000,
                HasWarranty = 0
            };
            hundaiz34m.PrintInfo();
            Console.ReadKey();
        }
    }
}