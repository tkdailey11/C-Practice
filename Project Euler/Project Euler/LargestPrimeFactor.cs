using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class LargestPrimeFactor
    {
        public LargestPrimeFactor()
        {

        }

        public void calculate()
        {
            long limit = getLimit();
            long largest = 3;
            long num = 3;

            while (num < limit)
            {
                if(limit % num == 0)
                {
                    if (isPrime(num))
                    {
                        largest = num;
                    }
                }

                num += 2;
            }

            string s2 = "The largest prime factor of " + limit + " is " + largest;

            Console.WriteLine(s2);
            Console.WriteLine();

        }

        private bool isPrime(long n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private long getLimit()
        {
            Console.WriteLine("Enter a limit for Largest Prime Factor problem (600,851,475,143): ");
            Console.WriteLine();
            string s = Console.ReadLine();

            long limit = -1;

            while (!Int64.TryParse(s, out limit) || limit <= 2)
            {
                Console.WriteLine("Please enter an integer greater than 3...");
                s = Console.ReadLine();
            }

            return limit;
        }
    }
}
