using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Harry
{
    internal class harry
    {
        public static void Main(String[] args)
        {



            //      int x = 10;
            //      float b = 34.4f;
            //      double d = 45.4d;
            //      char c = 'a';
            //      string s = "Fahad is Lerner here ";
            //      bool isvalid = true;

            //      Console.WriteLine(x);
            //      Console.WriteLine(b);
            //      Console.WriteLine(d);
            //      Console.WriteLine(c);
            //      Console.WriteLine(s);
            //      Console.WriteLine(isvalid);


            //      string input = Console.ReadLine();
            //      Console.WriteLine(input);


            //      int n = Convert.ToInt32(Console.ReadLine());
            //      Console.WriteLine(n);


            //       Type casting
            //      There are two types of typecasting 
            //         1. Implicit

            //      char to int to long to float to double

            //      int y = 2;
            //      double z = y;
            //      int e = 'z'; 

            //      Console.WriteLine("Z = " + z);
            //      Console.WriteLine("y = " + y);
            //      Console.WriteLine(e);



            //         2. Explicit


            //      int x = (int) 32.2;

            //      double x1 = (double) 32.2;
            //      Console.WriteLine(x1);


            //      int x = 10;
            //      double y = x;
            //      float var = Convert.ToInt32(y);
            //      Console.WriteLine(var);
            //       User input

            //      Console.WriteLine("Enter your name ");
            //      string name = Console.ReadLine();
            //      Console.WriteLine("hey your name is : " + name);

            //      Console.WriteLine("How many candies you want !!");
            //      Console.WriteLine("Enter your candies !!");
            //      string cand = Console.ReadLine();
            //      Console.WriteLine("You will get extra 4 candies : " + (Convert.ToInt64(cand) + 4));


            //       Operators 

            /*         1. Arithmetic operators 
             *         2. Assingment operators
             *         3. Logical operators
             *         4. Comparision operators
             *       
            //       * */

            //      int a = 10;
            //      int c = 40;
            //      Console.WriteLine("the sum of " +a+ " & " +c+ " is " + (a + c) );
            //      Console.WriteLine("the sub of " +a+ " & " +c+ " is " + (a - c) );
            //      Console.WriteLine("the mul of " +a+ " & " +c+ " is " + (a * c) );
            //      Console.WriteLine("the div of " +a+ " & " +c+ " is " + (a / c) );
            //      Console.WriteLine("the rem of " +a+ " & " +c+ " is " + (a % c) );


            //       Assignment Operators
            //      int a = 4;
            //      int b = a;
            //      b += 4;
            //      int x = b;
            //       x -= 5;
            //      int Z = x;
            //       Z *= x;
            //      int q = Z;
            //      q /= x;

            //      Console.WriteLine(b);
            //      Console.WriteLine(x);
            //      Console.WriteLine(Z);
            //      Console.WriteLine(q);


            //       Logical Operators 

            //       1. Logical AND
            //       
            //      Console.WriteLine(true && true);
            //      Console.WriteLine(true && false);
            //      Console.WriteLine(false && true);
            //      Console.WriteLine(false && false);

            //       Logical OR 

            //      Console.WriteLine(true||true);
            //      Console.WriteLine(false||true);
            //      Console.WriteLine(true||false);
            //      Console.WriteLine(false||false);

            //      Logical NOT

            //      Console.WriteLine(!false);
            //      Console.WriteLine(!true);


            //       4. Comparision operators  returns only true or false

            //      Console.WriteLine(22 > 44);
            //      Console.WriteLine(22 < 44);
            //      Console.WriteLine(22 >= 44);
            //      Console.WriteLine(22 <= 44);
            //      Console.WriteLine(22 != 44);
            //      Console.WriteLine(22 == 44);


            //      int a = Math.Max(43, 876);
            //      Console.WriteLine(a);

            //      int b = Math.Min(87, 9);
            //      Console.WriteLine(b);


            //      double a = Math.Sqrt(144);
            //      Console.WriteLine(a);

            //      int b = Math.Abs(+86);
            //      Console.WriteLine(b);

            //      String hello = "Hello fahad how are you";
            //      //Console.WriteLine(hello);
            //      //Console.WriteLine(hello.Length);
            //      //Console.WriteLine(hello.ToUpper());
            //      //Console.WriteLine(hello.ToLower());
            //      //Console.WriteLine("hello kaise ho !! " + hello);kr
            //      //Console.WriteLine(String.Concat("Hello bhai " , hello));
            //      Console.WriteLine(String.Concat(hello, " Hello brother !!"));

            //       String Interpolation

            //      string name = Console.ReadLine();
            //      string candies = Console.ReadLine();
            //      Console.WriteLine($"Your name is {name}. You will get {candies} candies.");
            //      // OR

            //      Console.Write("please enter your status");
            //      String name = Console.ReadLine();
            //      Console.Write("Please eneter candies you want!");
            //      int candies = Convert.ToInt32(Console.ReadLine());
            //      Console.WriteLine($"You will get {candies} candies. Because you are {name} of the match");

            //      string hello = "this is fahad lappy !!";
            //      //Console.WriteLine(hello[0]);
            //      //Console.WriteLine(hello[2]);
            //      //Console.WriteLine(hello[3]);

            //      //Console.WriteLine(hello.IndexOf("is"));  // takes from first occurence

            //      //Console.WriteLine(hello.IndexOf("lappy"));

            //      Console.WriteLine(hello.Substring(14)); // Including 14

            //       Escape sequence characters in String

            //      Console.WriteLine("this is you name \" and your city is kanpur");
            //      Console.WriteLine("this is you name \n and your city is kanpur"); // for new line
            //      Console.WriteLine("this is you name \t and your city is kanpur"); // for tab insertion



            //      Decision Control in C#

            //      int age = 89;
            //      if(age >18)
            //      {
            //          Console.WriteLine("You can drive !");
            //      }
            //      else
            //      {
            //          Console.WriteLine("You cannot drive !!");
            //      }

            //      Console.WriteLine("Please enter you age !");
            //      int age = Convert.ToInt32(Console.ReadLine());
            //      if (age < 2)
            //      {
            //          Console.WriteLine("You are just born !");
            //      }
            //      else if (age <10)
            //      {
            //          Console.WriteLine("Please complete your high school !!");
            //      }
            //      else if (age <18)
            //      {
            //          Console.WriteLine("You are below 18 !!");
            //      }
            //      else if (age <60)
            //      {
            //          Console.WriteLine("You can drive !!");
            //      }
            //      else
            //      {
            //          Console.WriteLine("You are old people , So dont drive please !!");
            //      }
            //      int x;
            //      int y;
            //      x = 10;
            //      y = 20;
            //      Console.WriteLine("Sum of {0} and {1} is {2}",x,y,x+y);
            //      int id;
            //      string name;
            //      Console.WriteLine("ENter id");
            //      id=Convert.ToInt32(Console.Read());
            //      Console.WriteLine("Enter name");
            //      name = Console.ReadLine();

            //  Switch Case

            //      int age = 20;

            //      switch (age)
            //      {
            //          case 18:
            //              Console.WriteLine("You are eleigible for vote !!");
            //              break;
            //          case 60:
            //              Console.WriteLine("You are senior !!");
            //              break;
            //          case 90:
            //              Console.WriteLine("You are too old !!");
            //              break;
            //          default:
            //              Console.WriteLine("Enjoy!! ");
            //              break;
            //      }


            //       Loops in C#
            //       WHILE LOOPS

            //      int i = 0;
            //      while (i < 5)
            //      {
            //          Console.WriteLine(i);
            //          i++;
            //      }

            //       DO WHILE LOOPS

            //      int i = 0;
            //      do
            //      {
            //          Console.WriteLine(i);
            //          i++;
            //      }
            //      while (i>5);


            //      FOR LOOP

            //      for (int i=0;i<5; i++)
            //      {

            //          Console.WriteLine(i);
            //          if (i==3)
            //          {
            //              break;
            //          }

            //      }

            ///      <summary>
            ///      Break and Continue : In for loop
            ///      Break means loop ko exist karna at particular condition pe OR levae the loop forever
            ///      Continue means particular point ko left karke baaki execute karna OR leave this particular iteration of the loopuh$
            ///      </summary>
            ///      

            //      for (int i=0; i<5;i++)
            //      {
            //          if(i==0)
            //          {
            //              continue;
            //          }

            //          Console.WriteLine(i);

            //      }


            Console.WriteLine("fahad");



            Console.ReadLine();
        }
    }
}



