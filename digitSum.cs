using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSummation
{
    public class summation
    {
        public void calcSum()
        {
            int userNum;
            int sumNum = 0;

            Console.Write("Enter the number:");
            userNum = Convert.ToInt32(Console.ReadLine());
            int temp = userNum;

            while(userNum > 0)
            {
                sumNum += userNum % 10;
                userNum /= 10;
            }

            Console.WriteLine("The summation of user input {0} is {1}", temp, sumNum);
        }
    }
}

//////////program.cs
using NumberSummation;
//summation sumValue = new();
//sumValue.calcSum();
