using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Indexers_01_OOP
{
    class MyArray
    {
        int[] array;

        public MyArray(int n)
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 40);
                Console.Write(array[i] + " ");
            }

        }

        public void MinMax()
        {
            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"\nНаибольшее значение массива = {max}\nНаименьшее значение массива = {min}");
        }

        public double Sum()
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine($"Сумма всех элементов = {sum}");

            return sum;
        } 

        public void Average()
        {
            double average = 0;
            average = Sum() / array.Length;
            Console.WriteLine($"Среднее арифметическое = {average}");
        }

        public void Odd()
        {
            Console.WriteLine("\nВсе нечетные значения:");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            MyArray arr = new MyArray(rand.Next(10, 20));

            arr.MinMax();
            //arr.Sum();
            arr.Average();
            arr.Odd();

            Console.ReadKey();
        }
    }
}
