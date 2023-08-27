using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("fahad");

            

            string firstName = "john" ;
            string role = "Software developer";
            //int x = 10;
            //int y = 30;
            //int sum = x + y;
            //int sub = x - y;
            //int mul = x * y;
            //int div = x / y;

            //Console.WriteLine("Sum is : " + sum );
            //Console.WriteLine("Add is : " + sum);
            //Console.WriteLine("Subtraction is : " + sub);
            //Console.WriteLine("Multiply is : " + mul);
            //Console.WriteLine("Divide is : " + div);

            //string concatination(+)

            //Console.WriteLine("Your name is : " + firstName + ".");
            Console.WriteLine("Your name is : "+ firstName + "  \nand your role is : " + role + "." );
            Console.WriteLine("Your name is : "+ firstName + "\n" + "and your role is : " + role + "." );
            Console.WriteLine("Your name is : "+ firstName + "\t" + "and your role is : " + role + "." +"\n" +"this is next line");

            Console.WriteLine();
            Console.WriteLine();

            // string interpolation
            // 1. variable name in curly braces
            // 2. $ have to write before double quotation

            Console.WriteLine($"Your name is : {firstName}" + $" and your role is : {role}");
            Console.WriteLine($"Your name is : {firstName} and your role is : {role}");

            // string Placeholder/indexing

            Console.WriteLine("Your name is {0}. and you role is {1} ", firstName , role);



            Console.ReadLine();
;        }
    }
}
