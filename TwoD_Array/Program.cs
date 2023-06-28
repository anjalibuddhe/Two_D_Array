using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoD_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[,] arr1 = new int[3, 3];
            int[,] add = new int[3, 3];
            for(int i=0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //Console.WriteLine($"Enter the value of arr[{i}{j}]");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                

                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "");
                }

                Console.WriteLine();
            }


            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                   // Console.WriteLine($"Enter the value of arr[{i}{j}]");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }


           
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + "");
                }

                Console.WriteLine();
            }

            for (int i = 0; i <add.GetLength(0); i++)
            {
                for (int j = 0; j <add.GetLength(1); j++)
                {
                    add[i, j] = arr[i, j] + arr1[i, j];

                    Console.Write(add[i,j]);
                }
                Console.WriteLine();
            }

           
                
            
        }
    }
}
