using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerOf2Pgm
{
    public class power2
    {
        public void calcPower()
        {
            Console.WriteLine("Enter the power: ");
            int power = Convert.ToInt32(Console.ReadLine());
            int powerof2 = 1;

            for (int i = 1; i <= power; i++)
            {
                powerof2 = powerof2 * 2;
            }

            Console.WriteLine("The power of 2 by {0} is: {1}", power, powerof2);
        }
        
    }
}


// See https://aka.ms/new-console-template for more information
//using powerOf2Pgm;

//power2 pow = new();
//pow.calcPower();

