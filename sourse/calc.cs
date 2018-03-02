using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуйте! Это мой калькулятор, введите 1 число");
            Console.Write("Число: ");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Выберите действие, pl, mi, mu, de");
            Console.Write("Действие: ");
            string action1 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Введите 2-ое число и готово!");
            Console.Write("Число: ");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(Calculate(action1, a2, a1));
            Console.WriteLine(" ");
            Console.WriteLine("Нажмите что бы выйти!");
            Console.ReadKey();
        }
        public static float Calculate(string action1, float a2, float a1)
        {
            switch (action1){
                case "pl":
                    return a1 + a2;
                case "mi":
                    return a1 - a2;
                case "mu":
                    return a1 * a2;
                case "de":
                    return a1 / a2;
                default:
                    Console.Write("Error ");
                    break;  
            }
            return 101;
        }
    }
}
