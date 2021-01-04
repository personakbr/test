using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace testC2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //примитивные типы данных
            
            byte bit = 1; // 0 / 255 
            sbyte bit1 = 1; // -128 / 127
            bool qw = true;

            short n = 1; // -32768 / 32767
            ushort n1 = 1; // 0 / 65535
            char ch = '#';

            int a = 10; // -2147483648 / 2147483647
            uint b = 10; // 0 / 4294967295
            float f = 3.3f;
            string str = "Hello";

            long c = -10; // –9223372036854775808 / 9223372036854775807
            ulong d = 10;
            double g = 3.34;
            object newProgramm = new object();

            decimal k = 4.56767687M;
            */


            //  b. Выполните 5 операций явного и 5 неявного приведения.
            // Явное
            int a = 10;
            int b = 16;
            Console.WriteLine((float)a / b);

            double c = 345.567;
            Console.WriteLine((int)c);

            float d = 45.6798f;
            Console.WriteLine((int)d);

            Console.WriteLine((float)c + d);

            Console.WriteLine((float)c * b);
            // не явное
            int num = 2147483647;
            long bigNum = num;

            double k = d;

            float h = a;

            int l = 5;
            decimal newl = l;

            newl = bigNum;

            // c.	Выполните упаковку и распаковку значимых типов.

            int box = 5;
            object boxing = box;

            int unbox = (int)boxing;

            //d.	Продемонстрируйте работу с неявно типизированной переменной.

            var str = 5;
            var str2 = "Hello";
            var str3 = new { Name = "Ivan", Age = 30 }; // анонимный тип

            //e.	Продемонстрируйте пример работы с Nullable переменной.

            int? newNall = null;

            //a.	Объявите строковые литералы. Сравните их.
            string st = "hello";
            string st2 = " world";
            string st3 = "!";
            Console.WriteLine(st == st2);

            //b.	Создайте три строки на основе String. 
            //Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию,
            //удаление заданной подстроки.

            //сцепление
            st3 = st + st2 + st3;
            Console.WriteLine(st3);
            // копирование
            string st4 = st;
            //выделение подсроки с символа
            Console.WriteLine(st3.Substring(6));
            //удаление заданной подстроки
            Console.WriteLine(st3.Remove(6));
            //вставки подстроки в заданную позицию
            Console.WriteLine(st3.Insert(0, "\t!!!\t"));
            //разделение строки на слова
            st3.Remove(0, 5);
            string[] arr = st3.Split();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //c.	Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            string empStr = "";
            string nullStr = null;
            Console.WriteLine(empStr.Length);
            Console.WriteLine("Нет данных" ?? nullStr);

            //d.	Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.

            StringBuilder sb1 = new StringBuilder("Hello world!");
            sb1.Remove(4, 1);
            Console.WriteLine(sb1);
            sb1.Insert(0, "!!!");
            Console.WriteLine(sb1);

            sb1.Append("!!!");
            Console.WriteLine(sb1);

            //a.	Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица). 

            int[,] newArr = new int[,]
            {
            { 3, 5, 6 },
            { 5,8,9},
            {6,12,8 }
            };
            Console.WriteLine();
            for (int i = 0; i < newArr.GetLength(0); i++)
            {
                for (int j = 0; j < newArr.GetLength(1); j++)
                {

                    Console.Write(newArr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //b.	Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
            //Поменяйте произвольный элемент (пользователь определяет позицию и значение).
            string[] strArr = { "Hello", "World", "!" };

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(strArr[i]+' ');
            }
            Console.WriteLine("\n"+strArr.Length);

            Console.WriteLine("Какой элемент из" + strArr.Length + "поменять?");
            int elem = int.Parse(Console.ReadLine());
            if (elem <= strArr.Length)
            {
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (i == elem - 1)
                    {
                        Console.Write("Введите слово для замены: ");
                        strArr[i] = Console.ReadLine();
                    }

                }
            }
            else
            {
                Console.WriteLine("error");
            }
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(strArr[i] + ' ');
            }

            //c.	Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, 
            //в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.

            int[][] zArr = new int[3][];

            for (int i = 0; i < zArr.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        zArr[i] = new int[2];
                        for (int j = 0; j < zArr[i].Length; j++)
                        {
                            Console.WriteLine("Введите число " + j  + " в массиве " + "№ " + i );
                            int elConsol = int.Parse(Console.ReadLine());
                            zArr[i][j] = elConsol;
                        }
                        break;
                    case 1:
                        zArr[i] = new int[3];
                        for (int j = 0; j < zArr[i].Length; j++)
                        {
                            Console.WriteLine("Введите число " + j + " в массиве " + "№ " + i);
                            int elConsol = int.Parse(Console.ReadLine());
                            zArr[i][j] = elConsol;
                        }
                        break;
                    case 2:
                        zArr[i] = new int[4];
                        for (int j = 0; j < zArr[i].Length; j++)
                        {
                            Console.WriteLine("Введите число " + j + " в массиве " + "№ " + i);
                            int elConsol = int.Parse(Console.ReadLine());
                            zArr[i][j] = elConsol;
                        }
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }  
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < zArr[i].Length; j++)
                {
                    Console.Write(zArr[i][j]+ "\t");
                }
                Console.WriteLine();
            }
            //d.	Создайте неявно типизированные переменные для хранения массива и строки.

            var nArr = new int[5] { 1,2,3,4,5};
            var nArr2 = "Hello hello";
            //a.Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 
            //b.	Сделайте именование его элементов.

            (int, string, char, string, ulong) korteg = (5, "Hi", '#', "Hello", 567890);
            var korteg2 = (count: 5, str1: "Hi", ch: '#', str2: "Hello", elem: 567890);
            //c.	Выведите кортеж на консоль целиком и выборочно (1, 3, 4  элементы)
            Console.WriteLine(korteg2);
            
            Console.WriteLine("выборочно (1, 3, 4  элементы):");
            Console.WriteLine(korteg2.count);
            Console.WriteLine(korteg2.ch);
            Console.WriteLine(korteg2.str2);

            //d.	Выполните распаковку кортежа в переменные.
            var (one, two, three, four, five) = (5, "Hi", '#', "Hello", 567890);

            //5)	Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых и строка. 
            //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива,
            //сумму элементов массива и первую букву строки.
            int[] tupleArr = { 2,45,67,89,12};
            string tupleStr = "Hello world!";
            var newTuple = (getSum(tupleArr, tupleStr));
            Console.WriteLine(newTuple);
        }
        public static (int, int, int, char) getSum (int[] arr, string str)
        {
            int maxValue = arr.Max();
            int minValue = arr.Min();
            int sumValue = arr.Sum();
            char firsteElementstr = str[0];
            return ( maxValue, minValue, sumValue, firsteElementstr);
        }
    }
}
