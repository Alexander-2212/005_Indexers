using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Indexers_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
             * Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.*/

            Random random = new Random();

            int n = random.Next(5, 20);

            int[] array = new int[n];

            int max = 0, min = 21;
            double middle = 0, sum = 0; ;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");

                if (array[i] > max)
                    max = array[i];

                if (array[i] < min)
                    min = array[i];

                sum += array[i];
            }

            middle = sum / n;

            Console.WriteLine($"\nНаибольшее значение массива = {max},\nНаименьшее значение массива = {min},\nОбщая сумма элементов = {sum},\nСреднее арифметическое элементов = {middle}");

            Console.WriteLine("\nВсе нечетные значения:");

            for (int i = 0; i < n; i++)
            {
                if(array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.ReadKey();


        }
    }
}
