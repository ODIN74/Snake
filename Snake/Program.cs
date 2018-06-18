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
            
            HorizontalLine hLineTop = new HorizontalLine(1, Console.WindowWidth - 2, 0, '-');
            hLineTop.Draw();

            VerticalLine vLineLeft = new VerticalLine(0, 1, Console.WindowHeight - 2, '|');
            vLineLeft.Draw();

            HorizontalLine hLineBottom = new HorizontalLine(1, Console.WindowWidth - 2, Console.WindowHeight - 1, '-');
            hLineBottom.Draw();

            VerticalLine vLineRight = new VerticalLine(Console.WindowWidth - 1, 1, Console.WindowHeight - 2, '|');
            vLineRight.Draw();

            Console.ReadLine();
        }
    }
}
