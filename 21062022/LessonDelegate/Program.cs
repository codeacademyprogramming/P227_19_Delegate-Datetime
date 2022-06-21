using System;
using System.Collections.Generic;

namespace LessonDelegate
{
    internal class Program
    {
        public delegate bool CheckNum(int num);
        public delegate int CalcType(int num1, int num2);
        static void Main(string[] args)
        {

            int[] nums = { 3, 4, 5, 6, 7, 10 };
            //Console.WriteLine(SumOfEven(nums));
            //Console.WriteLine(SumOfOdd(nums));
            //Console.WriteLine(SumOfdividedBy5(nums));

            Console.WriteLine(Sum(nums,IsEven));
            Console.WriteLine(Sum(nums, delegate (int x) { return x % 7 == 0; }));
            Console.WriteLine(Sum(nums, x=>x%3==0));
            Console.WriteLine(Sum(nums, x => x <0));


            CheckNum method = IsEven;
            method = x => x % 3 == 0;
            method = delegate (int x) { return x % 7 == 0; };

            CalcType calcMethod = (x, y) => x + y;
            Console.WriteLine(calcMethod(10,20));
            calcMethod = (x, y) => x * y;
            Console.WriteLine(calcMethod(10,20));

            Func<int, int, int> funcMethod = Sum;
            Func<int, bool> funcCheckMethod = IsEven;

            Action<int, int> action = (x,y)=>Console.WriteLine($"{x+y}");

            Predicate<int> predicate = delegate(int n) { return n % 10 == 0; };

            CalcType mtd = Sum;
            mtd = Pow;


            List<int> numberList = new List<int>
            {
                1,34,0,10,-34,-10
            };

            var value = numberList.FindAll(x => x < 0);

            foreach (var item in value)
            {
                Console.WriteLine(item);
            }

            List<Human> humans = new List<Human>
            {
                new Human{Name = "Abbas",Age=40},
                new Human{Name = "Nergiz",Age=20},
                new Human{Name = "Tofiq",Age=35},
                new Human{Name = "Elnar",Age=14},
                new Human{Name = "Elnare",Age=20}
            };

            var wantedHumans = humans.FindAll(x => x.Age == 20);

            Console.WriteLine("Humans");
            foreach (var item in wantedHumans)
            {
                Console.WriteLine(item.Name);
            }


        }

        static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        static int Pow(int num,int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result*= num;
            }
            return result;
        }


        static int Sum(int[] numbers,Func<int,bool> method)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (method(numbers[i]))
                    sum += numbers[i];
            }
            return sum;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }

        static int SumOfEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum += numbers[i];
            }
            return sum;
        }
        static int SumOfOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                    sum += numbers[i];
            }
            return sum;
        }

        static int SumOfdividedBy5(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0)
                    sum += numbers[i];
            }
            return sum;
        }



    }
}
