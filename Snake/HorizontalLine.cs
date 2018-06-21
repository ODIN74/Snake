//-----------------------------------------------------------------------
// <copyright file="HorizontalLine.cs" company="Anton Klyushin">
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
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
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
