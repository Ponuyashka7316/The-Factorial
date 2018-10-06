using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int f = Int32.Parse(Console.ReadLine());
            while ((f /= n) > n)
                n++;

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
