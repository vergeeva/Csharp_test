using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CTest
{
    class Program    //Тестовая программа
    {
        static void Main(string[] args)
        {
            //Вывести в консоль текст
            Console.WriteLine("Hello, world!"); //Hello, world!
            Console.WriteLine("------------------------------");

            //Переменные
            string line = "I'm line";
            Console.WriteLine(line); //I'm line

            int a = 5;
            int b = 10;
            Console.WriteLine(a + b); //15
            Console.WriteLine("------------------------------");

            char symbol = 'a'; //По приколу
            Console.WriteLine(format: "{0} = {1}", symbol, a); //a = 5

            Console.WriteLine("What's your name? "); //What's your name?
            //string a1 = Console.ReadLine(); //Просит пользователя ввести текст
            //Console.WriteLine(format: "Привет, {0}", a1); //Привет, Настя {Имя}
            Console.WriteLine("------------------------------");

            //Конвертация типов данных
            string a2 = Convert.ToString(a);//Конвертирует из int в string
            Console.WriteLine(a2);

            string str1 = "1,9";
            string str2 = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double result = Convert.ToDouble(str1);
            Console.WriteLine(format: "обычная дробь = {0}", result); //все ок, как обычно
            result = Convert.ToDouble(str2, numberFormatInfo); //предупреждаем, что мы используем нестандартный разделитель
            Console.WriteLine(format: "дробь, если запись с точкой = {0}", result); //выводит 1,9, как традиционную дробь
            Console.WriteLine("------------------------------");

            int value = int.Parse("6"); //работает только со строками
            Console.WriteLine(format: "строка преобразованная в int = {0}", value);

            //Ловим ошибки конвертации
            str1 = "123abc";
            try
            {
                value = int.Parse(str1);
                Console.WriteLine("Все прошло удачно");
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка при конвертации");
            }
            str1 = "123";
            //Если получается конвертировать, то это происходит, если не получается, то значение переменной остается
            //Возвращает true или false
            if (int.TryParse(str1, out a))
            {
                Console.WriteLine(format:"Все прошло удачно, a = {0}", a);
            }
            else
            {
                Console.WriteLine("Ошибка при конвертации");
            }
            Console.WriteLine("------------------------------");
            //Логический тернарный оператор
            string res = str1.Substring(0, 1) == str2.Substring(0, 1) ? "Первые символы равны" : "Первые символы не равны";
            Console.WriteLine(format: "str1 = {0}, str2 = {1}: {2}", str1, str2, res);
            res = str1 == str2 ? "Строки равны" : "Строки не равны";
            Console.WriteLine(format: "str1 = {0}, str2 = {1}: {2}", str1, str2, res);
            Console.ReadKey(false);
        }

    }
}
