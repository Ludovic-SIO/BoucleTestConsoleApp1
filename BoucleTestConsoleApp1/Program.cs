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

            int i=1;
            int n = 5;
            int factorielle= 1;

            while (factorielle != n)
             {       
                    
                    factorielle += 1;
                    i=i*factorielle;
              }
            Console.WriteLine(i);
            Console.ReadKey();


            



        }
    }
}
