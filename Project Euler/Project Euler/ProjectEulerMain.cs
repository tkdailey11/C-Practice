using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class ProjectEulerMain
    {
        static void Main(string[] args)
        {
            string problem = "-1";
            while(problem != "0")
            {
                Console.WriteLine("Enter a problem number (refer to the problems on projecteuler.net), or enter 0 to close: ");
                problem = Console.ReadLine();

                if (problem.Equals("0"))
                {
                    
                }
                else if (problem.Equals("1"))
                {
                    MultiplesOf3and5 mult = new MultiplesOf3and5();
                    mult.calculate();
                }
                else if (problem.Equals("2"))
                {
                    EvenFibonacci fib = new EvenFibonacci();
                    fib.calculate();
                }
                else if (problem.Equals("3"))
                {
                    LargestPrimeFactor prime = new LargestPrimeFactor();
                    prime.calculate();
                }
                else if (problem.Equals("4"))
                {
                    PalindromeProduct prod = new PalindromeProduct();
                    prod.calculate();
                }
            }

        }
    }
}
