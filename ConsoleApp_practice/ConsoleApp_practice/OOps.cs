using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_practice
{
    internal class OOps
    {
        static void Main(string[] xy)
        {
            A obj = new B();
            B obj1 = new B();
            obj1.display();
            obj.display();

        }

        
    }

    class A
    {
        public void display()
        {
            Console.WriteLine("Fahad");
        }
    }
    class B : A
    {
        public void  display()
        {
            Console.WriteLine("ALi");
        }
    }

}
