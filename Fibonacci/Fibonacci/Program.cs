using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt16(Console.ReadLine());
            int c;
            int a = 0; //Take always initial value as 0
            int b = 1; //Take the second value 1

            for (int i = 0; i <= userInput; i++)
            {
                c = a + b; // 0+1=1.....
                a = b; //when b=1 it will be value for a=1
                b = c; //when c= 0+1=1 or 1+1=2 it will be value for b=1 or 2

                Console.WriteLine( "\n" + a);
            }
            Console.ReadLine();
        }
    }
}
