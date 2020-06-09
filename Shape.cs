using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public abstract class Shape
    {
        /// <summary>
        /// Passing Graphic Value
        /// </summary>
        /// <param name="g"></param>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// passing the value from button click of form to the shape
        /// </summary>
        /// <param name="texturestyle">define texture</param>
        /// <param name="bb">define properties of brush</param>
        /// <param name="c">define color</param>
        /// <param name="list">list of parameter</param>
        public abstract void set(int texturestyle, Brush bb, Color c, params int[] list);

    }
}
