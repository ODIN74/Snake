//-----------------------------------------------------------------------
// <copyright file="HorizontalLine.cs" company="Anton Klyushin">
// Copyright (c) Anton Klyushin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Snake
{
    using System.Collections.Generic;

    /// <summary>
    /// HorizontalLine class
    /// </summary>
    internal class HorizontalLine : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HorizontalLine"/> class.
        /// </summary>
        /// <param name="xLeft">Left coordinate x of point</param>
        /// <param name="xRight">Right coordinate x of point</param>
        /// <param name="y">Coordinate y of point</param>
        /// <param name="symbol">Point symbol</param>
        internal HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            this.pList = new List<Point>();
            for (var x = xLeft; x <= xRight; x++)
            {
                var p = new Point(x, y, symbol);
                this.pList.Add(p);
            }
        }
    }
}
