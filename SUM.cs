using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b,result,result1; 
        
            string write1, write2;

            Console.Write("enter first number: " );
            write1 = Console.ReadLine();
            Console.Write("enter second number: ");
            write2 = Console.ReadLine();

            a = Convert.ToInt32(write1);
            b = Convert.ToInt32(write2);

            result = a + b;
            Console.Write("sum of two numbers: " +result.ToString());
            Console.ReadKey();
            result1 = a * b;
            Console.Write("multiplication of two numbers:" + result1.ToString());
            Console.ReadKey();
        }
    }
}