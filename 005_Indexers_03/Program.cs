using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Indexers_03
{
    class Article
    {
        //private string name;
        //private string shop;
        private double cost;

        public string Name { get; private set; }

        public string Shop { get; set; }

        public double Cost
        {
            get { return cost; }
            set
            {
                if (value >= 0)
                {
                    cost = value;
                }
                else Console.WriteLine("Стоимость не может быть отрицательной");
            }
        }

        public Article(string name)
        {
            Name = name;
        }

        public Article(string name, string shop, double cost)
        {
            Name = name;
            Shop = shop;
            Cost = cost;
        }

        public string Info()
        {
            return string.Format($"{Name} из {Shop} стоимость = {cost} грн.");
        }

    }
    class Store
    {
        /*• вывод информации о товаре по номеру с помощью индекса;
         *• вывод на экран информации о товаре, название которого введено с клавиатуры, 
         * если таких товаров нет, выдать соответствующее сообщение;*/

        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[Math.Abs(size)];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index].Info();
                return "Попытка обращения за пределы массива";
            }

        }



        public void AddArticle(Article value, int index)
        {
            if (index >= 0 && index < articles.Length)
                articles[index] = value;
            else Console.WriteLine("Попытка обращения за пределы массива");

        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                    if (articles[i].Name == index)
                        return articles[i].Info();

                return string.Format($"{index} нет в наличии");
            }
        }

        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
                Console.WriteLine(articles[i].Info());
        }

        public void Sort()
        {
            for (int i = 0; i <= articles.Length - 1; i++)
                for (int q = 0; q <= articles.Length - 1; q++)
                {
                    if(articles[i].Cost <= articles[q].Cost)
                    {
                        Article g = articles[i];
                        articles[i] = articles[q];
                        articles[q] = g;
                    }
                }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, вывода на экран информацию о товаре. 
            Store st = new Store(3);

            st.AddArticle(new Article("Book", "MackMilan", 20.50), 0);
            st.AddArticle(new Article("Apple", "Delight", 5.90), 1);
            st.AddArticle(new Article("Coca-Cola", "Fozzy", 7.25), 2);

            Console.WriteLine(st["Apple"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st["Dog"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st[2]);
            Console.WriteLine(new string('-', 30));

            st.Show();
            Console.WriteLine(new string('-', 30));

            st.Sort();
            st.Show();

            Console.ReadKey();
        }
    }
}
