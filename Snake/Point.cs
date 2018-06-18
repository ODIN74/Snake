using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char symbol;

        public Point()
        {
        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point p)
        {
            this.X = p.X;
            this.Y = p.Y;
            this.Symbol = p.Symbol;
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public void Move(int offset, Direction direction)
        {
            switch(Convert.ToInt32(direction))
            {
                case 0:
                    x = x - offset;
                    break;
                case 1:                   
                        x = x + offset;
                        break;
                case 2:
                    y = y - offset;
                    break;
                case 3:
                    y = y + offset;
                    break;      
            }
        }

        public void Drow()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.symbol);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }

    }
}
