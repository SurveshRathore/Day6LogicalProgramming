using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Program
{
    internal class p1FibonacciSeries
    {
        //method to generate the fibonacci series
        public void GenerateFibonacciSeries (int term)
        {
            //set the first term of the fibonacci series
            int FIRST_TERM = 0;
            //set the second term of the fibonacci series
            int SECOND_TERM = 1;
            //variable to store the next term of the fibonacci series
            int Next_Term;

            //when the fibonacci series has only 0 term
            if (term <= 0)
            {
                Console.WriteLine("Invalid Fibonacci Series. Series must be greater than 0.");
            }
            //when the fibonacci series has only 1 term
            else if (term == 1)
            {
                Console.WriteLine("The first term of the Fibonacci series is: " + FIRST_TERM);
            }

            //when the fibonacci series has 2 or more than 2 term
            else
            {
                //display the first 2 term of the fibonacci series
                Console.Write("The {0} term of Fibonacci Series are: {1}, {2}", term, FIRST_TERM, SECOND_TERM);
                //For loop to generate the fibonacci series
                for (int i = 3; i <= term; i++)
                {
                    //generate the next term of the fibonacci series
                    Next_Term = FIRST_TERM + SECOND_TERM;
                    //display the next term of the fibonacci series
                    Console.Write(", " + Next_Term);
                    //set the FIRST_TERM by the SECOND_TERM
                    FIRST_TERM = SECOND_TERM;
                    //set the SECOND_TERM by the Next_Term
                    SECOND_TERM = Next_Term;
                }
            }

            
        }
    }
}
