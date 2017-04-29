using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mode_process
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithmetic operands
            int a = 5, b = 4, c = 19, d = 8;
            Console.WriteLine("mode of a according to b: {0} n mode of c according to d: {1}",a%b, c%d);
            Console.ReadLine();
        }
    }
}