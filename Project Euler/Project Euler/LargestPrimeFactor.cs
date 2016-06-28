using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class LargestPrimeFactor
    {
        public void calculate()
        {
            List<long> factors = new List<long>();
            long limit = getLimit();
            long sqrtLimit = (long) Math.Sqrt(limit);
            long largest = -1;
            long num = 3;

            while(num <= sqrtLimit)
            {
                if(isFactor(num, limit))
                {
                    factors.Add(num);
                    factors.Add(limit / num);
                }

                num++;
            }

            factors.Sort();

            bool prime = false;

            int i = factors.Count() - 1;
            while (!prime)
            {

                if (isPrime(factors[i]))
                {
                    largest = factors[i];
                    prime = true;
                }

                i--;
            }

            string s2 = "The largest prime factor of " + limit + " is: " + largest;

            Console.WriteLine(s2);
            Console.WriteLine();
        }

        /// <summary>
        /// Return true if num is a factor of
        /// </summary>
        /// <param name="num"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        private bool isFactor(long num, long limit)
        {
            return (limit%num == 0);
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

        /// <summary>
        /// Given a prime number, finds the next prime number larger than the given number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private long nextPrime(long n)
        {
            bool numFound = false;

            while (!numFound)
            {
                n++;
                if (isPrime(n))
                {
                    numFound = true;
                }
            }

            return n;
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
