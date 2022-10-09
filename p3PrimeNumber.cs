using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    internal class p3PrimeNumber 
    {
        //method to check whether the number is a prime number or not
        public void CheckPrimeNumber(int number)
        {
            //when the number is 2
            if (number == 2)
            {
                //display that the number is a prime number
                Console.WriteLine(number + " is the prime number.");
            }
            else
            {
                bool prime = false;

                //loop to check whether the number is a prime number or not
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                    }
                }
                if (prime)
                {
                    //display that the number is a prime number
                    Console.WriteLine(number + " is a prime number.");
                }
                else
                {
                    //display that the number is not a prime number
                    Console.WriteLine(number + " is not a prime number.");
                }
            }
            
            
        }

    }
}
