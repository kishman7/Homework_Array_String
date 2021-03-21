using System;

//Перерозташувати елементи у масиві( відємні, невідємні) у порядку їх  слідування. 
//Для масиву : 1  2 - 4 - 55 - 7 10 100
//Повинні отримати змінений масив: -4 - 55 - 7  1 2 10 100
//Використати FindAll(), CopyTo().
namespace Array_negative_non_negativ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, -8, 0, 2, -4, 73, -55, -7, 10, 0, 100, -21 };
            Console.WriteLine("Element mas: ");
            foreach (var el in mas)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();
            int[] res1 = Array.FindAll(mas, i => i < 0);
            Console.WriteLine();
            Console.WriteLine("Element mas negative: ");
            foreach (var el in res1)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();
            int[] res2 = Array.FindAll(mas, i => i >= 0);
            Console.WriteLine();
            Console.WriteLine("Element mas non-negative: ");
            foreach (var el in res2)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();
            int[] res3 = new int[res1.Length + res2.Length];
            res1.CopyTo(res3, 0);
            res2.CopyTo(res3, res1.Length);
            Console.WriteLine();
            Console.WriteLine("Element mas negative & non-negative: ");
            foreach (var el in res3)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();
        }
    }
}
