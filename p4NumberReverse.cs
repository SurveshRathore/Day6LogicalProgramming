using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    internal class p4NumberReverse
    {
        //method to generate the reverse of a number
        public void GenerateReverse(int number)
        {
            int revNum = 0;
            int num = number;

            //loop to generate the reverse of the number
            while (number > 0)
            {
                revNum *= 10;
                revNum += number % 10;
                number /= 10;               
            }

            Console.WriteLine("The reverse of the number {0} is {1}", num,revNum);
        }
    }
}
