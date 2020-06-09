using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class Circle : Shape
    {
        /// <summary>
        /// Getting value for ellipse
        /// </summary>
        int x, y, size, size1;
        Color c1;
        int texturestyle;
        Brush bb;

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            if(texturestyle == 0)
            {
                g.DrawEllipse(p, x, y, size, size1);
            }
            else
            {
                g.FillEllipse(bb, x, y, size, size1);
            }
        }
        /// <summary>
        /// Setting the required parameter for circle
        /// </summary>
        /// <param name="texturestyle">Define the texture</param>
        /// <param name="bb">type of brush</param>
        /// <param name="c1">color </param>
        /// <param name="list">list of parameter that will be passed inside this function</param>
        public override void set(int texturestyle, Brush bb, Color c1, params int[] list)
        {
            this.texturestyle = texturestyle;
            this.bb = bb;
            this.c1 = c1;
            this.x = list[0];
            this.y = list[1];
            this.size = list[2];
            this.size1 = list[3];
        }
    }
}
