//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Anton Klyushin">
// Copyright (c) Anton Klyushin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Snake
{
    using System;
    using System.Threading;

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
            
            var walls = new Walls(80, 25);
            walls.Draw();

            var p1 = new Point(4, 5, '*');
            var snake = new Snake(p1, 4, Direction.Right);
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25, '#');
            var food = foodCreator.CreateFood(snake);

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood(snake);
                }

                if (Console.KeyAvailable)
                {
                    snake.HandleKey(Console.ReadKey().Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
            
        }
    }
}
