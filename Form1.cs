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
        public static double k;
     
        public static int left = 60;
        public static int right = 1480;
        public static int top = 60;
        public static int bottom = 720;
        bool isPressed = false;
        public double[,] dis = new double[8,6];
        public static PictureBox[] arr = new PictureBox[8];
        public static PictureBox[] holes = new PictureBox[6];
        public static Ball[] ballArr = new Ball[8];
        public static Timer[] tmrArr = new Timer[15];
        public static Ball[] striped = new Ball[7];
        public static PictureBox[] arrst = new PictureBox[7];
        
        Ball ballObj = new Ball(2);
        Ball ball2Obj = new Ball(2);
        Ball ball3Obj = new Ball(2);
        Ball ball4Obj = new Ball(2);
        Ball ball5Obj = new Ball(2);
        Ball ball6Obj = new Ball(2);
        Ball ball7Obj = new Ball(2);
        Ball ball8Obj = new Ball(2);

        Ball ball9Obj = new Ball(2);
        Ball ball10Obj = new Ball(2);
        Ball ball11Obj = new Ball(2);
        Ball ball12Obj = new Ball(2);
        Ball ball13Obj = new Ball(2);
        Ball ball14Obj = new Ball(2);
        Ball ball15Obj = new Ball(2);
    
        float vel;
        Boolean player;//computer-false, person-true
        Boolean f= false;
        int ang;
        int x, y;
        int h, b;
        Boolean flag=true;
        public static SoundPlayer so = new SoundPlayer(@"C:\new\sound2.WAV");
      
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
            k = 0.43;

            striped[0] = ball9Obj;
            striped[1] = ball10Obj;
            striped[2] = ball11Obj;
            striped[3] = ball12Obj;
            striped[4] = ball13Obj;
            striped[5] = ball14Obj;
            striped[6] = ball15Obj;

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

            arrst[0] = ball9;
            arrst[1] = ball10;
            arrst[2] = ball11;
            arrst[3] = ball12;
            arrst[4] = ball13;
            arrst[5] = ball14;
            arrst[6] = ball15;


            tmrArr[0] = balltmr;
            tmrArr[1] = ball2tmr;
            tmrArr[2] = ball3tmr;
            tmrArr[3] = ball4tmr;
            tmrArr[4] = ball5tmr;
            tmrArr[5] = ball6tmr;
            tmrArr[6] = ball7tmr;
            tmrArr[7] = ball8tmr;
            tmrArr[8] = ball9tmr;
            tmrArr[9]= ball10tmr;
            tmrArr[10] = ball11tmr;
            tmrArr[11] = ball12tmr;
            tmrArr[12] = ball13tmr;
            tmrArr[13] = ball14tmr;
            tmrArr[14] = ball15tmr;
            
            MessageBox.Show("Welcome! Press OK to start :)");

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
        public Boolean ballsInTheWay(int h, int b)
        {

            for (int i = 0; i < 8; i++)
            {
                if (i != 2 && i != b)
                {
                    /* if (angleBetweenBalls(i,2) - angleBetweenBalls((int)closeFromHole()[1],i) >= 0 &&
                         angleBetweenBalls(i, 2) - angleBetweenBalls((int)closeFromHole()[1], i) <= 3)*/
                    if (isInTolerance(Math.Abs(angleBetweenBalls(i, 2)-(int)(angleBetweenBalls((int)closeFromHole()[1], i) )), 0.2))
                    {
                        ball7.BackColor = Color.Black;
                        if (disFromHole(arr[i], holes[h]) < disFromHole(arr[2], holes[h]) && isOnLine((int)closeFromHole()[2], i, ball3.Left, ball3.Top))
                        {
                            arr[i].BackColor = Color.Coral;
                            lbl.Text = "" + i;
                            arr[(int)closeFromHole()[1]].BackColor = Color.White;
                            return true;
                        }
                    }
                }
            }
            return false;

        }
        public static double disFromHole(PictureBox ball, PictureBox hole)
        {
            return Math.Sqrt(Math.Pow(ball.Left - hole.Left, 2) + Math.Pow(ball.Top - hole.Top, 2));
        }

        public void updateDisArray()
        {
            for(int i=0; i<8; i++)
            {
                for(int j=0; j<6; j++)
                {
                    dis[i, j] = disFromHole(arr[i], holes[j]);
                }
            }
        }
        public  double[] closeFromHole()
        {
           
            double min = dis[0, 0],b,h;
            double[] sol = new double[4];
            for (int i=0; i<8; i++)
            {
                for (int j=1;j<6; j++)
                {
                    if (dis[i, j] < min)
                    {
                        if(isAngleToHole(i,j))
                           min = dis[i, j];
                        b = i;
                        h = j;
                        sol[0] = min;
                        sol[1] = b;
                        sol[2] = h;
                        sol[3] = Math.Atan2( (holes[(int)h].Top - arr[(int)b].Top), (holes[(int)h].Left - arr[(int)b].Left))+Math.PI;
                    }
                }
            }
            return sol;
        }
        public double angleBetweenBalls(int b1, int b2)
        {
            return (Math.Atan2((arr[b1].Top - arr[b2].Top) ,(arr[b1].Left - arr[b2].Left)) + Math.PI)%360;
        }
        public Boolean isInTolerance(double x, double y)
        {
            return (x >= 0 && x <= y);
        }
        public Boolean isAngleToHole(int b, int h)
        {
            return (isInTolerance(Math.Abs(Math.Atan2( (holes[h].Top - arr[b].Top),(holes[h].Left - arr[b].Left))+Math.PI -
                Math.Atan2((-arr[b].Top + ball3.Top), (-arr[b].Left+ ball3.Left))+Math.PI),3));
        }
        public Boolean isOnLine( int b1, int b2, int x, int y)
        {
            double m = (holes[b1].Top - arr[b2].Top) / (holes[b1].Left - arr[b2].Left);
            double b = holes[b1].Top - m * holes[b1].Left;
            return y == m * x + b||isInTolerance(y, (int)(m * x + b+5))|| isInTolerance(y, (int)(m * x + b - 5));
        }

        public static void Collision2(Ball b1, int i, Ball b2, int j)
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

                    b1.angle = Math.Atan2(vy1f ,vx1f);
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

                    b2.angle = Math.Atan2(vy2f ,vx2f);
            }
            else
                b2.angle = Math.PI / 2;
        }


        public static void Collision2Striped1(Ball b1, int i, Ball b2, int j)
        {

            int dx = arrst[j].Left - arrst[i].Left;
            int dy = arrst[j].Top - arrst[i].Top;
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
            double vx1f = vx1final * cos - vy1final * sin;
            // double vx1f = vx1final * c - vx1final * s;
            double vy1f = vy1final * cos + vx1final * sin;
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

                    b1.angle = Math.Atan2(vy1f, vx1f);
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

                    b2.angle = Math.Atan2(vy2f, vx2f);
            }
            else
                b2.angle = Math.PI / 2;
        }
        public static void Collision2Striped2(Ball b1, int i, Ball b2, int j)
        {
            arr[5].BackColor = Color.Purple;
            int dx = arrst[j].Left - arr[i].Left;
            int dy = arrst[j].Top - arr[i].Top;
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
            double vx1f = vx1final * cos - vy1final * sin;
            // double vx1f = vx1final * c - vx1final * s;
            double vy1f = vy1final * cos + vx1final * sin;
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

                    b1.angle = Math.Atan2(vy1f, vx1f);
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

                    b2.angle = Math.Atan2(vy2f, vx2f);
            }
            else
                b2.angle = Math.PI / 2;
        }

        public static void Collision2Striped3(Ball b1, int i, Ball b2, int j)
        {

            int dx = arr[j].Left - arrst[i].Left;
            int dy = arr[j].Top - arrst[i].Top;
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
            double vx1f = vx1final * cos - vy1final * sin;
            // double vx1f = vx1final * c - vx1final * s;
            double vy1f = vy1final * cos + vx1final * sin;
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

                    b1.angle = Math.Atan2(vy1f, vx1f);
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

                    b2.angle = Math.Atan2(vy2f, vx2f);
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

            general.generalTmrFun(0);

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
            Boolean f=true;
            player = true;
            ball5.BackColor = Color.Transparent;

            Pen blackPen = new Pen(Color.Black, 3);
            if (ball3Obj.v == 0)
            {
                // Create pen.

               
                // Create points that define line.
                if (!player)

                {

                    for (int i = 0; i < 8; i++)
                    {
                        if (isAngleToHole((int)(closeFromHole()[1]), (int)(closeFromHole()[2]))
                            && closeFromHole()[1] != 2 && !ballsInTheWay((int)(closeFromHole()[2]), (int)(closeFromHole()[1])))
                           // && isOnLine((int)(closeFromHole()[2]), (int)(closeFromHole()[1]), ball3.Left, ball3.Top))

                        {
                            //האם הזווית בין הקרוב לחור לחור שווה לזווית בין הכדור הלבן לכדור הקרוב לחור
                            arr[(int)(closeFromHole()[1])].BackColor = Color.Brown;
                            PointF point1 = new PointF((float)(ball3.Left + 13), (float)(ball3.Top + 13));
                            PointF point2 = new PointF((float)(arr[(int)closeFromHole()[1]].Left), (float)(arr[(int)closeFromHole()[1]].Top));
                            e.Graphics.DrawLine(blackPen, point1, point2);
                            ball3Obj.angle = -Math.Atan2(point2.Y - point1.Y, point2.X - point1.X); //angleBetweenBalls(2, (int)closeFromHole()[1])+Math.PI;
                            ball3Obj.v = 200;
                            ball3tmr.Start();
                            arr[(int)(closeFromHole()[1])].BackColor = Color.Transparent;
                            // arr[(int)(closeFromHole()[1])].BackColor = Color.Transparent;

                        }
                        else
                        {
                            dis[(int)(closeFromHole()[1]), (int)(closeFromHole()[2])] = 100000;
                        }
                    }
                    ball5.BackColor = Color.Blue;
                    updateDisArray();
                  
                        
                            for (int i = 0; i < 8; i++)
                            {
                                if (i != 2)
                                {
                                    if (closeFromHole()[3] == angleBetweenBalls((int)(closeFromHole()[1]), i))
                                    {
                                         ball6.BackColor = Color.Azure;
                                        //האם הזווית בין הקרוב לחור לאחד הכדורים שוה לזווית בין הקרוב לחור לחור
                                        if (angleBetweenBalls(i, 2) == angleBetweenBalls((int)(closeFromHole()[1]), i)
                                            && isOnLine((int)(closeFromHole()[2]), (int)(closeFromHole()[1]), ball3.Left, ball3.Top))

                                        {
                                            //האם בין הלבן גם שווה
                                            ball4.BackColor = Color.Yellow;
                                            PointF point1 = new PointF((float)(ball3.Left + 13), (float)(ball3.Top + 13));
                                            PointF point2 = new PointF((float)(arr[i].Left), (float)(arr[i].Top));
                                            e.Graphics.DrawLine(blackPen, point1, point2);
                                            ball3Obj.angle = angleBetweenBalls(2, i);
                                            ball3Obj.v = 100;
                                            ball3tmr.Start();
                                            f = false;
                                        updateDisArray();


                                        }
                                  
                                        
                                        //לנסות להמשיך לעבור על הכדורים לפי מי שהכי קרוב ואז זה שאחריו וכו ולבדוק האם התנאי מתקיים

                                    
                                
                            }
                        }
                              
                        
                            dis[(int)(closeFromHole()[1]), (int)(closeFromHole()[2])] = 100000;
                        
                    }


                    //double min = dis[0,0];
                    /* for (int i = 0; i < 8; i++)
                     {
                         if (i != 2)
                         {
                             for (int j = 1; j < 6;j++) {

                                 {

                                     /*if (((dis[i, j] < min) &&
                                          (Math.Atan(Math.Abs((arr[i].Top - ball3.Top / arr[i].Left - ball3.Left)) -
                                          Math.Atan(holes[j].Top - arr[i].Top / holes[j].Left - arr[i].Left))) <= 5 ||
                                          (Math.Atan(Math.Abs((arr[i].Top - ball3.Top / arr[i].Left - ball3.Left)) -
                                          Math.Atan(holes[j].Top - arr[i].Top / holes[j].Left - arr[i].Left)) <= 5))
                                          &&(arr[i].Left>60&&arr[i].Left<1480&&arr[i].Top>60&& arr[i].Top<720)) {//||(dis[i, j] < min)) {
                                         // Console.WriteLine("b:"+i +" h: "+j);
                                         Console.WriteLine("nnnnnnnnnnnnnn");
                                             min = dis[i, j];
                                             b = i;
                                             h = j;
                                             ball.BackColor=Color.White;

                                         }

                                     }

                                // player = true;
                                 }

                             }*/
                 
                    x = ball3.Left;
                  //  player = true;
                   // flag = true;

                }




                /*  ball3Obj.v = Math.Sqrt(Math.Pow((arr[b].Left - ball3.Left + 13), 2) + Math.Pow((arr[b].Left - ball3.Top + 13), 2)) /3.5;
                  ball3Obj.angle = -Math.Atan2((arr[b].Top - ball3.Top + 13), (arr[b].Left - ball3.Left + 13));//-Math.PI/2;
                  ball3tmr.Start();*/





                else if (player )
                {
                    PointF point1 = new PointF((float)(ball3.Left + 13), (float)(ball3.Top + 13));
                    PointF point2 = new PointF((float)(eMouseX), (float)(eMouseY));
                    e.Graphics.DrawLine(blackPen, point1, point2);
                    // player = true;
                }           // Draw line to screen.

                if (isPressed)
                {
                    if (player)
                    {
                        ball3Obj.v = Math.Sqrt(Math.Pow((eMouseX - ball3.Left + 13), 2) + Math.Pow((eMouseY - ball3.Top + 13), 2)) / 3;

                        ball3Obj.angle = -Math.Atan2((eMouseY - ball3.Top + 13), (eMouseX - ball3.Left + 13));// -2.5*Math.PI;
                        lbl.Text = "" + ball3Obj.angle / Math.PI * 180;                                                                                      // Console.WriteLine(ball3Obj.angle);
                        ball3tmr.Start();
                        flag = false;
                    }





                }
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
            general.generalTmrFun(1);

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
                
                    ball3tmr.Stop();
                    String message = "GAME OVER!";
                    
                    MessageBox.Show(message);
                   // if(MessageBoxButtons.OK.Equals(true))
                    this.Close();
                }
                else
                {
                   // ball3Obj.v = ball3Obj.v * -1;
                   // ball3.BackColor = Color.Black;
                    if (ball3Obj.angle != 0&& ball3Obj.angle!=Math.PI)
                        ball3Obj.angle = (-0.5 * Math.PI + ball3Obj.angle);
                    else
                        ball3Obj.angle = ball3Obj.angle + Math.PI;
                            
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
               
                
                    if (ball3.Bounds.IntersectsWith(arr[i].Bounds)&&i!=2)
                    {
                        

                        so.Play();
                        Collision2(ball3Obj, 2, ballArr[i], i);
                        //Collision(ball3Obj, 2, ballArr[i], i);

                        tmrArr[i].Start();
                    }
                    else if(i!=7&& ball3.Bounds.IntersectsWith(arrst[i].Bounds)){
                        so.Play();
                        Collision2Striped2(ball3Obj, 2, striped[i], i);
                        //Collision(ball3Obj, 2, ballArr[i], i);
                        tmrArr[i+8].Start();
                    }
                
            }
            /* if (!ball3.Visible)
             {
                 p2.BackColor = Color.White;
                this.Refresh();
                 ball3.Show();
             }*/
            /*  if (ball3Obj.v <= 0 &&!player)
              {
                      player = true;
                     // timer2.Start();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                     ball3tmr.Stop();


             }*/
            /*else*/
            if (ball3Obj.v <= 0 && player)
            {
               player = false;
                ball3tmr.Stop();

            }
            else if (ball3Obj.v <= 0)
            {
              player = true;
                ball3tmr.Stop();
            }
        }

        private void ball4tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFun(3);

        }

        private void ball5tmr_Tick(object sender, EventArgs e)
        {

            general.generalTmrFun(4);
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
            general.generalTmrFun(5);
        }

        private void ball2_Click(object sender, EventArgs e)
        {

        }

        private void ball4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void ball7tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFun(6);
        }

        private void ball8tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFun(7);
        }

        private void ball9tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(0);
        }

        private void ball10tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(1);
        }


        private void ball11tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(2);
        }
        private void ball12tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(3);
        }
        private void ball13tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(4);
        }

        private void ball14tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(5);
        }

        private void ball15tmr_Tick(object sender, EventArgs e)
        {
            general.generalTmrFunStriped(6);
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    dis[i, j] = disFromHole(arr[i], holes[j]);
                }
            }
            // int /*dis = p3.Left- ball.Left*/ //temp=0, b=0, h=0;
            double min = dis[0,0];
            for(int i=0; i<8; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    if (dis[i, j] < min)
                    {
                        if (Math.Atan( (arr[i].Top - ball3.Top/arr[i].Left - ball3.Left) ) ==
                            Math.Atan(holes[j].Top / arr[i].Top/holes[j].Left - arr[i].Left ))
                        {
                            min = dis[i, j];
                            b = i;
                            h = j;
                            lbl.Text = "" + b;
                        }
                    }
                }
                   /* if (i != 2)
                    {
                         temp= holes[j].Left-arr[i].Left;
                        if (temp<dis)
                        {
                            b = i;
                            h = j; 
                        }
                    }
                }*/

               
            }
            //arr[b].BackColor = Color.Red;
            /* ballArr[b].v = 70;
             double a = Math.Atan2((arr[b].Top - holes[h].Top), (arr[b].Left - holes[h].Left));
             ballArr[b].angle =a;
             Console.WriteLine(ballArr[b].angle);
             tmrArr[b].Start();*/
           // ball3Obj.v = 70;
           // ball3Obj.angle = Math.Atan((arr[b].Top - ball3.Top / arr[b].Left - ball3.Left));
           // ball3tmr.Start();
            timer2.Stop();
           /* if (ballArr[b].v < 5)
            {
               
                player = true;
            }*/
        }

        private void generaltmr_Tick(object sender, EventArgs e)
        {
            updateDisArray();

            this.Invalidate();
            if (!player)
            {
               
                lbp.Text = ""+player;
                //timer2.Start();
            }
           
        }
    

    }
    }