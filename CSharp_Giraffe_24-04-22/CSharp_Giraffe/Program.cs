using System;

namespace CSharp_Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello bhai !! ");




            //---- vriables __//
            //------- Data Types ---//
            //-------Strings _-----//

            //String phrase = "Girrafe Academy";
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.IndexOf("Academy"));
            //Console.WriteLine(phrase.IndexOf('A'));
            //Console.WriteLine(phrase.Substring(8));
            //Console.WriteLine(phrase.Substring(8,3));


            //---- Numbers ---//


            //Console.WriteLine(-98.340);
            //Console.WriteLine(5 +9);
            //Console.WriteLine(10/2);
            //Console.WriteLine(10%5);
            //Console.WriteLine(10%5+9-0*4);
            //Console.WriteLine(4 +2 * 3);
            //Console.WriteLine((4 +2) * 3);
            //Console.WriteLine(3.0 + 4.9); // Adddition of two decimal = returm decimal
            //Console.WriteLine(3+8.1); // Addition of integer and decimal returns  == decimal/double
            //Console.WriteLine(5/2); // using two integer returns integer  i.e. 2
            //Console.WriteLine(5/2.0); // using integer and decimal returns == decimal/ double

            //Console.WriteLine(Math.Abs(-5.56));  // returns positive value
            //Console.WriteLine(Math.Pow(3,2));
            //Console.WriteLine(Math.Pow(3.3,2));  // returns i think double or more precise value
            //Console.WriteLine(Math.Pow(777777777, 666)); // returns infinite

            //Console.WriteLine(Math.Sqrt(36)); // returns square root
            //Console.WriteLine(Math.Sqrt(888888));
            //Console.WriteLine(Math.Max(45, 90));
            //Console.WriteLine(Math.Min(45, 90));
            //Console.WriteLine(Math.Round(4.4));
            //Console.WriteLine(Math.Round(4.6));
            //Console.WriteLine(Math.Round(4.9));
            //Console.WriteLine(Math.Round(4.0));
            //Console.WriteLine(Math.Round(4.10));
            //Console.WriteLine(Math.Round(0.10));
            //Console.WriteLine(Math.Round(0.1));

            //- Getting User Input --------//

            //Console.Write(" Enter your name :");
            //string name = Console.ReadLine();
            //Console.Write(" Enter your age :");
            //string age = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello " + name + " You are "+ age);

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + num);
            //Console.WriteLine(45 + 8);
            //Console.WriteLine(num +45);

            // basic calculator -//

            //Console.WriteLine("Enter a Number :");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter another Number :");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 +num2);

            // -- Madlib Game ---//

            //string color, pluralNoun, celebrity;
            //Console.WriteLine("Enter color name :");
            //color = Console.ReadLine();

            //Console.WriteLine("Enter plural noun :");
            //pluralNoun = Console.ReadLine();

            //Console.WriteLine("Enter celebrity :");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are" + color);
            //Console.WriteLine(pluralNoun +"are blue");
            //Console.WriteLine(celebrity +"are smart");


            //------- ARRAYS------------------------------------------------///------/////

            //int[] luckyNumbers = { 4, 6, 45, 12, 13, 15 };
            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine("Fahad");
            //}
            //Console.WriteLine(luckyNumbers[0]);
            //Console.WriteLine(luckyNumbers[2]);
            //Console.WriteLine(luckyNumbers[17]);
            //luckyNumbers[2] = 900;
            //Console.WriteLine(luckyNumbers[2]);


            //string[] friends = new string[5];
            //friends[0] = "Fahad";
            //friends[1] = "ali";
            //friends[2] = "farhan";
            //friends[3] = "faraz";
            //friends[4] = "kamran";
            ////friends[5] = "hamza";
            //Console.WriteLine(friends[4]);


            //-----------Methods-------------//


            //SayHi("fahad", 22);
            //SayHi("ali", 22);
            //SayHi("hamza", 22);

            //---------Return Statement ---//

            //Console.WriteLine(cube(5));
            //Console.WriteLine();


            //int number = cube(5);
            //Console.WriteLine(number);


            //bool isMale = false;

            //if (isMale)  // returns ony tru or false
            //{
            //    Console.WriteLine("You are male ");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male ");
            //}

            //----------IF Statements------------//

            //bool isMale = false;
            //bool isTall = false;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are tall male ");
            //}
            //else if(isMale && !isTall)
            //{
            //    Console.WriteLine("You are short male ");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are tall but not male");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male and not tall");
            //}

            //Console.WriteLine(GetMax(100,56,90));

            //--------CALCULATOR-----//\

            //    Console.Write("Enter a number : ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter a Operator : ");
            //    string op = Console.ReadLine();

            //    Console.Write("Enter a number : ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    if (op=="+")
            //    {
            //        Console.WriteLine(num1 + num2);
            //    }
            //    else if (op=="*")
            //    {
            //        Console.WriteLine(num1 * num2);
            //    }
            //    else if (op == "/")
            //    {
            //        Console.WriteLine(num1 / num2);
            //    }
            //    else if (op == "-")
            //    {
            //        Console.WriteLine(num1 - num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Operator !");
            //    }



            //Console.WriteLine(GetDay(5));


            //------------WHILE LOOPS----------//

            //int index = 0;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}


            //----------Do While Loops _------//

            //int index = 7;
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5);

            //---------Guess game --------//

            //string secretWord = "Girrafe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while (guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount<guessLimit)
            //    {
            //        Console.WriteLine("Enter guess :");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }


            //}
            //if (outOfGuesses)
            //{
            //    Console.WriteLine("You Loose !");
            //}
            //else
            //{
            //    Console.WriteLine("You Win !!");
            //}


            //string secretWord = "Fahad";
            //string guess = "";
            //int guesCount = 0;
            //int guessLimit = 5;
            //bool outOfGuess = false;

            //while (guess != secretWord && !outOfGuess )
            //{
            //    if (guesCount<guessLimit)
            //    {
            //        Console.Write("Enter guess word :");
            //        guess = Console.ReadLine();
            //        guesCount++;
            //    }
            //    else
            //    {
            //        outOfGuess = true;
            //    }
            //    if (outOfGuess)
            //    {
            //        Console.WriteLine("You Loose !!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You win !!");
            //    }

            //}


            //----------for Loops ------------//

            //int []arr  = {10,20,30,40,50,60 };

            //for (int i=0; i<arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //-------- Building a exponent method ------//




            //Console.WriteLine(Getpow(2,3));

            //----------- 2D ARRAY--------------//

            //int[,] gridNumber = {
            //{1,2 },
            //{3,4 },
            //{5,6 },
            //{7,8 } };

            //Console.Write(gridNumber[0,0]);
            //Console.WriteLine(gridNumber[0,1]);
            //Console.Write(gridNumber[1,0]);
            //Console.WriteLine(gridNumber[1,1]);
            //Console.Write(gridNumber[2,0]);
            //Console.WriteLine(gridNumber[2,1]);
            //Console.Write(gridNumber[3,0]);
            //Console.WriteLine(gridNumber[3,1]);

            //int[,] knownElementArr = new int[7,7];
            //knownElementArr[0,0] = 1;
            //knownElementArr[0,1] = 2;
            //knownElementArr[0,2] = 3;
            //knownElementArr[0,3] = 4;
            //knownElementArr[0,4] = 5;
            //knownElementArr[0,5] = 6;
            //knownElementArr[0,6] = 7;
            //knownElementArr[0,7] = 8;
            //knownElementArr[1,0] = 9;
            //knownElementArr[1,1] = 10;
            //knownElementArr[1,2] = 11;
            //knownElementArr[1,3] = 12;
            //knownElementArr[1,4] = 13;
            //knownElementArr[1,5] = 14;
            //knownElementArr[1,6] = 15;
            //knownElementArr[1,7] = 16;
            //knownElementArr[2,0] = 17;
            //knownElementArr[2,1] = 18;
            //knownElementArr[2,2] = 19;
            //knownElementArr[2,3] = 20;
            //knownElementArr[2,4] = 21;
            //knownElementArr[2,5] = 22;
            //knownElementArr[2,6] = 23;
            //knownElementArr[2,7] = 24;

            //for (int i=0; i<=knownElementArr.Length;i++)
            //{
            //    for(int j=0; j<=knownElementArr.Length; j++)
            //    {
            //        Console.WriteLine(knownElementArr[i,j]);
            //    }
            //}
            // EXCEPTION HANDLING --------//


            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter another number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine(result);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error");
            //}

            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter another number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine(result);
            //}
            //catch(Exception ex) //--- get  more information about error
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter another number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex) //--- get  more specific information about error
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException d)
            //{
            //    Console.WriteLine(d.Message);
            //}
            //finally  // - whaevr you write in finally block it will get excuted absolutely
            //{
            //    int x = 20;
            //    int y = 20;
            //    int sum = x + y;
            //    Console.WriteLine(sum);
            //}


            //------------- Classes and Objects -------//




            Console.ReadLine();
        }

        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello");
        //    Console.WriteLine("Hello "+ name +" You are " + age);
        //}

        //static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //static int GetMax(int num1 , int num2, int num3)
        //{
        //    int result;
        //    //if (num1 > num2 )
        //    //{
        //    //    result = num1;
        //    //}
        //    //else
        //    //{
        //    //    result = num2;
        //    //}

        //    // OR  for 3 numbers
        //    if (num1>= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //    else if (num2>=num1 && num2>=num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //

        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid DayNum";
        //            break;


        //    }
        //    return dayName;
        //}

        //static int Getpow(int baseNum, int powNum)
        //{
        //    int result = 1;
        //    for (int i=0; i<powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }

        //    return result;
        //}




    }  
}
