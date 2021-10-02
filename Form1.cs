using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;

namespace snookerFormdemo
{
    public partial class Form1 : Form
    {
        int temp_x, temp_y;
        int lang=0;
        float eMouseX, eMouseY;
        double k;
        int left, right, top, bottom;
        bool isPressed = false;
        int ball1mass = 1;
        int ball2mass = 1;
        int ballSpeed;
        int ball2Speed;
        public PictureBox[] arr = new PictureBox[8];
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
        Image img;
        int ang;
        int x, y;
        Timer timer=new Timer();
        public Form1()
        {

            var formPopup = new Form();
            formPopup.Show(this);
            InitializeComponent();

            generaltmr.Start();
            // btn.Enabled = false;
            // stick.Top = ball.Top;
            // stick.Left = ball.Left - 150;
            // ballSpeed = 1;
            // ball2Speed = -1;
          
            timer.Enabled = true;
            timer.Interval = 100;  /* 100 millisec */
            timer.Tick += new EventHandler(TimerCallback);

            k = 0.002;
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
        private void TimerCallback(object sender, EventArgs e)
        {
            x += 10;
            y += 10;
            this.Invalidate();
            return;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.FillRectangle(Brushes.Red, x, y, 100, 100);
            base.OnPaint(e);
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

            double vx1 = b1.Delta_x() * cos - b1.Delta_x() * sin;
            double vy1 = b1.Delta_y() * cos - b1.Delta_y() * sin;
            double vx2 = b2.Delta_x() * c - b2.Delta_x() * s;
            double vy2 = b2.Delta_y() * c - b2.Delta_y() * s;
            //double vx2 = b2.Delta_x() * Math.Cos(0.5 * Math.PI - angle) - b2.Delta_x() * Math.Sin(0.5 * Math.PI - angle);
            //double vy2 = b2.Delta_y() * Math.Cos(0.5*Math.PI -angle) - b2.Delta_y() * Math.Sin(0.5 * Math.PI - angle);
            double vx1final = vx2;
            double vx2final = vx1;
            double vy1final = vy1;
            double vy2final = vy2;
            double vx1f = vx1final * Math.Cos(angle) - vx1final * Math.Sin(angle);
            double vy1f = vy1final * Math.Cos(angle) - vy1final * Math.Sin(angle);
            double vx2f = vx2final * Math.Cos(angle) - vx2final * Math.Sin(angle);
            double vy2f = vy2final * Math.Cos(angle) - vy2final * Math.Sin(angle);


            // arr[i].Left -=(int) vx1f / 20;
            //arr[i].Top +=(int) vy1f / 20;
            //arr[j].Top +=(int) vy2f / 20;
            //arr[j].Left -= (int)vx2f / 20;

            b1.v = Math.Sqrt(vx1f * vx1f + vy1f * vy1f);
            b2.v = Math.Sqrt(vx2f * vx2f + vy2f * vy2f);
            if (vx1f != 0)
            {
                if (vx1f < 0)
                    b1.angle = Math.PI;
                else

                    b1.angle = Math.Atan(vy1f / vx1f);
            }
            else
                b1.angle = Math.PI / 2;//Math.PI / 2;

            // b1.angle = Math.Atan2(vx2f ,vx1f);
            // b2.angle = Math.Atan2(vy2f, vx2f);

            SoundPlayer so= new SoundPlayer(@"C:\new\11.WAV");
            
            so.Play();
            if (vx2f != 0)
            {
                if (vx2f < 0)
                    b2.angle = Math.PI;
                else

                    b2.angle = Math.Atan(vy2f / vx2f);
            }
            else
                b2.angle = Math.PI / 2;//Math.PI / 2;
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

            

            ball.Left += ballObj.Delta_x() / 20;
            ball.Top -= ballObj.Delta_y() / 20;
          //  while (Math.Abs(ballObj.v) > 0.02)
            //{
              //  if (ballObj.v < 0) 
                //    ballObj.v += Math.Abs(9.81 * k);
                //else
                  //  {
                    //    ballObj.v -= Math.Abs(9.81 * k);
                      //  Console.WriteLine(ballObj.v);
             
            
        
    



                for (int i = 1; i < 8; i++)
            {
                if (ball.Bounds.IntersectsWith(arr[i].Bounds))
                {
                   /// ball.Controls.Add(arr[i]);
                    //arr[i].Location = new Point(0, 0);
                   
                   arr[i].BackColor = Color.Transparent;
                   // Collision2(ballObj, 0, ballArr[i], i);
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
         
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            eMouseX = e.X;
            eMouseY = e.Y;
            vel = trb1.Value;
           // stick.Left = (int)eMouseX;
            //stick.Top = (int)eMouseY;

            if (hit.Checked)
            {
               // ball3Obj.v = vel;
                //ball3Obj.angle = -ToRadians(trb.Value);
               // ball3tmr.Start();
              for(int i=0; i<8; i++)
                {
                   if (stick.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        ballArr[i].v = vel;//60.0;

                        ballArr[i].angle = -ToRadians(trb.Value);//(trb.Value+90);//180*Math.PI;//(trb.Value * Math.PI / 180 - Math.PI / 2) % 180;//360*2*Math.PI;//0.25*Math.PI;
                                                               //Console.WriteLine(ToRadians(90));
                        tmrArr[i].Start();
                    }
                }
                
            }

            if (isPressed)
            {
         
            
                    vel =trb1.Value;
                    stick.Left = e.X;
                     stick.Top = e.Y;
            
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

            }

        
        private void drtmr_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = Image.FromFile(@"C:\new\tranew.png");

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
          
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Pen pen = new Pen(Color.Black);
            // while (isPressed)
            //{
            int nw = 0;
            int nh = 0;
            Bitmap btm = new Bitmap(img.Width, img.Height);
            if (ang <= 90)
            {
                nw = (int)(btm.Width * Math.Cos(2 * Math.PI * ang / 360) + btm.Height * Math.Sin(2 * Math.PI * ang / 360));
                nh = (int)(btm.Height * Math.Cos(2 * Math.PI * ang / 360) + btm.Width * Math.Sin(2 * Math.PI * ang / 360));
            }
            else if(ang>90 && ang <= 180)
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
            e.Graphics.DrawImage(bit_map, -bit_map.Width/2, -bit_map.Height/2 );

          
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){

                case Keys.Right:
                    //stick.Top++;
                    stick.Left++;
                   
                    break;
                case Keys.Left:
                   // stick.Top--;
                    stick.Left--;
                    break;
                case Keys.Down:
                    stick.Top++;
                    break;
                case Keys.Up:
                    stick.Top--;
                    break;
               // case Keys.Enter:
                 //   cb.;
                  //  break;


            }
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
            ball2.Left += ball2Obj.Delta_x()/20;
            ball2.Top -= ball2Obj.Delta_y()/20;
           // while (ball2Obj.v > 0)
             //   ball2Obj.v -= Math.Abs(9.81 * k);

            for (int i = 0; i < 8; i++)
            {
                if (i != 1)
                {
                    if (ball2.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        Collision2(ball2Obj, 1, ballArr[i], i);
                       // Collision(ball2Obj, 1, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }

        }

        private void ball3tmr_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(ball3Obj.angle / Math.PI * 180);
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
                    ball3Obj.angle =( -0.5 * Math.PI +ball3Obj.angle);
                    Console.WriteLine(ball3Obj.angle / Math.PI * 180);
                }
            }

            ball3.Left += ball3Obj.Delta_x() / 20;
            ball3.Top -= ball3Obj.Delta_y() / 20;
           /// while (ball3Obj.v > 0)
              //  ball3Obj.v -= Math.Abs(9.81  * k);


            for (int i = 0; i < 8; i++)
            {
                if (i != 2)
                {
                    if (ball3.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        Collision2(ball3Obj, 2, ballArr[i], i);
                        //Collision(ball3Obj, 2, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }

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
            ball4.Left += ball4Obj.Delta_x() / 20;
            ball4.Top -= ball4Obj.Delta_y() / 20;
          //  while (ball4Obj.v > 0)
            //    ball4Obj.v -= Math.Abs(9.81  * k);



            for (int i = 0; i < 8; i++)
            {
                if (i != 3)
                {
                    if (ball4.Bounds.IntersectsWith(arr[i].Bounds))
                    {
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
            ball5.Left += ball5Obj.Delta_x() / 20;
            ball5.Top -= ball5Obj.Delta_y() / 20;
          //  while (ball5Obj.v > 0)
            //    ball5Obj.v -= Math.Abs(9.81  * k);


            for (int i = 0; i < 8; i++)
            {
                if (i != 4)
                {
                    if (ball5.Bounds.IntersectsWith(arr[i].Bounds))
                    {
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
            ball6.Left += ball6Obj.Delta_x() / 20;
            ball6.Top -= ball6Obj.Delta_y() / 20;
         //   while (ball6Obj.v > 0)
           //     ball6Obj.v -= Math.Abs(9.81 * k);


            for (int i = 0; i < 8; i++)
            {
                if (i != 5)
                {
                    if (ball6.Bounds.IntersectsWith(arr[i].Bounds))
                    {
                        Collision2(ball6Obj, 5, ballArr[i], i);
                        //Collision(ball6Obj, 5, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                }
            }
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
            ball7.Left += ball7Obj.Delta_x() / 20;
            ball7.Top -= ball7Obj.Delta_y() / 20;
         //   while (ball7Obj.v > 0)
           //     ball7Obj.v -= Math.Abs(9.81 * k);


            for (int i = 0; i < 8; i++)
            {
                if (i != 6)
                {
                    if (ball7.Bounds.IntersectsWith(arr[i].Bounds))
                    {
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
            ball8.Left += ball8Obj.Delta_x() / 20;
            ball8.Top -= ball8Obj.Delta_y() / 20;
         //   while (Math.Abs(ball8Obj.v) > 0)
           //     ball8Obj.v -= Math.Abs(9.81  * k);

            for (int i = 0; i < 8; i++)
            {
                if (i != 7)
                {
                    if (ball8.Bounds.IntersectsWith(arr[i].Bounds))
                    {
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

        private void generaltmr_Tick(object sender, EventArgs e)
        {


           

           /* for (int i = 0; i <= 7; i++)
            { 
                for (int j = 1; j <= 7; j++)
                {
                    if (arr[i].Bounds.IntersectsWith(arr[j].Bounds))//|| ball.Bounds.IntersectsWith(ball2.Bounds))
                    {
                        // ballSpeed = -ballSpeed;
                        // ball2Speed = -ball2Speed;
                        // ball2tmr.Interval = balltmr.Interval;
                        // balltmr.Interval = ball2tmr.Interval;
                        /////////////////////////////////////////////////////////////////////////////
                        temp_x = ballArr[i].Delta_x();
                        temp_y = ballArr[i].Delta_y();
                        ballArr[i].v = Math.Sqrt(Math.Pow(ballArr[j].Delta_x(), 2) + Math.Pow(ballArr[j].Delta_y(), 2));
                        if (ballArr[i].Delta_x() != 0)
                            ballArr[i].angle = Math.Tan(ballArr[i].Delta_y() / ballArr[i].Delta_x());
                        else
                            ballArr[i].angle = 0;
                        ballArr[j].v = Math.Sqrt(Math.Pow(temp_x, 2) + Math.Pow(temp_y, 2));
                        if (ballArr[j].Delta_x() != 0)
                            ballArr[j].angle = Math.Tan(ballArr[j].Delta_y() / ballArr[j].Delta_x());
                        else
                            ballArr[j].angle = 0;

                        tmrArr[j].Start();


                    } 
                  
                }
            }*/
        }
    }
}
