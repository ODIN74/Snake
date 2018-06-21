//-----------------------------------------------------------------------
// <copyright file="FoodCreator.cs" company="Anton Klyushin">
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
    /// Create food by snake
    /// </summary>
    internal class FoodCreator
    {
        /// <summary>
        /// Width of the map
        /// </summary>
        private readonly int mapWidth;

        /// <summary>
        /// Height of the map
        /// </summary>
        private readonly int mapHeight;

        /// <summary>
        /// Symbol of food
        /// </summary>
        private readonly char symbol;

        /// <summary>
        /// Randomizer of food coordinates
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="FoodCreator"/> class.
        /// </summary>
        /// <param name="mapWidth">Width of the map</param>
        /// <param name="mapHeight">Height of the map</param>
        /// <param name="symbol">Symbol of food</param>
        public FoodCreator(int mapWidth, int mapHeight, char symbol)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symbol = symbol;
        }

        /// <summary>
        /// Create food point
        /// </summary>
        /// <param name="snake">Snake instance</param>
        /// <returns>Food Point</returns>
        internal Point CreateFood(Snake snake)
        {
            int x;
            int y;
            do
            {
                x = this.rnd.Next(2, this.mapWidth - 3);
                y = this.rnd.Next(2, this.mapHeight - 2);
            }
            while (snake.FoodOnSnake(x, y));
            return new Point(x, y, this.symbol);
        }
    }
}
