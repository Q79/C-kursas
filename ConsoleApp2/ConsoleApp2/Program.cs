﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trecia_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "";
            while(vardas != "stop")
            {
                Console.WriteLine("Iveskite savo varda:");
                vardas = Console.ReadLine();
                Console.WriteLine("Sveiki {0} [Enter - testi]", vardas);
            }
            Console.Clear();
            Console.WriteLine("Ate...");
            Console.ReadLine();
        }
    }
}
