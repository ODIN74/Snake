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

        /// <summary>
        /// Hit figure with figure
        /// </summary>
        /// <param name="fig">Figure instance</param>
        /// <returns>True or False</returns>
        internal bool IsHit(Figure fig)
        {
            foreach (var p in pList)
            {
                if (fig.IsHit(p))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Hit figure with point
        /// </summary>
        /// <param name="point">Point instance</param>
        /// <returns>True or False</returns>
        private bool IsHit(Point point)
        {
            foreach (var p in this.pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
