using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to the joy with a plaything");
            string s = "What should we do?";

            foreach(char letter in s) {Console.ForegroundColor = GetRandomConsoleColor(); Console.BackgroundColor = GetRandomConsoleColor(); Console.Write(letter);}
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            s = Console.ReadLine();
            Console.WriteLine("Haremos entonces " + s);
        }
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
    }
}
