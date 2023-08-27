using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Lang_Syntax
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            //------Array -----//

            //int[] arr = new int[7];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //arr[5] = 6;
            //arr[6] = 7;

            //for (int i=0; i<arr.Length; i++ )
            //{
            //    Console.WriteLine("Fahad");
            //}

            //int[] arrN = new int[5] {2,3,4,5,6 };
            //Console.WriteLine(arrN[0]);





            //Console.ReadLine();

            //int[][][] x = { { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } } };
            //for (int i = 0; i < x.length; i++)
            //{
            //    for (int j = 0; j < x[i][j].length; j++)
            //    {
            //        for (int k = 0; k < x[i].length; k++)
            //        {
            //            Console.WriteLine(x[i][j][k]);
            //        }
            //    }
            //}


            //int[] arry = { 12, 13, 14 };
            //for (int i = 0; i < arry.Length; i++)
            //{
            //    Console.WriteLine(arry[i]);
            //}

            //int[,] a =  { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };

            //int[,] arr1 = { { 10, 20, 30, 40, 50 }, { 40, 50, 60, 70, 80 }, { 70, 80, 90, 10, 20 } };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(arr1[i, j] + " ");
            //    }


            //}

            int[ , , ] arr = new int[ , , ] { { { 10, 20, 30, 40, 50 }, { 40, 50, 60, 70, 80 } },
                                        
                                            { { 90, 100, 110, 120, 130 }, { 23,34,45 } } };

            for (int i=0; i<arr.Length; i++) 
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    for (int k=0; k < arr[i][j].Length; k++) {
                        Console.WriteLine(arr[i][j][k]);
                    }
                }
            }


        
        }
    }
}
