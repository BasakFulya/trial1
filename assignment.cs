using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 15, b;
            b = a++;  //we could use b=++a; instead of b=a++; coz they have the same meaning

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
