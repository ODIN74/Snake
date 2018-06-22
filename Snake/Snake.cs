//-----------------------------------------------------------------------
// <copyright file="Figure.cs" company="Anton Klyushin">
// Copyright (c) Anton Klyushin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Snake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Snake class
    /// </summary>
    internal class Snake : Figure
    {
        /// <summary>
        /// Direction of moving
        /// </summary>
        private Direction direction;

        /// <summary>
        /// Initializes a new instance of the <see cref="Snake"/> class.
        /// </summary>
        /// <param name="tail">Point of snake tail</param>
        /// <param name="length">Length of snake</param>
        /// <param name="direction">Snake direction</param>
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            this.pList = new List<Point>();
            for (var i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                this.pList.Add(p);
            }
        }

        /// <summary>
        /// Get current direction
        /// </summary>
        internal Direction GetDirection => this.direction;

        /// <summary>
        /// Sets direction
        /// </summary>
        internal Direction SetDirection
        {
            set => this.direction = value;
        }

        /// <summary>
        /// Move snake method
        /// </summary>
        internal void Move()
        {
            var tail = this.pList.First();
            this.pList.Remove(tail);
            var head = this.GetNextPoint();
            this.pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        /// <summary>
        /// Get next point method
        /// </summary>
        /// <returns>Next point for head of snake</returns>
        internal Point GetNextPoint()
        {
            var head = this.pList.Last();
            var nextPoint = new Point(head);
            nextPoint.Move(1, this.direction);
            return nextPoint;
        }

        /// <summary>
        /// Eat of food method
        /// </summary>
        /// <param name="food">Food point</param>
        /// <returns>True or False</returns>
        internal bool Eat(Point food)
        {
            var head = this.pList.Last();
            if (head.IsHit(food))
            {
                food.SetSymbol = head.GetSymbol;
                this.pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// New fod on the snake
        /// </summary>
        /// <param name="x">Coordinate x</param>
        /// <param name="y">Coordinate y</param>
        /// <returns>True or False</returns>
        internal bool FoodOnSnake(int x, int y)
        {
            foreach (var p in this.pList)
            {
                if (p.GetX == x && p.GetY == y)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Hit with tail method
        /// </summary>
        /// <returns>True or False</returns>
        internal bool IsHitTail()
        {
            var head = this.pList.Last();

            for (var i = 0; i < this.pList.Count - 2; i++)
            {
                if (head.IsHit(this.pList[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Motion control method
        /// </summary>
        /// <param name="key">Pressed key</param>
        internal void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (this.direction != Direction.Right)
                    {
                        this.direction = Direction.Left;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (this.direction != Direction.Left)
                    {
                        this.direction = Direction.Right;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (this.direction != Direction.Down)
                    {
                        this.direction = Direction.Up;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (this.direction != Direction.Up)
                    {
                        this.direction = Direction.Down;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
