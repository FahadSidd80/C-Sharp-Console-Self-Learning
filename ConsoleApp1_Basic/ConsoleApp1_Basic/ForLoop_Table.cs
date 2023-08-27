using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Basic
{
    internal class ForLoop_Table
    {
        static void Main()
        {
            // Table using Concatenation

            int x = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " * " + i + " = " + x * i);
            }
            Console.WriteLine("\n\n\n");

            Console.Write("Please enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int j=1; j<=10; j++)
            {
                Console.WriteLine(num + " * " +j+ " = " + num * j);
            }

            // Table using Interpolation
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Table by interpolation \n");
            int n = 4;
            for(int k=1; k<=10; k++)
            {
                Console.WriteLine($"{n} * {k} = {n * k} ");
            }

            Console.WriteLine("\n\n\n");

            Console.WriteLine("Please enter number : ");
            int numb = Convert.ToInt32(Console.ReadLine());

            for(int z=1; z<=10; z++)
            {
                Console.WriteLine($"{numb} * {z} = {numb * z}");
            }

           

        }
    }
}
