using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Basic
{
    internal class switch_Case
    {
        static void Main()
        {
            //Database
            int existingPin = 1234;
            int existingAmount = 8000;
            //End Database

            Console.WriteLine("Welcome to Fahad");

            Console.WriteLine("Enter Your Pin");
            int userPin = Convert.ToInt32(Console.ReadLine());

            //Pin Check condition
            if (userPin == existingPin)
            {
                //Console.WriteLine("1. Mini Transaction \t 2. Pin Change \t3. Withdraw");               

                Console.WriteLine("Please select a number given below:");
                Console.WriteLine("1. Mini Statement 2. Pin Change 3. Withdraw");
                int userOption = Convert.ToInt32(Console.ReadLine());

                // Switch 
                switch (userOption)
                {
                    case 1:
                        Console.WriteLine("Mini Statement");
                        break;
                    case 2:
                        Console.WriteLine("Pin Change");
                        break;
                    case 3:
                        Console.WriteLine("How much you want to withdraw:");
                        int userAMount = Convert.ToInt32(Console.ReadLine());

                        // Check the condition for amount 
                        //Nested If (If under if)

                        if (userAMount > existingAmount)
                        {
                            Console.Write("You have enter more than existing amount");
                        }
                        else
                        {
                            int remainingAmount = existingAmount - userAMount;
                            Console.WriteLine("Thanks for using. Your remaing amount is:"
                                + remainingAmount);
                        }
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                        
                }
            }
            Console.Read();
        }
    }
}
