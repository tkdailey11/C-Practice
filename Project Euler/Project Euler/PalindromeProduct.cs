using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class PalindromeProduct
    {
        public void calculate()
        {
            int digits = getLimit();
            string UpperNum = "9";
            string LowerNum = "1";

            for(int i = 1; i < digits; i++)
            {
                UpperNum += "9";
                LowerNum += "0";
            }

            int limit = Int32.Parse(UpperNum);
            int low = Int32.Parse(LowerNum);
            int largest = -1;
            palProd product = new palProd();

            for(int j = low; j < limit; j++)
            {
                for(int k = low; k < limit; k++)
                {
                    int x = j * k;
                    if (isPalindrome(x) && x > largest)
                    {
                        largest = x;
                        product.palindrome = largest;
                        product.factor1 = j;
                        product.factor2 = k;
                    }
                }
            }

            string s2 = "The largest palindrome product of " + digits + " digit numbers is: " + product.factor1 + " * " + product.factor2 + " = " + product.palindrome;

            Console.WriteLine(s2);
            Console.WriteLine();
        }

        private bool isPalindrome(int n)
        {
            string s = n.ToString();
            string rev = "";
            for(int i = s.Count() - 1; i >= 0; i--)
            {
                rev += s[i];
            }

            return s.Equals(rev);
        }

        private int getLimit()
        {
            Console.WriteLine("Enter a number x for the largest palindrome product of x digit numbers problem (x = 3): ");
            Console.WriteLine();
            string s = Console.ReadLine();

            int limit = -1;

            while (!Int32.TryParse(s, out limit) || limit <= 0)
            {
                Console.WriteLine("Please enter an integer greater than 0...");
                s = Console.ReadLine();
            }

            return limit;
        }

        private class palProd
        {
            public int palindrome { get; set; }

            public int factor1 { get; set; }

            public int factor2 { get; set; }
        }
    }
}
