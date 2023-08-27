using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Harry
{
    internal class Practice_Questns
    {
        public static void Main(string[] args)
        {


            //string[] cars =  {"BMW" , "ferrari","Mercedes", "RR"};

            //for (int i=0; i< cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}


            // By Indexing...
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);
            //Console.WriteLine(cars[3]);

            //string[] cars = new string[5] {"Jeep","ferrari","Nissan", "BMW", "Jaguar" };
            //Console.WriteLine(cars[3]);
            

            //foreach (String car in cars)
            //{
            //    Console.WriteLine(car);
            //}


            //LIST

            List<string> car = new List<string>();
            car.Add("BMW");
            car.Add("Ferrari");
            car.Add("Jaguar");
            car.Add("Jeep");
            car.Add("RR");
            for (int i=0; i< car.Count;i++)
            {
                Console.WriteLine(car[i]);
            }

            foreach (string lxt in car)
            {
                Console.WriteLine(lxt);
            }


            Console.ReadLine();
        }
    }
}
