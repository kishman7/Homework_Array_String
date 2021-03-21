using System;
using System.Linq;
//2.Визначити методи для роботи з одновимірним масивом
//	- отримує 2 одновимірні масиви та повертає масив, що містить елементи обох масивів
//(для копіювання елементів можна скористатися методом CopyTo, arr.CopyTo(arr2, position))
//	-отримує 2 одновимірні масиви та повертає масив з спільними елементами(без повторів)
//	-отримує 2 одновимірні масиви та повертає масив, що містить елементи першого масиву,
//що НЕ зустрічаються у другому 
//
//Для розв'язування задач можна скористатися методами класу Array: 
//      Array.IndexOf(arr, elem) -знаходження індекса шуканого елемента
//      Array.Resize(ref arr, newSize) -зміна розміру масиву

namespace Array_static
{
    class Array_static
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //підключення українських букв
            bool action = true;
            while (action)
            {
                Console.WriteLine("Визначити методи для роботи з одновимірним масивом.");
                Console.WriteLine("1.Отримує 2 одновимірні масиви та повертає масив, що містить елементи обох масивів\n(для копіювання елементів можна скористатися методом CopyTo, arr.CopyTo(arr2, position))");
                Console.WriteLine("2.Отримує 2 одновимірні масиви та повертає масив з спільними елементами(без повторів)");
                Console.WriteLine("3.Отримує 2 одновимірні масиви та повертає масив, що містить елементи першого масиву, що НЕ зустрічаються у другому ");
                Console.WriteLine("0.Exit.");
                Console.Write("Виберіть потрібний пункт меню: ");
                int enter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                switch (enter)
                {
                    case 1:
                        {
                            //	- отримує 2 одновимірні масиви та повертає масив, що містить елементи обох масивів
                            //(для копіювання елементів можна скористатися методом CopyTo, arr.CopyTo(arr2, position))

                            int[] mas1 = { 2, 7, 0, -4, 1 };
                            int[] mas2 = { 12, 77, -10, -42, 111 };
                            Console.WriteLine("Element mas1: ");
                            foreach (int el in mas1)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Element mas2: ");
                            foreach (int el in mas2)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            int[] mas3 = new int[mas1.Length + mas2.Length]; // оголошуємо 3 масив
                            mas1.CopyTo(mas3, 0); // копіюємо елементи 1 масиву в 3 масив
                            mas2.CopyTo(mas3, mas1.Length); // копіюємо елементи 2 масиву в 3 масив
                            Console.WriteLine("Element mas3: ");
                            foreach (int el in mas3)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            //	-отримує 2 одновимірні масиви та повертає масив з спільними елементами(без повторів)

                            int[] mas_1 = { 2, 7, 2, 0, 1, -4, 1 };
                            int[] mas_2 = { 12, -10, 77, -10, 111, -42, 111 };
                            Console.WriteLine("Element mas1: ");
                            foreach (int el in mas_1)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Element mas2: ");
                            foreach (int el in mas_2)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            int[] mas_3 = new int[mas_1.Length + mas_2.Length]; // оголошуємо 3 масив
                            mas_1.CopyTo(mas_3, 0); // копіюємо елементи 1 масиву в 3 масив
                            mas_2.CopyTo(mas_3, mas_1.Length); // копіюємо елементи 2 масиву в 3 масив
                            Console.WriteLine("Element mas3: ");
                            foreach (int el in mas_3)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            int[] result = mas_3.Distinct().ToArray(); // видаляємо повторні елементи, а унікальні числа записуємо в новий масив
                            Console.WriteLine("Element mas3 no duplicate elements: ");
                            foreach (int el in result)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            //	-отримує 2 одновимірні масиви та повертає масив, що містить елементи першого масиву,
                            //що НЕ зустрічаються у другому 
                            int[] mas_1 = { 2, 7, 2, 0, 24, -42, 1, -4, 1 };
                            int[] mas_2 = { 12, 7, -4, 1, -10, 77, -10, 111, -42, 111 };
                            Console.WriteLine("Element mas1: ");
                            foreach (int el in mas_1)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Element mas2: ");
                            foreach (int el in mas_2)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();

                            int[] mas_3 = new int[0];
                            foreach (var item in mas_1)
                            {
                                if (Array.IndexOf(mas_2, item) == -1)
                                {
                                    Array.Resize(ref mas_3, mas_3.Length + 1);
                                    mas_3[mas_3.Length - 1] = item;
                                }
                            }
                            Console.WriteLine("Element mas3: ");
                            foreach (int el in mas_3)
                            {
                                Console.Write($"{el}\t");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case 0:
                        {
                            action = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Не вірно обраний пункт меню !!!");
                        Console.WriteLine();
                        break;
                }
            }
            

            
        }
    }
}
