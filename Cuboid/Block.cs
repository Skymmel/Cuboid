using System;

namespace Cuboid{
    internal class Block {
        private double A { get; }
        private double B { get; }
        private double C { get; }
    
        public Block(double a, double b, double c) {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        private double Volume() {
            return this.A * this.B * this.C;
        }

        private double Surface() {
            return 2 * (this.A * this.B + this.B * this.C + this.A * this.C);
        }

        private double Diagonal() {
            return Math.Sqrt(this.A * this.A + this.B * this.B + this.C * this.C);
        }

        private double WallDiagonal() {
            return Math.Sqrt(this.A * this.A + this.B * this.B);
        }

        public void PrintResult(){
            WriteColored("Objem", this.Volume());
            WriteColored("Obsah", this.Surface());
            WriteColored("Tělesová úhlopříčka", this.Diagonal());
            WriteColored("Stěnová úhlopříčka", this.WallDiagonal(), true);
        }

        private static void WriteColored(string name, double value, bool isLast = false){
            Console.Write($"{name}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(value);
            Console.ResetColor();
            if(!isLast){
                Console.Write(" | ");
            }
        }
    }
}