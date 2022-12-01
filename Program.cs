// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10] { 3, 4, 2, 7, 1, -3, 3, 7, 8, 6 };
            int res = 0;
            bool multIsOn = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0 && multIsOn == false)
                {
                    multIsOn = true;
                    continue;
                }
                if (multIsOn && res == 0) res = numbers[i];
                else res *= numbers[i];
            }
            Console.WriteLine($"Исходный масссив: {string.Join(" ", numbers)}");
            Console.WriteLine($"Результат произведения: {res}.");
        }
    }
}


