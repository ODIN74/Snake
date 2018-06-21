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
    using System.Text;
    using System.Threading.Tasks;

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
    }
}
