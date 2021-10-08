
namespace snookerFormdemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.balltmr = new System.Windows.Forms.Timer(this.components);
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.ball2tmr = new System.Windows.Forms.Timer(this.components);
            this.stick = new System.Windows.Forms.PictureBox();
            this.generaltmr = new System.Windows.Forms.Timer(this.components);
            this.ball7 = new System.Windows.Forms.PictureBox();
            this.ball4 = new System.Windows.Forms.PictureBox();
            this.ball6 = new System.Windows.Forms.PictureBox();
            this.ball3 = new System.Windows.Forms.PictureBox();
            this.ball5 = new System.Windows.Forms.PictureBox();
            this.ball8 = new System.Windows.Forms.PictureBox();
            this.ball3tmr = new System.Windows.Forms.Timer(this.components);
            this.ball4tmr = new System.Windows.Forms.Timer(this.components);
            this.ball5tmr = new System.Windows.Forms.Timer(this.components);
            this.ball6tmr = new System.Windows.Forms.Timer(this.components);
            this.ball7tmr = new System.Windows.Forms.Timer(this.components);
            this.ball8tmr = new System.Windows.Forms.Timer(this.components);
            this.drtmr = new System.Windows.Forms.Timer(this.components);
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.hit = new System.Windows.Forms.CheckBox();
            this.trb = new System.Windows.Forms.TrackBar();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.popup = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(369, 397);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(37, 34);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // balltmr
            // 
            this.balltmr.Interval = 20;
            this.balltmr.Tick += new System.EventHandler(this.balltmr_Tick);
            // 
            // ball2
            // 
            this.ball2.BackColor = System.Drawing.Color.Transparent;
            this.ball2.Image = ((System.Drawing.Image)(resources.GetObject("ball2.Image")));
            this.ball2.Location = new System.Drawing.Point(622, 178);
            this.ball2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(37, 34);
            this.ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball2.TabIndex = 2;
            this.ball2.TabStop = false;
            // 
            // ball2tmr
            // 
            this.ball2tmr.Interval = 20;
            this.ball2tmr.Tick += new System.EventHandler(this.ball2tmr_Tick);
            // 
            // stick
            // 
            this.stick.BackColor = System.Drawing.Color.Transparent;
            this.stick.Image = ((System.Drawing.Image)(resources.GetObject("stick.Image")));
            this.stick.Location = new System.Drawing.Point(109, 458);
            this.stick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stick.Name = "stick";
            this.stick.Size = new System.Drawing.Size(297, 36);
            this.stick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stick.TabIndex = 1;
            this.stick.TabStop = false;
            // 
            // generaltmr
            // 
            this.generaltmr.Tick += new System.EventHandler(this.generaltmr_Tick);
            // 
            // ball7
            // 
            this.ball7.BackColor = System.Drawing.Color.Transparent;
            this.ball7.Image = ((System.Drawing.Image)(resources.GetObject("ball7.Image")));
            this.ball7.Location = new System.Drawing.Point(705, 102);
            this.ball7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball7.Name = "ball7";
            this.ball7.Size = new System.Drawing.Size(37, 34);
            this.ball7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball7.TabIndex = 3;
            this.ball7.TabStop = false;
            // 
            // ball4
            // 
            this.ball4.BackColor = System.Drawing.Color.Transparent;
            this.ball4.Image = ((System.Drawing.Image)(resources.GetObject("ball4.Image")));
            this.ball4.Location = new System.Drawing.Point(705, 269);
            this.ball4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball4.Name = "ball4";
            this.ball4.Size = new System.Drawing.Size(37, 34);
            this.ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball4.TabIndex = 4;
            this.ball4.TabStop = false;
            // 
            // ball6
            // 
            this.ball6.BackColor = System.Drawing.Color.Transparent;
            this.ball6.Image = ((System.Drawing.Image)(resources.GetObject("ball6.Image")));
            this.ball6.Location = new System.Drawing.Point(518, 295);
            this.ball6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball6.Name = "ball6";
            this.ball6.Size = new System.Drawing.Size(37, 34);
            this.ball6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball6.TabIndex = 5;
            this.ball6.TabStop = false;
            // 
            // ball3
            // 
            this.ball3.BackColor = System.Drawing.Color.Turquoise;
            this.ball3.Image = ((System.Drawing.Image)(resources.GetObject("ball3.Image")));
            this.ball3.Location = new System.Drawing.Point(834, 357);
            this.ball3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(37, 34);
            this.ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball3.TabIndex = 6;
            this.ball3.TabStop = false;
            // 
            // ball5
            // 
            this.ball5.BackColor = System.Drawing.Color.Transparent;
            this.ball5.Image = ((System.Drawing.Image)(resources.GetObject("ball5.Image")));
            this.ball5.Location = new System.Drawing.Point(494, 153);
            this.ball5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball5.Name = "ball5";
            this.ball5.Size = new System.Drawing.Size(37, 34);
            this.ball5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball5.TabIndex = 7;
            this.ball5.TabStop = false;
            // 
            // ball8
            // 
            this.ball8.BackColor = System.Drawing.Color.Transparent;
            this.ball8.Image = ((System.Drawing.Image)(resources.GetObject("ball8.Image")));
            this.ball8.Location = new System.Drawing.Point(799, 192);
            this.ball8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball8.Name = "ball8";
            this.ball8.Size = new System.Drawing.Size(37, 34);
            this.ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball8.TabIndex = 8;
            this.ball8.TabStop = false;
            // 
            // ball3tmr
            // 
            this.ball3tmr.Interval = 20;
            this.ball3tmr.Tick += new System.EventHandler(this.ball3tmr_Tick);
            // 
            // ball4tmr
            // 
            this.ball4tmr.Interval = 20;
            this.ball4tmr.Tick += new System.EventHandler(this.ball4tmr_Tick);
            // 
            // ball5tmr
            // 
            this.ball5tmr.Interval = 20;
            this.ball5tmr.Tick += new System.EventHandler(this.ball5tmr_Tick);
            // 
            // ball6tmr
            // 
            this.ball6tmr.Interval = 20;
            this.ball6tmr.Tick += new System.EventHandler(this.ball6tmr_Tick);
            // 
            // ball7tmr
            // 
            this.ball7tmr.Interval = 20;
            this.ball7tmr.Tick += new System.EventHandler(this.ball7tmr_Tick);
            // 
            // ball8tmr
            // 
            this.ball8tmr.Interval = 20;
            this.ball8tmr.Tick += new System.EventHandler(this.ball8tmr_Tick);
            // 
            // drtmr
            // 
            this.drtmr.Tick += new System.EventHandler(this.drtmr_Tick);
            // 
            // trb1
            // 
            this.trb1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trb1.BackColor = System.Drawing.Color.Teal;
            this.trb1.Location = new System.Drawing.Point(90, 295);
            this.trb1.Maximum = 80;
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(327, 56);
            this.trb1.TabIndex = 16;
            this.trb1.Resize += new System.EventHandler(this.trb1_Resize);
            // 
            // hit
            // 
            this.hit.AutoSize = true;
            this.hit.BackColor = System.Drawing.Color.SkyBlue;
            this.hit.Location = new System.Drawing.Point(518, 519);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(45, 21);
            this.hit.TabIndex = 17;
            this.hit.Text = "hit";
            this.hit.UseVisualStyleBackColor = false;
            // 
            // trb
            // 
            this.trb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trb.Location = new System.Drawing.Point(90, 438);
            this.trb.Maximum = 360;
            this.trb.Name = "trb";
            this.trb.Size = new System.Drawing.Size(327, 56);
            this.trb.TabIndex = 18;
            this.trb.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.p2.BackColor = System.Drawing.Color.Maroon;
            this.p2.Location = new System.Drawing.Point(412, 464);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(58, 51);
            this.p2.TabIndex = 19;
            this.p2.TabStop = false;
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.Maroon;
            this.p6.Location = new System.Drawing.Point(90, 86);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(63, 52);
            this.p6.TabIndex = 20;
            this.p6.TabStop = false;
            // 
            // p5
            // 
            this.p5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p5.BackColor = System.Drawing.Color.Maroon;
            this.p5.Location = new System.Drawing.Point(417, 51);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(53, 47);
            this.p5.TabIndex = 21;
            this.p5.TabStop = false;
            // 
            // p4
            // 
            this.p4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p4.BackColor = System.Drawing.Color.Maroon;
            this.p4.Location = new System.Drawing.Point(727, 82);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(62, 50);
            this.p4.TabIndex = 22;
            this.p4.TabStop = false;
            // 
            // p3
            // 
            this.p3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p3.BackColor = System.Drawing.Color.Maroon;
            this.p3.Location = new System.Drawing.Point(727, 428);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(62, 54);
            this.p3.TabIndex = 23;
            this.p3.TabStop = false;
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1.BackColor = System.Drawing.Color.Maroon;
            this.p1.Location = new System.Drawing.Point(90, 428);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(63, 65);
            this.p1.TabIndex = 24;
            this.p1.TabStop = false;
            // 
            // popup
            // 
            this.popup.Location = new System.Drawing.Point(23, 1);
            this.popup.Name = "popup";
            this.popup.Size = new System.Drawing.Size(75, 23);
            this.popup.TabIndex = 25;
            this.popup.Text = "button1";
            this.popup.UseVisualStyleBackColor = true;
            this.popup.Click += new System.EventHandler(this.popup_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.homePageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.newGameToolStripMenuItem.Text = "new game";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.homePageToolStripMenuItem.Text = "home page";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(90, 153);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(259, 118);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 26;
            this.pic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::snookerFormdemo.Properties.Resources.table1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 567);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.popup);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.trb);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.trb1);
            this.Controls.Add(this.ball8);
            this.Controls.Add(this.ball5);
            this.Controls.Add(this.ball3);
            this.Controls.Add(this.ball6);
            this.Controls.Add(this.ball4);
            this.Controls.Add(this.ball7);
            this.Controls.Add(this.ball2);
            this.Controls.Add(this.stick);
            this.Controls.Add(this.ball);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer balltmr;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.Timer ball2tmr;
        private System.Windows.Forms.PictureBox stick;
        private System.Windows.Forms.Timer generaltmr;
        private System.Windows.Forms.PictureBox ball7;
        private System.Windows.Forms.PictureBox ball4;
        private System.Windows.Forms.PictureBox ball6;
        private System.Windows.Forms.PictureBox ball3;
        private System.Windows.Forms.PictureBox ball5;
        private System.Windows.Forms.PictureBox ball8;
        private System.Windows.Forms.Timer ball3tmr;
        private System.Windows.Forms.Timer ball4tmr;
        private System.Windows.Forms.Timer ball5tmr;
        private System.Windows.Forms.Timer ball6tmr;
        private System.Windows.Forms.Timer ball7tmr;
        private System.Windows.Forms.Timer ball8tmr;
        private System.Windows.Forms.Timer drtmr;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.CheckBox hit;
        private System.Windows.Forms.TrackBar trb;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Button popup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer timer1;
    }
}

