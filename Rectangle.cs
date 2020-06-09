using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class Rectangle : Shape
    {
       public  int x, y, size, size1;
       public  int texturestyle;
        
       public  Brush bb;
       public  Color c1;

        /// <summary>
        /// this function draws rectangle
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            if (texturestyle == 0)
            {
                g.DrawRectangle(p, x, y, size, size1);
            }
            else
            {
                g.FillRectangle(bb, x, y, size, size1);
            }
        }

        /// <summary>
        /// Setting the required properties for rectangle
        /// </summary>
        /// <param name="texturestyle"></param>
        /// <param name="bb"></param>
        /// <param name="c1"></param>
        /// <param name="list"></param>
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
