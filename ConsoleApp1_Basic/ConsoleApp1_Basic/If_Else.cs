using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Basic
{
    internal class If_Else
    {
        static void Main()
        {
            // Database

            int existingPin = 1234;
            int existingAmount = 2300;
            // EndDate

            Console.WriteLine("Welcome to fahad ");

            Console.Write("Enter your PIN :  ");
            int userPin = Convert.ToInt32(Console.ReadLine());

            // PIN check condition

            if (existingPin == userPin)
            {
                Console.WriteLine("Please Enter amount you wants to withdrw !! ");
                int userAMount = Convert.ToInt32(Console.ReadLine());
                // check the condition for amount
                // Nested IF _Else condition for maount

                if (userAMount <= existingAmount)
                {
                    int remainingAmount = existingAmount - userAMount;
                    Console.WriteLine("Thanks for Using BOB. Your remaining amount is : " + remainingAmount);
                }
                else
                {
                    Console.WriteLine("You have enter more than existing amount !!");
                }
            }
            else
            {
                Console.WriteLine("You have entered wrong PIN !!");
            }




            Console.Read();

        }
    }
}
