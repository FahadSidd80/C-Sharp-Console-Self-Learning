using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_GFG_CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. identifiers : ConsoleApp_GFG_CSharp_Basics, Program, Main, a, b, c
            // keywords : using, internal, static, void, int


            //int a = 10;
            //int b = 20;
            //int c;
            //c = a + b;
            //Console.WriteLine("the sum of a and b is : " + c); // 30
            //                                                   // variable

            //Console.WriteLine("The sum of and b is : {0}", c); // 30

            //2. DataTypes :

            //1.Value Data Types
            //2.Reference Data Types
            //3.Pointer Data Type


            // declaring character
            //char a = 'G';
            ////char x = 'H';
            //// Integer data type is generally
            //// used for numeric values
            //int i = 89;
            ////int j = 90;

            //short s = 56;

            //// this will give error as number
            //// is larger than short range
            //// short s1 = 87878787878;

            //// long uses Integer values which 
            //// may signed or unsigned
            //long l = 4564;

            //// UInt data type is generally
            //// used for unsigned integer values
            //uint ui = 95;

            //ushort us = 76;
            //// this will give error as number is
            //// larger than short range

            //// ulong data type is generally
            //// used for unsigned integer values
            //ulong ul = 3624573;

            //// by default fraction value
            //// is double in C#
            //double d = 8.358674532;

            //// for float use 'f' as suffix
            //float f = 3.7330645f;

            //// for float use 'm' as suffix
            //decimal dec = 389.5m;

            //Console.WriteLine("char: " + a);
            //Console.WriteLine("integer: " + i);
            //Console.WriteLine("short: " + s);
            //Console.WriteLine("long: " + l);
            //Console.WriteLine("float: " + f);
            //Console.WriteLine("double: " + d);
            //Console.WriteLine("decimal: " + dec);
            //Console.WriteLine("Unsinged integer: " + ui);
            //Console.WriteLine("Unsinged short: " + us);
            //Console.WriteLine("Unsinged long: " + ul);


            //// valueType

            //sbyte a = 126;

            //// sbyte is 8 bit 
            //// singned value
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //// It overflows here because
            //// byte can hold values 
            //// from -128 to 127
            //a++;
            //Console.WriteLine(a);

            ////// Looping back within 
            ////// the range
            //a++;
            //Console.WriteLine(a);
            //sbyte a = 0;
            //for (int i=0;i<= 512 ;i++ )
            //{

            //    Console.WriteLine(a);
            //    a++;
            //}
            //byte a = 0;

            // byte is 8 bit 
            // unsigned value
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //a = 254;

            //// it overflows here because
            //// byte can hold values from
            //// 0 to 255
            //a++;
            //Console.WriteLine(a);

            //// Looping back within the range
            //a++;
            //Console.WriteLine(a);
            //int x = 10;
            //x++;
            //int y = x++;//10
            //Console.WriteLine(y);// 11
            //Console.WriteLine(x);// 12

            //Boolean ValueTypes
            //Boolean Types : It has to be assigned either true or false value.
            //    Values of type bool are not converted implicitly or 
            //    explicitly(with casts) to any other type. 
            //    But the programmer can easily write conversion code.

            //bool b = true;
            //if (b == true)
            //{
            //    Console.WriteLine("Hii Geek");// Hii Geek
            //}

            //2.Reference Data Types:

            //The Reference Data Types will contain a memory
            //address of variable value because the reference types won’t store 
            //the variable value directly in memory.The built-in reference types
            //are string, object.

            //String: It represents a sequence of Unicode characters and its type name is
            //        System.String.So, string and String are equivalent.
            //eg:-
            //string s = "Hello string keyword";// creating through string keyword  
            //String S = "Hii String Class";// creating through string Class
            //Console.WriteLine(s); // Hello string keyword
            //Console.WriteLine(S);// Hii String Class

            //Object: In C#, all types, predefined and user-defined, reference types and value types, 
            //    inherit directly or indirectly from Object. So basically it is the base class 
            //    for all the data types in C#. Before assigning values, it needs type conversion.
            //    
            //    When a variable of a value type is converted to object, it’s called boxing. 
            //    When a variable of type object is converted to a value type, it’s called unboxing.
            //    Its type name is System.Object.

            //string a = "Geeks";

            //a +=  "for";
            //a = a + "geeks";
            //Console.WriteLine(a);// Geeksforgeeks

            //object obj;
            //obj = 20;
            //Console.WriteLine(obj);// 20

            //// to show type of object
            //// using GetType()
            //Console.WriteLine(obj.GetType());// System.Int32

            //3.Pointer Data Type: 
            //    The Pointer Data Types will contain a memory address of the variable value.
            //    To get the pointer details we have a two symbols ampersand(&) and asterisk(*).
            //    ampersand(&): It is Known as Address Operator.It is used to determine the address of a variable.
            //    asterisk(*): It also known as Indirection Operator.It is used to access the value of an address.
            //Syntax:
            //         type* identifier;

            //Ex:-
            //int* p1, p; // valid synatx
            //int* p1, *p;// invalid syntax

            //pointers and fixed size buffers may only  be use in an unsafe context
            //unsafe
            //{
            //    int x = 10;
            //    int* p = &x;
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}





            Console.ReadLine();
        }
    }
}
