using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace snookerFormdemo
{
    public class Ball 
    {
       public int radious=3;
        public int step;
       public  double v=0;
        public double angle;
        public Ball(int r)
        {
            this.radious = r;
        }

        public int Delta_x()
        { 

            return (int) (v * Math.Cos(angle));
        }
        public int Delta_y()
        {
            return(int)( v * Math.Sin(angle));
        }
        public int Step(int sign)
        {
            return Delta_x() / 20 * sign;
        }




    }



class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
    }
}
