using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt16(Console.ReadLine()); //Take a user input
            int i;
            for (i = 2; i <=userInput; i++) //for Prime number i value start from 2
            {
                if(userInput % i == 0)
                {
                    break;
                }
            }

            if(i == userInput)
            {
                Console.WriteLine("Number is Prime");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Number is not Prime");
                Console.ReadLine();
            }

        }
    }
}
