using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Indexers
{
    class Dictionary
    {
        private string[] keyRus = new string[5];
        private string[] value = new string[5];
        private string[] keyUkr = new string[5];

        public Dictionary()
        {
            keyRus[0] = "книга"; value[0] = "book"; keyUkr[0] = "підручник";
            keyRus[1] = "ручка"; value[1] = "pen"; keyUkr[1] = "українська ручка";
            keyRus[2] = "солнце"; value[2] = "sun"; keyUkr[2] = "сонце";
            keyRus[3] = "яблоко"; value[3] = "apple"; keyUkr[3] = "українське яблоко";
            keyRus[4] = "стол"; value[4] = "table"; keyUkr[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < keyRus.Length; i++)
                    if (keyRus[i] == index)
                        return keyRus[i] + " - " + value[i];
                    else if (keyUkr[i] == index)
                        return keyUkr[i] + " - " + value[i];
                    else if (value[i] == index)
                        return value[i] + " - " + keyRus[i] + " - " + keyUkr[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < keyRus.Length)
                    return keyRus[index] + " - " + value[index] + " - " + keyUkr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["підручник"]);
            Console.WriteLine(dictionary["сонце"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
