//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Anton Klyushin">
// Copyright (c) Anton Klyushin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Snake
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Main program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Arguments of main metod</param>
        private static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            var horizontalLineTop = new HorizontalLine(0, Console.WindowWidth - 2, 0, '*');
            horizontalLineTop.Draw();

            var verticalLineLeft = new VerticalLine(0, 1, Console.WindowHeight - 2, '*');
            verticalLineLeft.Draw();

            var horizontalLineBottom = new HorizontalLine(0, Console.WindowWidth - 2, Console.WindowHeight - 1, '*');
            horizontalLineBottom.Draw();

            var verticalLineRight = new VerticalLine(Console.WindowWidth - 2, 1, Console.WindowHeight - 2, '*');
            verticalLineRight.Draw();

            var p1 = new Point(1, 3, '*');
            var snake = new Snake(p1, 4, Direction.Right);
            snake.Draw();
            snake.Move();
        }
    }
}
