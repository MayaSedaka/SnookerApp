using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;



namespace snookerFormdemo
{
    class general
    {
        public static void generalTmrFun(int b)
        {
            Form1.arr[3].BackColor = Color.Aquamarine;

            if (Form1.arr[b].Left < Form1.left || Form1.arr[b].Right > Form1.right || Form1.arr[b].Top < Form1.top || Form1.arr[b].Bottom > Form1.bottom)
            {
                if (Form1.arr[b].Bounds.IntersectsWith(Form1.holes[0].Bounds) || Form1.arr[b].Bounds.IntersectsWith(Form1.holes[1].Bounds) || Form1.arr[b].Bounds.IntersectsWith(Form1.holes[2].Bounds) ||
                    Form1.arr[b].Bounds.IntersectsWith(Form1.holes[3].Bounds) || Form1.arr[b].Bounds.IntersectsWith(Form1.holes[4].Bounds) || Form1.arr[b].Bounds.IntersectsWith(Form1.holes[5].Bounds))
                {
                    Form1.arr[b].Hide();
                }
                else
                {
                    if (Form1.ballArr[b].angle != 0 && Form1.ballArr[b].angle != System.Math.PI)
                        Form1.ballArr[b].angle = (-0.5 * System.Math.PI + Form1.ballArr[b].angle);
                    else
                        Form1.ballArr[b].angle = Form1.ballArr[b].angle + System.Math.PI;
                }
            }



           ;
            Form1.arr[b].Left += (int)(Form1.ballArr[b].v * Math.Cos(Form1.ballArr[b].angle) / 10);
            Form1.arr[b].Top -= (int)(Form1.ballArr[b].v * Math.Sin(Form1.ballArr[b].angle) / 10);



            if (Form1.ballArr[b].v > 0)
            {
                Form1.ballArr[b].v -= 9.81 * Form1.k;
                if (Form1.ballArr[b].v <= 0)
                    Form1.ballArr[b].v = 0;
            }

            else if (Form1.ballArr[b].v < 0)
            {
                Form1.ballArr[b].v += 9.81 * Form1.k;
                if (Form1.ballArr[b].v >= 0)
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
                    Form1.so.Play();
                    Form1.Collision2(Form1.ballArr[b], b, Form1.ballArr[i], i);

                    Form1.tmrArr[i].Interval = 10;
                    Form1.tmrArr[i].Start();
                }
                else if(i!=7&&Form1.arr[b].Bounds.IntersectsWith(Form1.arrst[i].Bounds) && i != b)
                {

                    Form1.arrst[i].BackColor = Color.Transparent;
                    Form1.so.Play();
                    Form1.Collision2Striped2(Form1.ballArr[b], b, Form1.striped[i], i);

                    Form1.tmrArr[i + 8].Interval = 10;
                    Form1.tmrArr[i+8].Start();
                }
            }
        }







        public static void generalTmrFunStriped(int b)
        {

            if (Form1.arrst[b].Left < Form1.left || Form1.arrst[b].Right > Form1.right || Form1.arrst[b].Top < Form1.top || Form1.arrst[b].Bottom > Form1.bottom)
            {
                if (Form1.arrst[b].Bounds.IntersectsWith(Form1.holes[0].Bounds) || Form1.arrst[b].Bounds.IntersectsWith(Form1.holes[1].Bounds) || Form1.arrst[b].Bounds.IntersectsWith(Form1.holes[2].Bounds) ||
                    Form1.arrst[b].Bounds.IntersectsWith(Form1.holes[3].Bounds) || Form1.arrst[b].Bounds.IntersectsWith(Form1.holes[4].Bounds) || Form1.arrst[b].Bounds.IntersectsWith(Form1.holes[5].Bounds))
                {
                    Form1.arr[b].Hide();
                }
                else
                {
                    if (Form1.striped[b].angle != 0 && Form1.striped[b].angle != System.Math.PI)
                        Form1.striped[b].angle = (-0.5 * System.Math.PI + Form1.striped[b].angle);
                    else
                        Form1.striped[b].angle = Form1.striped[b].angle + System.Math.PI;
                }
            }



            
            Form1.arrst[b].Left += (int)(Form1.striped[b].v * Math.Cos(Form1.striped[b].angle) / 10);
            Form1.arrst[b].Top -= (int)(Form1.striped[b].v * Math.Sin(Form1.striped[b].angle) / 10);



            if (Form1.striped[b].v > 0)
            {
                Form1.striped[b].v -= 9.81 * Form1.k;
                if (Form1.striped[b].v <= 0)
                    Form1.striped[b].v = 0;
            }

            else if (Form1.striped[b].v < 0)
            {
                Form1.striped[b].v += 9.81 * Form1.k;
                if (Form1.striped[b].v >= 0)
                    Form1.striped[b].v = 0;
            }
            else
            {
                Form1.striped[b].v = 0;

            }




            for (int i = 0; i < 8; i++)
            {

                if (i!=7&&Form1.arrst[b].Bounds.IntersectsWith(Form1.arrst[i].Bounds) && i != b)
                {
                    Form1.arr[3].BackColor = Color.Bisque;

                    Form1.arrst[i].BackColor = Color.Transparent;
                    Form1.so.Play();
                    Form1.Collision2Striped1(Form1.striped[b], b, Form1.striped[i], i);


                    Form1.tmrArr[i+8].Interval = 10;
                    Form1.tmrArr[i+8].Start();
                }
                else if(Form1.arrst[b].Bounds.IntersectsWith(Form1.arr[i].Bounds) && i != b)
                {
                    Form1.arr[i].BackColor = Color.Transparent;
                    Form1.so.Play();
                    Form1.Collision2Striped3(Form1.striped[b], b, Form1.ballArr[i], i);

                    Form1.arr[3].BackColor = Color.Bisque;

                    Form1.tmrArr[i].Interval = 10;
                    Form1.tmrArr[i].Start();
                }
            }
        }
    }
}

