using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleTestConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int i;
            Console.WriteLine("Nombres pairs entre 1 et 10 :");
            for ( i = 0; i <= 10; i++)
           {
                if (i % 2 == 0)
                    Console.WriteLine(i);
           }
             Console.ReadKey();

            
        }
    }
}
