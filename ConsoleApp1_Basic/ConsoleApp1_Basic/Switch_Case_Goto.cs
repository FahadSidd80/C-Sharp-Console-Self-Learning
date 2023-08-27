using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Basic
{
    class Switch_Case_Goto
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


                //Condition else -if

                // ====================
                // if (userOption == 1)
                //    {
                //        Console.WriteLine("Mini Statement");
                //    }
                //    else if (userOption == 2)
                //    {
                //        Console.WriteLine("Pin Change");
                //    }
                //    else if (userOption == 3)
                //    {
                //        Console.WriteLine("How much you want to withdraw:");
                //        int userAMount = Convert.ToInt32(Console.ReadLine());

                //        // Check the condition for amount 
                //        //Nested If (If under if)

                //        if (userAMount > existingAmount)
                //        {
                //            Console.Write("You have enter more than existing amount");
                //        }
                //        else
                //        {
                //            int remainingAmount = existingAmount - userAMount;
                //            Console.WriteLine("Thanks for using. Your remaing amount is:"
                //                + remainingAmount);
                //        }
                //    }
            }
            Console.Read();
        }
    }
}



/*  
If
==
1. Block of code
2. Execute only when condition will be true

    Syntax
    =======
if(true)
{	
        //Statements
}

Or 

if(condition_is_true)
{
       //Statements
}

    Example
    ========
int age = 18;

if(age >= 18)
{
   Console.Write(“Eligible for vote”);
}
==================================================
if-else
=======
1. When condition will true then it will execute if block
2. If condition will be false then execute else block

    Syntax
    ======
if(true)
{	
        //Statements
}
else
{
       //Statements
}

    Example
    =======
int age = 18;

if(age >= 18)
{
   Console.Write(“Eligible for vote”);
}
else{
   Console.Write(“Not eligible”);
}

==========================================
Nested-if
=========
1. if in another if
2. We can use multiple if under if

    Syntax
    ======
if(true)
{
    if(true)
    {
       //Statements
    }

    if(true)
    {
       //Statements
    }

    //Statements
}
=======================================
else if
========
1. Multiple if condition
2. Execute only one condition
3. If first condition will be true, It will not execute another condition

    Syntax
    ======
if(true){
   //Statements
}
else if(true){
   // Statements
}
else if(true){
   // Statements
}
else{
   // Statements
}

    Example
    =======
1. Multiple option in ATM machine
-----------------------------------

1. Withdraw 2. Mini Statement 3.Pin Change

2. Customer Care Call
----------------------
  Press 1 to know balance, Press  2. Check Balance 3.....

                Condition else -if
 
                 ====================
                int userOption = Convert.ToInt32(Console.ReadLine());
                 if (userOption == 1)
                    {
                        Console.WriteLine("Mini Statement");
                    }
                    else if (userOption == 2)
                    {
                        Console.WriteLine("Pin Change");
                    }
                    else if (userOption == 3)
                    {
                        Console.WriteLine("Withdraw");                        
                    }
                    else{
                        Console.WriteLine("Wrong option");
                    }
=========================================================

Switch 
======
1. To check multiple conditions
2. Can use instead of “if - else if – else”
3. To check condition, we write expression type under switch(expression_type)
4. Expression type can be any valid data type value/variable
5. Based on expression type we check the condition
6. To terminate the switch condition we use break keyword
7. default is there for place of esle like in “if- else if – else”

    Syntax
    ======
Expression => Valid data type
Value1 => data type value

switch (expression) 
{ 
		case value1: 
			// statement sequence 
			break; 
		case value2: 
			// statement sequence 
			break; 
		. . . case valueN: 
			// statement sequence
			break; 
		default: 
			// default statement sequence 
			break;
}

    Example 1
    =========
int num = (Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
          default:
                Console.WriteLine(“Failed”);
	break;	
        }

    Example 2
    =========
string language = Console.ReadLine();
        switch (language )
        {
            case “HTML”:
              Console.WriteLine(“HTML is scripting language”);
              break;
            case “CSharp”:
                Console.WriteLine(“C# is object oriented programming language.”);
                break;
            default:
                Console.WriteLine(“Failed”);
                break;	
        }
===========


    Points
    =======
1. Case must be unique
2. Only matching case will called
3. After completing the case we use break keyword
4. We can also go to another case using goto case caseValue
5. Can use for multiple operation 
6. break keyword is mandatory, after statement in a case.

*/
