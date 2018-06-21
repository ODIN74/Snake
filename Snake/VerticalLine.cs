//-----------------------------------------------------------------------
// <copyright file="VerticalLine.cs" company="Anton Klyushin">
// Copyright (c) Anton Klyushin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Snake
{
    using System.Collections.Generic;

    /// <summary>
    /// VerticalLine class
    /// </summary>
    internal class VerticalLine : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerticalLine"/> class.
        /// </summary>
        /// <param name="x">Coordinate x</param>
        /// <param name="yTop">Top coordinate y</param>
        /// <param name="yBottom">Bottom coordinate y</param>
        /// <param name="symbol">Point symbol</param>
        internal VerticalLine(int x, int yTop, int yBottom, char symbol)
        {
            this.pList = new List<Point>();
            for (var y = yTop; y <= yBottom; y++)
            {
                var p = new Point(x, y, symbol);
                this.pList.Add(p);
            }
        }
    }
}
