using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    internal class p2PerfectNumber
    {
        //method to check whether a number is a perfect number or not
        public void CheckPerfectNumber (int number)
        {
            //variable to store the sum of the divisors
            int SumOfDivisors = 0;

            //loop to find the divisors of a number
            for (int i = 1; i <= number/2; i++)
            {
                //when the number is divisible by i
                if(number % i == 0)
                {
                    //add the i to the SumOfDivisors variable
                    SumOfDivisors += i;
                }
            }
            //when the number is equal to the SumOfDivisors
            if (number == SumOfDivisors)
            {
                //display that the number is a perfect number.
                Console.WriteLine(number + " is a perfect Number.");
            }
                
        }
    }
}
