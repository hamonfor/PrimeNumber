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
            //greet the user
            Console.WriteLine("Hello."+Environment.NewLine + "Please enter a number greater than 1. The program will print" +
                " prime numbers up to that number.");
            int range = GetIntegerGreaterThanOne();
            Console.WriteLine("List of prime numbers: ");
            for (int currentNumberToCheck = 2; currentNumberToCheck < range; currentNumberToCheck++)
            {
                //start with currentNumberToCheck = 2, because 0 and 1 aren't prime numbers
                //reset the isPrime counter before each new number to check
                int isPrime = 0;

                for (int currentDivisor = 1; currentDivisor <= currentNumberToCheck; currentDivisor++)
                {
                    //start with currentDivisor = 1 because you can't divide by 0
                    if (currentNumberToCheck % currentDivisor == 0)
                    {
                        //raise the isPrime variable when the remainder from the division is equal to 0
                        isPrime++;
                    }
                }
                if (isPrime == 2)
                {
                    //the currentNumberToCheck is a prime number only when the isPrime variable equals to 2
                    //print the currentNumberToCheck if it is a prime number
                    Console.WriteLine(currentNumberToCheck);
                }
            }
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
        static int GetIntegerGreaterThanOne()
        // receive an integer greater than one from the user, additionally try to catch exceptions
        {
            start:
            int userInteger = 0;
            try
            {
                while (true)
                {
                    Console.WriteLine("Input a number");
                    userInteger = Convert.ToInt32(Console.ReadLine());
                    if (userInteger > 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number has to be greater than one.");
                    }

                }

            }
            catch
            {
                Console.WriteLine("Invalid input.");
                goto start;
            }
            return userInteger;
        }
    }

}

