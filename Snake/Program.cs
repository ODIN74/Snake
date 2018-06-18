using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');

            Point p2 = new Point(4, 5, '#');

            Console.WriteLine($"p1.x = {p1.X}, p1.y = {p1.Y}, p1.symbol = {p1.Symbol}");
            Console.WriteLine($"p2.x = {p2.X}, p2.y = {p2.Y}, p1.symbol = {p2.Symbol}");
            Console.ReadLine();

            p1 = p2;

            Console.WriteLine($"p1.x = {p1.X}, p1.y = {p1.Y}, p1.symbol = {p1.Symbol}");
            Console.WriteLine($"p2.x = {p2.X}, p2.y = {p2.Y}, p1.symbol = {p2.Symbol}");
            Console.ReadLine();

            p1.X = 10;
            p1.Y = 15;
            p1.Symbol = '^';

            Console.WriteLine($"p1.x = {p1.X}, p1.y = {p1.Y}, p1.symbol = {p1.Symbol}");
            Console.WriteLine($"p2.x = {p2.X}, p2.y = {p2.Y}, p1.symbol = {p2.Symbol}");

            Console.ReadLine();

            Reset(p1);

            Console.WriteLine($"p1.x = {p1.X}, p1.y = {p1.Y}, p1.symbol = {p1.Symbol}");
            Console.WriteLine($"p2.x = {p2.X}, p2.y = {p2.Y}, p1.symbol = {p2.Symbol}");


            Console.ReadLine();

        }

        static void Reset(Point p)
        {
            p = new Point();
            Console.WriteLine($"p.x = {p.X}, p.y = {p.Y}, p.symbol = {p.Symbol}");

            Console.ReadLine();
        }
    }
}
