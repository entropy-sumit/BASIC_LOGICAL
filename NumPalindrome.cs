using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC
{
    class NumPalindrome
    {
        public void Num_Palindrome()
        {
            int n, r, sum = 0, temp;

            Console.Write("Enter the Number: ");

            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("palindrome number.");
            else
                Console.Write("not palindrome" );
        }
    }
}
