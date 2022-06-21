using System;
using System.Collections.Generic;

namespace CollectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();

            string countStr;    
            int count;

            do
            {
                Console.WriteLine("Mehsul sayini daxil edin:");
                countStr = Console.ReadLine();

            } while (!int.TryParse(countStr,out count));


            for (int i = 0; i < count; i++)
            {
                string name;
                do
                {
                    Console.WriteLine($"{i+1}. Mehsulun adini daxil edin:");
                    name = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(name) || products.ContainsKey(name));

                string priceStr;
                double price;

                do
                {
                    Console.WriteLine($"{i+1}. Mehsulun qiymetini daxil edin:");
                    priceStr = Console.ReadLine();

                } while (!double.TryParse(priceStr,out price) || price<0);

                products.Add(name, price);
            }

            Console.WriteLine("\n===================Mehsullar=====================\n");
            foreach (var item in products)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }

            string option;
            do
            {
                Console.WriteLine("Bir mehsul secin:");
                option = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(option) || !products.ContainsKey(option));

            Console.WriteLine($"Siz {option} mehsulunu secdiniz, qiymeti {products[option]} AZN");


        }
    }
}
