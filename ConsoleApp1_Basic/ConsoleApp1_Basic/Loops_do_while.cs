using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Basic
{
    internal class Loops_do_while
    {
        static void Main()
        {
            // While Loop
            //int n = 1;
            //while(n<=10)
            //{
            //    Console.WriteLine("Number : " + n);
            //    n++;
            //}

            // Do while loop
            int x = 0;
            do
            {
                Console.WriteLine("Number :" + x);
                x++;
            }
            while (x <= 10);
            {
                Console.WriteLine("Number" + x);

            }


        }
    }
}
