using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (IsPrimeNumber(inputNumber) == true)//check the IsPrimeNumber() method with userInput
               {
                  Console.WriteLine("Number is Prime");
               }
            else
               {
                   int rev = 0;
                   int reminder;
                   int num = inputNumber;
                   while (inputNumber > 0)
                   {

                       reminder = inputNumber % 10; ////Getting the remainder by dividing with 10
                       rev = rev * 10 + reminder; /*multiplying the sum with 10 and adding with  remainder*/
                       inputNumber = inputNumber / 10;//Getting quotient by dividing with 10


                   }
                   if (num == rev)
                   {
                       Console.WriteLine("\n The Number is a Palindrome: {0} \n", rev);
                   }
                   else
                   {
                       Console.WriteLine("\n The Number is not Palindrome: \n");
                   }
                   Console.ReadLine();
               }
       

            Console.ReadLine();
        }

        static bool  IsPrimeNumber(int num)
        {
          
            bool bPrime = true;
            int i;

            for (i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    bPrime = false;
                }
            }
            Console.WriteLine("\n Number is not Prime \n");
            return bPrime;
        }

        
    }
}
