using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Namu_Uzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            string spalva = "";
            while (spalva != " ")
            {
                Console.WriteLine("Iveskite savo megstamiausia spalva:");
                spalva = Console.ReadLine();
                Console.WriteLine("Mano megstamiausia spalva irgi {0} ", spalva);
            }
           
        }
    }
}
