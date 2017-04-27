using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace from_user
{
    class Program
    {
        static void Main(string[] args)
        {

            //We'll take name,surname from user than show it on the screen.
            string a;

            Console.Write("enter ur name n surname: ");
            a = Console.ReadLine();

            Console.WriteLine(" Hello\t" +a+ "\tWelcome");
            Console.ReadKey();


            //+a+ mission is connect Hello n Welcome n entered name n surname
            //and we could define string a everywhere just it should be declared before the using a in consolewriteline
            //string a=Console.Readline();  it could be like this
        }
    }
}