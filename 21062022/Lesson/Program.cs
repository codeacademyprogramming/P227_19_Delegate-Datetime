using System;
using System.Threading;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("az-AZ");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
         

            DateTime date = new DateTime(2022,6,21,14,10,30,0);

            Console.WriteLine(date);
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToString("dddd dd-MM-yyyy"));
            

            //date = DateTime.Now;
            date = DateTime.UtcNow;
            date = date.AddDays(5);
            date = date.AddHours(4);
            date = date.AddYears(-10);



            DateTime birthDate1;
            string dateStr;

            do
            {
                Console.WriteLine("1. Dogum tarixini daxil edin:");
                dateStr = Console.ReadLine();

            } while (!DateTime.TryParse(dateStr,out birthDate1));

            DateTime birthDate2;

            do
            {
                Console.WriteLine("2. Dogum tarixini daxil edin:");
                dateStr = Console.ReadLine();

            } while (!DateTime.TryParse(dateStr, out birthDate2));


            var result = birthDate2 - birthDate1;
            Console.WriteLine(result.Days);
            if (birthDate1 > birthDate2)
            {
                Console.WriteLine("2-ci 1-ciden qocadir");
            }
            else if(birthDate2>birthDate1)
            {
                Console.WriteLine("1-ci 2-ciden qocadir");
            }





        }
    }
}
