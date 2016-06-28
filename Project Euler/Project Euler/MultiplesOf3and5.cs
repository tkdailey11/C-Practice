using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class MultiplesOf3and5
    {
        public MultiplesOf3and5()
        {
           
        }

        public void calculate()
        {
            int limit = getLimit();

            int threes = 3;
            int fives = 5;

            int sum = 0;

            while (threes < limit)
            {
                sum += threes;
                threes += 3;
            }

            while (fives < limit)
            {
                if (fives % 3 != 0)
                {
                    sum += fives;
                }

                fives += 5;
            }

            string s2 = "The sum is: " + sum;

            Console.WriteLine(s2);
            Console.WriteLine();
        }

        private int getLimit()
        {
            Console.WriteLine("Enter a limit for Multiples of 3 and 5 Sum problem (1,000): ");
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
