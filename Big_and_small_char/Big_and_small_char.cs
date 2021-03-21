using System;

//1.Створити програму, яка вводить з клавіатури символи(посимвольно- Console.Read())
// та перетворює малі букви у великі та навпаки.

namespace Big_and_small_char
{
    class Big_and_small_char
    {
        static void Main(string[] args)
        {
            bool action = true;
            while(action)
            {
                Console.WriteLine("1.Convert big char to small.");
                Console.WriteLine("2.Convert small char to big.");
                Console.WriteLine("0.Exit.");
                Console.Write("Select a menu item: ");
                int enter = Convert.ToInt32(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter big char: ");
                            string ch = Console.ReadLine();
                            string ch1 = ch.ToLower(); // перетворення великих символів на малі
                            Console.WriteLine($"Big char \'{ch}\' = small char \'{ch1}\'.");
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter small char: ");
                            string ch = Console.ReadLine();
                            string ch1 = ch.ToUpper(); // перетворення малих символів на великі
                            Console.WriteLine($"Small char \'{ch}\' = big char \'{ch1}\'.");
                            Console.WriteLine();
                            break;
                        }
                    case 0:
                        {
                            action = false;
                            break;
                        }
                    default:
                        Console.WriteLine("The menu item entered is incorrect !!!");
                        Console.WriteLine();
                        break;
                }
            }
            
        }
    }
}
