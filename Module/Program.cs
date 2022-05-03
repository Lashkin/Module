using System;
using System.Linq;

namespace Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter origin array size");
            a = Convert.ToInt32(Console.ReadLine());
            int[] originAr = new int[a];
            Random rand = new Random();

            for (int i = 0; i < originAr.Length; i++)
            {
                originAr[i] = rand.Next(1, 26);
            }

            int[] positive = originAr.Where(n => n % 2 == 0).ToArray();
            int[] negative = originAr.Where(n => n % 2 != 0).ToArray();
            object[] chaerPositive = new object[positive.Length];
            object[] chaerNegative = new object[negative.Length];
            Array.Copy(positive, chaerPositive, positive.Length);
            Array.Copy(negative, chaerNegative, negative.Length);

            for (int i = 0; i < chaerPositive.Length; i++)
            {
                chaerPositive[i] = Convert.ToChar(rand.Next('a', 'z'));
                chaerNegative[i] = Convert.ToChar(rand.Next('a', 'z'));
            }
            Console.WriteLine((string.Join(" ", chaerPositive)));
            Console.WriteLine((string.Join(" ", chaerNegative)));
        }
    }
}
