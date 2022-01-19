using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC
{
    class Fibonacci
    {
        public void FMethod()
        {
            int a = 0, b = 1, c, i, num;
            Console.Write("enter the number: ");

            num = int.Parse(Console.ReadLine());

            Console.Write(a + " " + b + " ");
            
            for (i = 2; i < num; i++)    
            {
                c = a + b;

                Console.Write(c + " ");

                a = b;
                b = c;
            }
        }
    }
}
