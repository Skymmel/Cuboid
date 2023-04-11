using System;

namespace Cuboid{
    internal static class Program {
        public static void Main(string[] args){
            
            // P R O G R A M  B Y  S K Y M M E L
            // website: https://skymmel.eu
            // github: https://github.com/Skymmel
            // repository: https://github.com/Skymmel/Cuboid

            Console.Title = "Určení parametrů | © Wilhelm Skyba";
            Block block = new Block(GetValue("A"), GetValue("B"), GetValue("C"));
            block.PrintResult();
            Console.Read();
        }
        private static double GetValue(string side){
            Console.Write($"Zadejte stranu {side}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            Console.ResetColor();
            return double.Parse( input ?? "0");
        }
    }
}