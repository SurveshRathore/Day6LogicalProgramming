using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop;

namespace workshop
{
    public class monthlyPayment
    {
        //method to calculate the monthly payment
        public static void calcMonthlyPayment()
        {
            //get the principal loan amount from the user
            Console.Write("Enter the principal loan amount: ");
            double P = Convert.ToDouble(Console.ReadLine());
            //get the principal no of year from the user
            Console.Write("Enter the loan year:");
            int Y = Convert.ToInt32(Console.ReadLine());
            //get the interest rate from the user
            Console.Write("Enter the loan percent interest:");
            double R = Convert.ToDouble(Console.ReadLine());
            //calculate the loan rate
            double r = R / (12 * 100) ;
            //calculate the total month
            int n = 12 * Y;
            //calculate the monthly payment
            double payment = ( (P * r) / (1 - Math.Pow((1 + r),-n)) );
            //round the result to 2 decimal
            payment = Math.Round(payment, 2);
            //display the monthly payment
            Console.WriteLine("The monthly payment is {0}", payment);
        }
    }
}

//call the method
//monthlyPayment.calcMonthlyPayment();
