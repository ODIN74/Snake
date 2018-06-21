//-----------------------------------------------------------------------
// <copyright file="Walls.cs" company="Anton Klyushin">
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
    /// Walls class
    /// </summary>
    internal class Walls
    {
        /// <summary>
        /// List of walls
        /// </summary>
        private readonly List<Figure> wallList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Walls"/> class.
        /// </summary>
        /// <param name="mapWidth">Width of map</param>
        /// <param name="mapHeight">Height of map</param>
        internal Walls(int mapWidth, int mapHeight)
        {
            this.wallList = new List<Figure>();

            var horizontalLineTop = new HorizontalLine(0, Console.WindowWidth - 2, 0, '*');
            var verticalLineLeft = new VerticalLine(0, 1, Console.WindowHeight - 2, '*');
            var horizontalLineBottom = new HorizontalLine(0, Console.WindowWidth - 2, Console.WindowHeight - 1, '*');
            var verticalLineRight = new VerticalLine(Console.WindowWidth - 2, 1, Console.WindowHeight - 2, '*');

            this.wallList.Add(horizontalLineTop);
            this.wallList.Add(horizontalLineBottom);
            this.wallList.Add(verticalLineLeft);
            this.wallList.Add(verticalLineRight);
        }

        /// <summary>
        /// Hit with figure
        /// </summary>
        /// <param name="fig">Figure instance</param>
        /// <returns>True or False</returns>
        internal bool IsHit(Figure fig)
        {
            foreach (var wall in this.wallList)
            {
                if (wall.IsHit(fig))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Draw walls method
        /// </summary>
        internal void Draw()
        {
            foreach (var wall in this.wallList)
            {
                wall.Draw();
            }
        }
    }
}
