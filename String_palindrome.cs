using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC
{
    class String_palindrome
    {
        //public void StringMethod()
        //{
        //    string string1, rev;

        //    Console.Write("enter word:");
        //    string1 = Console.ReadLine();


        //    char[] ch = string1.ToCharArray();

        //    Array.Reverse(ch);
        //    rev = new string(ch);

        //    bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
        //    if (b == true)
        //    {
        //        Console.WriteLine("" + string1 + " is a Palindrome!");
        //    }
        //    else
        //    {
        //        Console.WriteLine(" " + string1 + " is not a Palindrome!");
        //    }
        //    Console.Read();
        public void SBmethod()
        {
            Console.WriteLine("Enter  string for Palindrome");
            string string1 = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = string1.Length - 1; i >= 0; i--)
            {
                sb.Append(string1[i]);
            }
            String rev = sb.ToString();

            if (string1.Equals(rev))
            {
                Console.WriteLine($"{string1} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{string1} is not Palindrome");
            }
        }

    }
    

}
