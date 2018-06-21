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
    /// Figure class
    /// </summary>
    internal class Figure
    {
        /// <summary>
        /// List of points
        /// </summary>
        protected List<Point> pList;

        /// <summary>
        /// Draw of figure method
        /// </summary>
        public void Draw()
        {
            foreach (var p in this.pList)
            {
                p.Draw();
            }
        }
    }
}
