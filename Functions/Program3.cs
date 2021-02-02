using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program3
    {
        static int[,] Fill_in_the_Matrix(int[,] Matrix)
        {
            Random rand = new Random(); //Позволяет получать рандомные числа
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                   Matrix[i, j] = rand.Next(10, 100); //Рандомное заполнение матрицы

                }
            }
            return Matrix;
        }
        static void Look_Matrix(int[,] Matrix)
        {
            Console.WriteLine("Is Matrix:");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(format: "{0} ", Matrix[i, j]); //Рандомное заполнение матрицы
                }
                Console.WriteLine("");
            }
        }
        static void Look_Array(int[] array)
        {
            Console.WriteLine("Is Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(format: "{0} ", array[i]);
            }
        }
        static int[] Fill_in_the_Array(int[] array)
        {
            Random rand = new Random(); //Позволяет получать рандомные числа
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 100); //Рандомное заполнение матрицы
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[,] Matrix = new int[4, 6];
            Matrix = Fill_in_the_Matrix(Matrix);
            Look_Matrix(Matrix);

            Console.WriteLine("---------------------------------------------");

            int[] array = new int[8];
            array = Fill_in_the_Array(array);
            Look_Array(array);

            Console.ReadKey(false);
        }
    }
}
