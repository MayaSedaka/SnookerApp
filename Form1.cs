using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;


namespace snookerFormdemo
{
    public partial class Form1 : Form
    {
     
        float eMouseX, eMouseY;
        double k;
        int left, right, top, bottom;
        bool isPressed = false;
        
        public PictureBox[] arr = new PictureBox[8];
        public PictureBox[] holes = new PictureBox[6];
        public Ball[] ballArr = new Ball[8];
        Timer[] tmrArr = new Timer[8];
        Ball ballObj = new Ball(2);
        Ball ball2Obj = new Ball(2);
        Ball ball3Obj = new Ball(2);
        Ball ball4Obj = new Ball(2);
        Ball ball5Obj = new Ball(2);
        Ball ball6Obj = new Ball(2);
        Ball ball7Obj = new Ball(2);
        Ball ball8Obj = new Ball(2);
        float vel;
        Boolean player;//computer-false, person-true
        Boolean f= false;
        int ang;
        int x, y;
        SoundPlayer so = new SoundPlayer(@"C:\new\sound2.WAV");

        public Point mouseDownLocation;
    
        Point startDownLocation= new Point();
        static PaintEventArgs ev;
        Stopwatch timer = new Stopwatch();
        public Form1()
        {

            InitializeComponent();

            generaltmr.Start();

           // timer2.Start();
            timer1.Start();
            trb.Hide();
            trb1.Hide();
            player = true;
            k = 0.33;
            left = 60;
            right = 1500;
            top = 60;
            bottom = 720;
            ballArr[0] = ballObj;
            ballArr[1] = ball2Obj;
            ballArr[2] = ball3Obj;
            ballArr[3] = ball4Obj;
            ballArr[4] = ball5Obj;
            ballArr[5] = ball6Obj;
            ballArr[6] = ball7Obj;
            ballArr[7] = ball8Obj;

            holes[0] = p1;
            holes[1] = p2;
            holes[2] = p3;
            holes[3] = p4;
            holes[4] = p5;
            holes[5] = p6;

            arr[0] = ball;
            arr[1] = ball2;
            arr[2] = ball3;
            arr[3] = ball4;
            arr[4] = ball5;
            arr[5] = ball6;
            arr[6] = ball7;
            arr[7] = ball8;


            tmrArr[0] = balltmr;
            tmrArr[1] = ball2tmr;
            tmrArr[2] = ball3tmr;
            tmrArr[3] = ball4tmr;
            tmrArr[4] = ball5tmr;
            tmrArr[5] = ball6tmr;
            tmrArr[6] = ball7tmr;
            tmrArr[7] = ball8tmr;

        }
     
       
        public void Collision(Ball ball1, int i, Ball ball2, int j)
        {
            double vcollision_x = arr[i].Left - arr[j].Left;
            double vcollision_y = arr[i].Top - arr[j].Top;

            double dis = Math.Sqrt(vcollision_x * vcollision_x + vcollision_y * vcollision_y);

            double vnorm_x = vcollision_x / dis;
            double vnorm_y = vcollision_y / dis;

            double deltav_x = ball1.Delta_x() - ball2.Delta_x();
            double deltav_y = ball1.Delta_y() - ball2.Delta_y();

            double speed = deltav_x * vnorm_x + deltav_y * vnorm_y;

            ball1.v = speed;
            ball2.v = speed;





        }

        public void Collision2(Ball b1, int i, Ball b2, int j)
        {
            
            int dx = arr[j].Left - arr[i].Left;
            int dy = arr[j].Top - arr[i].Top;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            double angle = Math.Atan2(dy, dx);

            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double s = Math.Sin(Math.PI / 2 - angle);
            double c = Math.Cos(Math.PI / 2 - angle);

            double vx1 = b1.Delta_x() * cos + b1.Delta_y() * sin;
            double vy1 = b1.Delta_y() * cos - b1.Delta_x() * sin;
           // double vx2 = b2.Delta_x() * c - b2.Delta_x() * s;
            double vx2 = b2.Delta_x() * cos + b2.Delta_y() * sin;
           // double vy2 = b2.Delta_y() * c - b2.Delta_y() * s;
            double vy2 = b2.Delta_y() * cos - b2.Delta_x() * sin;
            //double vx2 = b2.Delta_x() * Math.Cos(0.5 * Math.PI - angle) - b2.Delta_x() * Math.Sin(0.5 * Math.PI - angle);
            //double vy2 = b2.Delta_y() * Math.Cos(0.5*Math.PI -angle) - b2.Delta_y() * Math.Sin(0.5 * Math.PI - angle);
            double vx1final, vx2final;
            ///* if (vx1 != 0 && vx2 != 0)
            //{
            vx1final = vx2;//(vx1 / Math.Abs(vx1)) * vx2;
    
                //vx2final = (vx1final / Math.Abs(vx1final)) * vx1;//-(vx2 / Math.Abs(vx2)) * vx1;
        
                vx2final = vx1;
          //  }
           // else
            //{
              //  vx1final = vx2;
              //  vx2final = -vx1;
            //}
            double vy1final = vy1;
            double vy2final = vy2;
           double vx1f = vx1final * cos- vy1final * sin;
           // double vx1f = vx1final * c - vx1final * s;
            double vy1f = vy1final *cos + vx1final *sin;
            //double vy1f = vy1final * c - vy1final * s;
            double vx2f = vx2final * cos - vy2final * sin;
            double vy2f = vy2final * cos + vx2final * sin;


            // arr[i].Left -=(int) vx1f / 20;
            //arr[i].Top +=(int) vy1f / 20;
            //arr[j].Top +=(int) vy2f / 20;
            //arr[j].Left -= (int)vx2f / 20;

            b1.v = Math.Sqrt(vx1f * vx1f + vy1f * vy1f);
            b2.v = Math.Sqrt(vx2f * vx2f + vy2f * vy2f);
            if (vx1f != 0)
            {
                if (vx1f < 0)
                    b1.angle += Math.PI;
                else

                    b1.angle = Math.Atan(vy1f / vx1f);
            }
            else
                b1.angle = Math.PI / 2;//Math.PI / 2;

            // b1.angle = Math.Atan2(vx2f ,vx1f);
            // b2.angle = Math.Atan2(vy2f, vx2f);

         
            if (vx2f != 0)
            {
                if (vx2f < 0)
                    b2.angle += Math.PI;
                else

                    b2.angle = Math.Atan(vy2f / vx2f);
            }
            else
                b2.angle = Math.PI / 2;
        }
        public int FindBallIndex(Ball b)
        {
            for (int i = 0; i < 8; i++)
            {
                if (ballArr[i] == b)
                    return i;
            }

            return 10;


        }
        private void balltmr_Tick(object sender, EventArgs e)
        {
          
            //ball.Left < 60 || ball.Right > 1560 || ball.Top < 40 || ball.Bottom > 660
            if (ball.Left < left || ball.Right > right || ball.Top < top || ball.Bottom > bottom)
            {
                if (ball.Bounds.IntersectsWith(p1.Bounds) || ball.Bounds.IntersectsWith(p2.Bounds) || ball.Bounds.IntersectsWith(p3.Bounds) ||
                    ball.Bounds.IntersectsWith(p4.Bounds) || ball.Bounds.IntersectsWith(p5.Bounds) || ball.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball.Hide();
                }
                else
                {
                    ballObj.v = ballObj.v * -1;
                    ballObj.angle = -0.5 * Math.PI +ballObj.angle;
                }
            }
            // double dis = Math.Pow(ballObj.v, 2) / 20 * k;
            // double t =  dis * 2 / ballObj.v;
            // balltmr.Interval =(int)( Math.Abs( t));


           ;
            ball.Left += (int)(ballObj.v * Math.Cos(ballObj.angle) / 10);
            ball.Top -= (int)(ballObj.v * Math.Sin(ballObj.angle) / 10);

            //  while (Math.Abs(ballObj.v) > 0.02)
            //{
            //  if (ballObj.v < 0) 
            //    ballObj.v += Math.Abs(9.81 * k);
            //else
            //  {
            //    ballObj.v -= Math.Abs(9.81 * k);
            //  Console.WriteLine(ballObj.v);


            if (ballObj.v > 0)
            {
                ballObj.v -= 9.81 * k;
                if (ballObj.v <= 0)
                    ballObj.v = 0;
            }

            else if (ballObj.v < 0)
            {
                ballObj.v += 9.81 * k;
                if (ballObj.v >= 0)
                    ballObj.v = 0;
            }
            else
            {
                ballObj.v = 0;

            }




            for (int i = 1; i < 8; i++)
            {
                if (ball.Bounds.IntersectsWith(arr[i].Bounds))
                {
                   /// ball.Controls.Add(arr[i]);
                    //arr[i].Location = new Point(0, 0);
                   
                   arr[i].BackColor = Color.Transparent;
                    so.Play();
                    Collision2(ballObj, 0, ballArr[i], i);
                   // Collision(ballObj, 0, ballArr[i], i);

                    tmrArr[i].Start();
                }
            }

        }
        private double ToRadians(double a)
        {
            return a / 180 * Math.PI;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
       
            startDownLocation=e.Location;
         
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ball3Obj.v == 0 ||!f) { 
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
            f=true;
            // Create points that define line.
            PointF point1 = new PointF((float)(ball3.Left+13), (float)(ball3.Top+13));
            PointF point2 = new PointF((float)(eMouseX), (float)(eMouseY));
                // Draw line to screen.
                e.Graphics.DrawLine(blackPen, point1, point2);
                if (isPressed)
                {
                    ball3Obj.v = Math.Sqrt(Math.Pow((eMouseX - ball3.Left + 13), 2) + Math.Pow((eMouseY - ball3.Top + 13), 2))/3 ;

                    ball3Obj.angle = -Math.Atan2((eMouseY - ball3.Top + 13), (eMouseX - ball3.Left + 13));// -2.5*Math.PI;
                    lbl.Text = "" + ball3Obj.angle/Math.PI*180;                                                                                      // Console.WriteLine(ball3Obj.angle);
                    ball3tmr.Start();

                }
            }
     

      

            
         //Console.WriteLine(ball3Obj.v);
                //isGraphics=false;
            //Graphics g = e.Graphics;
            //Pen pen = new Pen(Color.Black);
            // while (isPressed)
            //{
            /*  int nw = 0;
              int nh = 0;
              Bitmap btm = new Bitmap(img.Width, img.Height);
              if (ang <= 90)
              {
                  nw = (int)(btm.Width * Math.Cos(2 * Math.PI * ang / 360) + btm.Height * Math.Sin(2 * Math.PI * ang / 360));
                  nh = (int)(btm.Height * Math.Cos(2 * Math.PI * ang / 360) + btm.Width * Math.Sin(2 * Math.PI * ang / 360));
              }
              else if (ang > 90 && ang <= 180)
              {
                  nw = (int)(btm.Width * -Math.Cos(2 * Math.PI * ang / 360) + btm.Height * Math.Sin(2 * Math.PI * ang / 360));
                  nh = (int)(btm.Height * -Math.Cos(2 * Math.PI * ang / 360) + btm.Width * Math.Sin(2 * Math.PI * ang / 360));
              }
              else if (ang > 180 && ang <= 270)
              {
                  nw = (int)(btm.Width * -Math.Cos(2 * Math.PI * ang / 360) + btm.Height * -Math.Sin(2 * Math.PI * ang / 360));
                  nh = (int)(btm.Height * -Math.Cos(2 * Math.PI * ang / 360) + btm.Width * -Math.Sin(2 * Math.PI * ang / 360));
              }
              else if (ang > 270 && ang <= 360)
              {
                  nw = (int)(btm.Width * Math.Cos(2 * Math.PI * ang / 360) + btm.Height * -Math.Sin(2 * Math.PI * ang / 360));
                  nh = (int)(btm.Height * Math.Cos(2 * Math.PI * ang / 360) + btm.Width * -Math.Sin(2 * Math.PI * ang / 360));
              }
              Bitmap bit_map = new Bitmap(nw, nh);
              Graphics gfx = Graphics.FromImage(bit_map);
              gfx.TranslateTransform(nw / 2, nh / 2);
              gfx.RotateTransform(ang);
              gfx.TranslateTransform(-img.Width / 2, -img.Height / 2);
              gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
              gfx.DrawImage(img, 0, 0);
              e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
              // e.Graphics.DrawImage(bit_map, -bit_map.Width/2, -bit_map.Height/2 );
              e.Graphics.DrawImage(bit_map, 40, 40);*/
            // Invalidate();
         
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e )
        {

       
                
            

            eMouseX = e.X;
            eMouseY = e.Y;
      

            if (hit.Checked)
               
            {
               // pic.Left = (int)eMouseX;
               //pic.Top = (int)eMouseY;
                 ball3Obj.v = vel;
                 ball3Obj.angle = -ToRadians(trb.Value);
                 ball3tmr.Start();
              //  for (int i=0; i<8; i++)
               // {
                 //  if (stick.Bounds.IntersectsWith(arr[i].Bounds))
                  //  {
                    //    ballArr[i].v = vel;//60.0;

                     //   ballArr[i].angle = -ToRadians(trb.Value);//(trb.Value+90);//180*Math.PI;//(trb.Value * Math.PI / 180 - Math.PI / 2) % 180;//360*2*Math.PI;//0.25*Math.PI;
                                                               //Console.WriteLine(ToRadians(90));
                     //   tmrArr[i].Start();
                  //  }
              //  }
                
            }

            if (isPressed)
            {
         
            
                    vel =trb1.Value;
                   
            
                // for (int i = 0; i < 8; i++)
                // {

                // if (stick.Bounds.IntersectsWith(arr[i].Bounds) && arr[i].Visible)
                // {
                //if ( stick.Left <= arr[i].Left)
                ///  stick.Left = arr[i].Left;
                //else if ( stick.Top >= arr[i].Top)
                //  stick.Top = arr[i].Top;
                // ballArr[i].v = vel;//60.0;

                //  ballArr[i].angle = (trb.Value*Math.PI/180-Math.PI/2)%180;//360*2*Math.PI;//0.25*Math.PI;

                //  tmrArr[i].Start();

                //  }

                //  }

            }
          //  Refresh();

            }

      
        

      


        private void drtmr_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  img = Image.FromFile(@"C:\new\tranew.png");

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
 
            isPressed = false;
          
        }
      
        


        private void ball2tmr_Tick(object sender, EventArgs e)
        {

            if (ball2.Left < left || ball2.Right > right || ball2.Top < top || ball2.Bottom > bottom)
            {

                if (ball2.Bounds.IntersectsWith(p1.Bounds) || ball2.Bounds.IntersectsWith(p2.Bounds) || ball2.Bounds.IntersectsWith(p3.Bounds) ||
                    ball2.Bounds.IntersectsWith(p4.Bounds) || ball2.Bounds.IntersectsWith(p5.Bounds) || ball2.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball2.Hide();
                }
                else
                {
                    ball2Obj.v = ball2Obj.v * -1;
                    ball2Obj.angle = -0.5 * Math.PI + ball2Obj.angle;
                }
            }
            ball2.Left += (int)(ball2Obj.v * Math.Cos(ball2Obj.angle) / 10);
            ball2.Top -= (int)(ball2Obj.v * Math.Sin(ball2Obj.angle) / 10);
            // while (ball2Obj.v > 0)
            //   ball2Obj.v -= Math.Abs(9.81 * k);
            if (ball2Obj.v > 0)
            {
                ball2Obj.v -= 9.81 * k;
                if (ball2Obj.v <= 0)
                    ball2Obj.v = 0;
            }

            else if (ball2Obj.v < 0)
            {
                ball2Obj.v += 9.81 * k;
                if (ball2Obj.v >= 0)
                    ball2Obj.v = 0;
            }
            else
            {
                ball2Obj.v = 0;

            }
            for (int i = 0; i < 8; i++)
            {
                if (i != 1)
                {
                    if (ball2.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        so.Play();
                        Collision2(ball2Obj, 1, ballArr[i], i);
                       // Collision(ball2Obj, 1, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }

        }

        private void ball3tmr_Tick(object sender, EventArgs e)
        {

           
            ball3tmr.Interval = 10;
            // Console.WriteLine(ball3Obj.angle / Math.PI * 180);
            if (ball3.Left < left || ball3.Right > right || ball3.Top < top || ball3.Bottom > bottom)
            {

                if (ball3.Bounds.IntersectsWith(p1.Bounds) || ball3.Bounds.IntersectsWith(p2.Bounds) || ball3.Bounds.IntersectsWith(p3.Bounds) ||
                    ball3.Bounds.IntersectsWith(p4.Bounds) || ball3.Bounds.IntersectsWith(p5.Bounds) || ball3.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball3.Hide();
                }
                else
                {
                    ball3Obj.v = ball3Obj.v * -1;
                    ball3Obj.angle = (-0.5 * Math.PI + ball3Obj.angle);
                    //Console.WriteLine(ball3Obj.angle / Math.PI * 180);
                }
            }
           // lbl.Text = "" + ball3Obj.v;
            ball3.Left += (int) (ball3Obj.v*Math.Cos(ball3Obj.angle) / 10);
            ball3.Top -= (int)(ball3Obj.v * Math.Sin(ball3Obj.angle) / 10);
            if (ball3Obj.v > 0)
            {
                ball3Obj.v -= 9.81 * k;
                if (ball3Obj.v <= 0)
                    ball3Obj.v = 0;
            }

            else if (ball3Obj.v < 0)
            {
                ball3Obj.v += 9.81 * k;
                if (ball3Obj.v >= 0)
                    ball3Obj.v = 0;
            }
            else
            {
                ball3Obj.v = 0;
               
            }

            for (int i = 0; i < 8; i++)
            {
                if (i != 2)
                {
                    if (ball3.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        

                        so.Play();
                        Collision2(ball3Obj, 2, ballArr[i], i);
                        //Collision(ball3Obj, 2, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }
            //if (ball3Obj.v <= 10)
            //{
            // player = false;
            //  timer2.Start();
            //}
          
        }

        private void ball4tmr_Tick(object sender, EventArgs e)
        {
            if (ball4.Left < left || ball4.Right >right || ball4.Top < top || ball4.Bottom >bottom)
            {

                if (ball4.Bounds.IntersectsWith(p1.Bounds) || ball4.Bounds.IntersectsWith(p2.Bounds) || ball4.Bounds.IntersectsWith(p3.Bounds) ||
                    ball4.Bounds.IntersectsWith(p4.Bounds) || ball4.Bounds.IntersectsWith(p5.Bounds) || ball4.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball4.Hide();
                }
                else
                {
                    ball4Obj.v = ball4Obj.v * -1;
                    ball4Obj.angle = -0.5 * Math.PI + ball4Obj.angle;
                }
            }
            ball4.Left += (int)(ball4Obj.v * Math.Cos(ball4Obj.angle) / 10);
            ball4.Top -= (int)(ball4Obj.v * Math.Sin(ball4Obj.angle) / 10);
            //  while (ball4Obj.v > 0)
            //    ball4Obj.v -= Math.Abs(9.81  * k);
            if (ball4Obj.v > 0)
            {
                ball4Obj.v -= 9.81 * k;
                if (ball4Obj.v <= 0)
                    ball4Obj.v = 0;
            }

            else if (ball4Obj.v < 0)
            {
                ball4Obj.v += 9.81 * k;
                if (ball4Obj.v >= 0)
                    ball4Obj.v = 0;
            }
            else
            {
                ball4Obj.v = 0;

            }


            for (int i = 0; i < 8; i++)
            {
                if (i != 3)
                {
                    if (ball4.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        so.Play();
                        Collision2(ball4Obj, 3, ballArr[i], i);
                        //Collision(ball4Obj, 3, ballArr[i], i);
                        tmrArr[i].Start();
                    }
                }
            }

        }

        private void ball5tmr_Tick(object sender, EventArgs e)
        {
            if (ball5.Left < left || ball5.Right > right || ball5.Top < top || ball5.Bottom > bottom)
            {

                if (ball5.Bounds.IntersectsWith(p1.Bounds) || ball5.Bounds.IntersectsWith(p2.Bounds) || ball5.Bounds.IntersectsWith(p3.Bounds) ||
                    ball5.Bounds.IntersectsWith(p4.Bounds) || ball5.Bounds.IntersectsWith(p5.Bounds) || ball5.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball5.Hide();
                }
                else{
                    ball5Obj.v = ball5Obj.v * -1;
                    ball5Obj.angle = -0.5 * Math.PI + ball5Obj.angle;
                }
            }
            ball5.Left += (int)(ball5Obj.v * Math.Cos(ball5Obj.angle) / 10);
            ball5.Top -= (int)(ball5Obj.v * Math.Sin(ball5Obj.angle) / 10);
            //  while (ball5Obj.v > 0)
            //    ball5Obj.v -= Math.Abs(9.81  * k);
            if (ball5Obj.v > 0)
            {
                ball5Obj.v -= 9.81 * k;
                if (ball5Obj.v <= 0)
                    ball5Obj.v = 0;
            }

            else if (ball5Obj.v < 0)
            {
                ball5Obj.v += 9.81 * k;
                if (ball5Obj.v >= 0)
                    ball5Obj.v = 0;
            }
            else
            {
                ball5Obj.v = 0;

            }

            for (int i = 0; i < 8; i++)
            {
                if (i != 4)
                {
                    if (ball5.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        so.Play();
                        Collision2(ball5Obj, 4, ballArr[i], i);

                       // Collision(ball5Obj, 4, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }
          

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void trb1_Resize(object sender, EventArgs e)
        {

        }

        private void trb_ValueChanged(object sender, EventArgs e)
        {
            ang = trb.Value;
            Invalidate();
        }

        private void popup_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(popup, 0, 0);
          
        }

      

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

      

        private void ball6tmr_Tick(object sender, EventArgs e)
        {
            if (ball6.Left < left || ball6.Right > right || ball6.Top < top || ball6.Bottom > bottom)
            {

                if (ball6.Bounds.IntersectsWith(p1.Bounds) || ball6.Bounds.IntersectsWith(p2.Bounds) || ball6.Bounds.IntersectsWith(p3.Bounds) ||
                    ball6.Bounds.IntersectsWith(p4.Bounds) || ball6.Bounds.IntersectsWith(p5.Bounds) || ball6.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball6.Hide();
                }
                else
                {
                    ball6Obj.v = ball6Obj.v * -1;
                    ball6Obj.angle = -0.5 * Math.PI + ball6Obj.angle;
                }
            }
            ball6.Left += (int)(ball6Obj.v * Math.Cos(ball6Obj.angle) / 10);
            ball6.Top -= (int)(ball6Obj.v * Math.Sin(ball6Obj.angle) / 10);
            //   while (ball6Obj.v > 0)
            //     ball6Obj.v -= Math.Abs(9.81 * k);
            if (ball6Obj.v > 0)
            {
                ball6Obj.v -= 9.81 * k;
                if (ball6Obj.v <= 0)
                    ball6Obj.v = 0;
            }

            else if (ball6Obj.v < 0)
            {
                ball6Obj.v += 9.81 * k;
                if (ball6Obj.v >= 0)
                    ball6Obj.v = 0;
            }
            else
            {
                ball6Obj.v = 0;

            }

            for (int i = 0; i < 8; i++)
            {
                if (i != 5)
                {
                    if (ball6.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        so.Play();
                        Collision2(ball6Obj, 5, ballArr[i], i);
                        //Collision(ball6Obj, 5, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void ball7tmr_Tick(object sender, EventArgs e)
        {
            if (ball7.Left < left || ball7.Right > right || ball7.Top < top || ball7.Bottom > bottom)
            {

                if (ball7.Bounds.IntersectsWith(p1.Bounds) || ball7.Bounds.IntersectsWith(p2.Bounds) || ball7.Bounds.IntersectsWith(p3.Bounds) ||
                    ball7.Bounds.IntersectsWith(p4.Bounds) || ball7.Bounds.IntersectsWith(p5.Bounds) || ball7.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball7.Hide();
                }
                else
                {
                    ball7Obj.v = ball7Obj.v * -1;
                    ball7Obj.angle = -0.5 * Math.PI + ball7Obj.angle % Math.PI / 2;
                }
            }
            ball7.Left += (int)(ball7Obj.v * Math.Cos(ball7Obj.angle) / 10);
            ball7.Top -= (int)(ball7Obj.v * Math.Sin(ball7Obj.angle) / 10);
            //   while (ball7Obj.v > 0)
            //     ball7Obj.v -= Math.Abs(9.81 * k);
            if (ball7Obj.v > 0)
            {
                ball7Obj.v -= 9.81 * k;
                if (ball7Obj.v <= 0)
                    ball7Obj.v = 0;
            }

            else if (ball7Obj.v < 0)
            {
                ball7Obj.v += 9.81 * k;
                if (ball7Obj.v >= 0)
                    ball7Obj.v = 0;
            }
            else
            {
                ball7Obj.v = 0;

            }

            for (int i = 0; i < 8; i++)
            {
                if (i != 6)
                {
                    if (ball7.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        so.Play();
                        Collision2(ball7Obj, 6, ballArr[i], i);
                       // Collision(ball7Obj, 6, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }
        }

        private void ball8tmr_Tick(object sender, EventArgs e)
        {

             if (ball8.Left < left || ball8.Right > right || ball8.Top < top || ball8.Bottom > bottom)
            {

                if (ball8.Bounds.IntersectsWith(p1.Bounds) || ball8.Bounds.IntersectsWith(p2.Bounds) || ball8.Bounds.IntersectsWith(p3.Bounds) ||
                    ball8.Bounds.IntersectsWith(p4.Bounds) || ball8.Bounds.IntersectsWith(p5.Bounds) || ball8.Bounds.IntersectsWith(p6.Bounds))
                {
                    ball8.Hide();
                }
                else
                {
                    ball8Obj.v = ball8Obj.v * -1;
                    ball8Obj.angle = -0.5 * Math.PI + ball8Obj.angle;
                }
            }
            ball8.Left += (int)(ball8Obj.v * Math.Cos(ball8Obj.angle) / 10);
            ball8.Top -= (int)(ball8Obj.v * Math.Sin(ball8Obj.angle) / 10);
            //   while (Math.Abs(ball8Obj.v) > 0)
            //     ball8Obj.v -= Math.Abs(9.81  * k);
            if (ball8Obj.v > 0)
            {
                ball8Obj.v -= 9.81 * k;
                if (ball8Obj.v <= 0)
                    ball8Obj.v = 0;
            }

            else if (ball8Obj.v < 0)
            {
                ball8Obj.v += 9.81 * k;
                if (ball8Obj.v >= 0)
                    ball8Obj.v = 0;
            }
            else
            {
                ball8Obj.v = 0;

            }
            for (int i = 0; i < 8; i++)
            {
                if (i != 7)
                {
                    if (ball8.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        so.Play();
                        Collision2(ball8Obj, 7, ballArr[i], i);
                        //  Collision(ball8Obj, 7, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int dis = p3.Left- ball.Left, temp=0, b=0, h=0;
            for(int i=0; i<8; i++)
            {
                for (int j = 0; j < 6;j++) {
                    if (i != 2)
                    {
                         temp= holes[j].Left-arr[i].Left;
                        if (temp<dis)
                        {
                            b = i;
                            h = j; 
                        }
                    }
                }

               
            }
           //arr[b].BackColor = Color.Red;
            ballArr[b].v = 70;
            ballArr[b].angle = Math.Atan2((arr[b].Top -holes[h].Top), (arr[b].Left - holes[h].Left));
            tmrArr[b].Start();
            timer2.Stop();
        }

        private void generaltmr_Tick(object sender, EventArgs e)
        {

            this.Invalidate();
            if (!player)
            {
               
                lbp.Text = "computer";
                timer2.Start();
            }
        }
    }
}
