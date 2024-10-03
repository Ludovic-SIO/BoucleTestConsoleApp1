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
            int n = 10;
            int somme= 0;

            while (i <= n)
             {       
                    somme += i;
                    i++;
                    
                }
            Console.WriteLine(somme);
            Console.ReadKey();


            



        }
    }
}
