using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = i+1;j < arr.GetLength(1); j++)
                {
                    (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
