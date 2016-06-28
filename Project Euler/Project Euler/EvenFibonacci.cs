using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project_Euler
{
    class EvenFibonacci
    {
        public EvenFibonacci()
        {

        }

        public void calculate()
        {
            int limit = getLimit();

            int prev1 = 1;
            int prev2 = 2;
            int curr = 3;

            int sum = 2;

            while (curr < limit)
            {
                prev1 = prev2;
                prev2 = curr;
                curr = prev1 + prev2;

                if (curr % 2 == 0)
                {
                    sum += curr;
                }
            }

            string s2 = "The sum is: " + sum;

            Console.WriteLine(s2);
            Console.WriteLine();
        }

        private int getLimit()
        {
            Console.WriteLine("Enter a limit for Even Fibonacci Sum Problem (4 million): ");
            Console.WriteLine();
            string s = Console.ReadLine();

            int limit = -1;

            while (!Int32.TryParse(s, out limit) || limit <= 2)
            {
                Console.WriteLine("Please enter an integer greater than 3...");
                s = Console.ReadLine();
            }

            return limit;
        }
    }
}
