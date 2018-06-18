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

            p1.Draw();

            Point p2 = new Point(4, 5, '#');

            p2.Draw();

            Point p3 = new Point(10, 3, '$');

            Point p4 = new Point(4, 13, '%');

            List<char> charList = new List<char>() { '@', '#', '!', '&', '$', '^' };

            List<Point> pointList = new List<Point>() { p1, p2, p3, p4 };

            foreach (char i in charList )
            {
                Console.WriteLine("\n{0}", i);
            }

            foreach (Point i in pointList)
            {
                Console.WriteLine($@"{i.X}
{i.Y}
{i.Symbol}" + "\n");
            }

            Console.ReadLine();
        }
    }
}
