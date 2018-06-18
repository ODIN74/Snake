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
            Console.SetBufferSize(80, 25);

            
            HorizontalLine hLineTop = new HorizontalLine(0, Console.WindowWidth - 2, 0, '*');
            hLineTop.Drow();

            VerticalLine vLineLeft = new VerticalLine(0, 1, Console.WindowHeight - 2, '*');
            vLineLeft.Drow();

            HorizontalLine hLineBottom = new HorizontalLine(0, Console.WindowWidth - 2, Console.WindowHeight - 1, '*');
            hLineBottom.Drow();

            VerticalLine vLineRight = new VerticalLine(Console.WindowWidth - 2, 1, Console.WindowHeight - 2, '*');
            vLineRight.Drow();

            Point p1 = new Point(1, 3, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Drow();

            Point p2 = new Point(4, 5, '#');
            p2.Drow();
        }
    }
}
