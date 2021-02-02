using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обычные массивы
            int[] vs = new int[10]; //Объявление массива и распределение памяти на 10 элементов
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = i;
            }
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            vs = Enumerable.Repeat(5, 10).ToArray(); //Создает массив из 10 элементов, каждый из которых = 5
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------\nУбираем дубликаты:");

            vs = vs.Distinct().ToArray(); //Создает массив из 10 элементов, каждый из которых в порядке диапазона от 10 до 25
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");

            vs = Enumerable.Range(10, 10).ToArray(); //Создает массив из 10 элементов, каждый из которых в порядке диапазона от 10 до 25
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(format: "Максимальное четное число {0}; Минимальное нечетное число: {1}", vs.Where(i => i % 2 == 0).Max(), vs.Where(i => i % 2 != 0).Min());
            
            Console.WriteLine("---------------------------------------------");
            vs = vs.OrderByDescending(i => i).ToArray();
            Console.WriteLine("В порядке убывания:");
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------");
            //Класс Array имеет удобные функции
            Array.Sort(vs); //Сортирует массив
            Array.Reverse(vs); //Пишет в обратном порядке
            vs = Array.FindAll(vs, i => i <= 15); //второй параметр - это делегат
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");
            //Двумерные массивы
            float[,] Matrix = new float[4, 6]; //Инициализация матрицы
            Matrix.GetLength(0); //количество строк
            Matrix.GetLength(1); //количество столбцов

            Random rand = new Random(); //Позволяет получать рандомные числа

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(format: "{0} ", Matrix[i, j] = rand.Next(10, 100)); //Рандомное заполнение матрицы

                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey(false);
        }
    }
}
