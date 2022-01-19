using System;
using System.Collections.Generic;
using System.Text;

namespace BASIC
{
    class Reverse
    {
        public void RevMethod()
        {
            int n, reverse = 0, reminder;

            Console.Write("enter a number: ");

            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                reminder = n % 10;
                reverse = reverse * 10 + reminder;
                n /= 10;
            }
            Console.Write("reversed rumber: " + reverse);

            Console.ReadLine();

        }
    }
}
