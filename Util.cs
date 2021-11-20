using System;
namespace snookerFormdemo
{
    public class Util
    {

        public void generalTmrFun(int b)
        {

            if (Form1.arr[b].Left < left || Form1.arr[b].Right > right || Form1.arr[b].Top < top || Form1.arr[b].Bottom > bottom)
            {
                if Form1.arr[b].Bounds.IntersectsWith(p1.Bounds) || Form1.arr[b].Bounds.IntersectsWith(p2.Bounds) || Form1.arr[b].Bounds.IntersectsWith(p3.Bounds) ||
                    Form1.arr[b].Bounds.IntersectsWith(p4.Bounds) || Form1.arr[b].Bounds.IntersectsWith(p5.Bounds) || Form1.arr[b].Bounds.IntersectsWith(p6.Bounds))
                {
                    Form1.arr[b].Hide();
                }
                else
                {
                    if (Form1.ballArr[b].angle != 0 && Form1.ballArr[b].angle != Math.PI)
                        Form1.ballArr[b].angle = (-0.5 * Math.PI + Form1.ballArr[b].angle);
                    else
                        Form1.ballArr[b].angle = Form1.ballArr[b].angle + Math.PI;
                }
            }

            Form1.arr[b].Left += (int)Form1.ballArr[b].v * Math.Cos(Form1.ballArr[b].angle) / 10);
            Form1.arr[b].Top -= (int)(Form1.ballArr[b] * Math.Sin(Form1.ballArr[b].angle) / 10);


            if (Form1.ballArr[b].v > 0)
            {
                Form1.ballArr[b].v -= 9.81 * k;
                if (Form1.ballArr[b].v <= 0)
                    Form1.ballArr[b].v = 0;
            }

            else if (Form1.ballArr[b].v < 0)
            {
                Form1.ballArr[b].v += 9.81 * k;
                if Form1.ballArr[b].v >= 0)
                    Form1.ballArr[b].v = 0;
            }
            else
            {
                Form1.ballArr[b].v = 0;

            }




            for (int i = 0; i < 8; i++)
            {
                if (Form1.arr[b].Bounds.IntersectsWith(Form1.arr[i].Bounds) && i != b)
                {
                    Form1.arr[i].BackColor = Color.Transparent;
                    so.Play();
                    Collision2(Form1.ballArr[b], 0, Form1.ballArr[i], i);


                    Form1.tmrArr[i].Start();
                }
            }

        }


    }
}

