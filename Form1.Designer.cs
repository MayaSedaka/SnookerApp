
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbp = new System.Windows.Forms.Label();
            this.ball9 = new System.Windows.Forms.PictureBox();
            this.ball10 = new System.Windows.Forms.PictureBox();
            this.ball11 = new System.Windows.Forms.PictureBox();
            this.ball12 = new System.Windows.Forms.PictureBox();
            this.ball13 = new System.Windows.Forms.PictureBox();
            this.ball14 = new System.Windows.Forms.PictureBox();
            this.ball15 = new System.Windows.Forms.PictureBox();
            this.ball9tmr = new System.Windows.Forms.Timer(this.components);
            this.ball10tmr = new System.Windows.Forms.Timer(this.components);
            this.ball11tmr = new System.Windows.Forms.Timer(this.components);
            this.ball12tmr = new System.Windows.Forms.Timer(this.components);
            this.ball13tmr = new System.Windows.Forms.Timer(this.components);
            this.ball14tmr = new System.Windows.Forms.Timer(this.components);
            this.ball15tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ball9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball15)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(807, 386);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(37, 34);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // balltmr
            // 
            this.balltmr.Interval = 10;
            this.balltmr.Tick += new System.EventHandler(this.balltmr_Tick);
            // 
            // ball2
            // 
            this.ball2.BackColor = System.Drawing.Color.Transparent;
            this.ball2.Image = ((System.Drawing.Image)(resources.GetObject("ball2.Image")));
            this.ball2.Location = new System.Drawing.Point(737, 239);
            this.ball2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(37, 34);
            this.ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball2.TabIndex = 2;
            this.ball2.TabStop = false;
            this.ball2.Click += new System.EventHandler(this.ball2_Click);
            // 
            // ball2tmr
            // 
            this.ball2tmr.Interval = 10;
            this.ball2tmr.Tick += new System.EventHandler(this.ball2tmr_Tick);
            // 
            // generaltmr
            // 
            this.generaltmr.Tick += new System.EventHandler(this.generaltmr_Tick);
            // 
            // ball7
            // 
            this.ball7.BackColor = System.Drawing.Color.Transparent;
            this.ball7.Image = ((System.Drawing.Image)(resources.GetObject("ball7.Image")));
            this.ball7.Location = new System.Drawing.Point(807, 202);
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
            this.ball4.Location = new System.Drawing.Point(807, 464);
            this.ball4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball4.Name = "ball4";
            this.ball4.Size = new System.Drawing.Size(37, 34);
            this.ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball4.TabIndex = 4;
            this.ball4.TabStop = false;
            this.ball4.Click += new System.EventHandler(this.ball4_Click);
            // 
            // ball6
            // 
            this.ball6.BackColor = System.Drawing.Color.Transparent;
            this.ball6.Image = ((System.Drawing.Image)(resources.GetObject("ball6.Image")));
            this.ball6.Location = new System.Drawing.Point(807, 295);
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
            this.ball3.Location = new System.Drawing.Point(447, 295);
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
            this.ball5.Location = new System.Drawing.Point(677, 295);
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
            this.ball8.Location = new System.Drawing.Point(735, 369);
            this.ball8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball8.Name = "ball8";
            this.ball8.Size = new System.Drawing.Size(37, 34);
            this.ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball8.TabIndex = 8;
            this.ball8.TabStop = false;
            // 
            // ball3tmr
            // 
            this.ball3tmr.Interval = 10;
            this.ball3tmr.Tick += new System.EventHandler(this.ball3tmr_Tick);
            // 
            // ball4tmr
            // 
            this.ball4tmr.Interval = 10;
            this.ball4tmr.Tick += new System.EventHandler(this.ball4tmr_Tick);
            // 
            // ball5tmr
            // 
            this.ball5tmr.Interval = 10;
            this.ball5tmr.Tick += new System.EventHandler(this.ball5tmr_Tick);
            // 
            // ball6tmr
            // 
            this.ball6tmr.Interval = 10;
            this.ball6tmr.Tick += new System.EventHandler(this.ball6tmr_Tick);
            // 
            // ball7tmr
            // 
            this.ball7tmr.Interval = 10;
            this.ball7tmr.Tick += new System.EventHandler(this.ball7tmr_Tick);
            // 
            // ball8tmr
            // 
            this.ball8tmr.Interval = 10;
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
            this.trb1.Location = new System.Drawing.Point(447, 29);
            this.trb1.Maximum = 80;
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(327, 45);
            this.trb1.TabIndex = 16;
            this.trb1.Resize += new System.EventHandler(this.trb1_Resize);
            // 
            // hit
            // 
            this.hit.AutoSize = true;
            this.hit.BackColor = System.Drawing.Color.SkyBlue;
            this.hit.Location = new System.Drawing.Point(518, 519);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(40, 20);
            this.hit.TabIndex = 17;
            this.hit.Text = "hit";
            this.hit.UseVisualStyleBackColor = false;
            this.hit.Visible = false;
            // 
            // trb
            // 
            this.trb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trb.Location = new System.Drawing.Point(310, 200);
            this.trb.Maximum = 360;
            this.trb.Name = "trb";
            this.trb.Size = new System.Drawing.Size(327, 45);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newGameToolStripMenuItem.Text = "new game";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.homePageToolStripMenuItem.Text = "home page";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(194, 82);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(22, 16);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "v1";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbp
            // 
            this.lbp.AutoSize = true;
            this.lbp.Location = new System.Drawing.Point(109, 202);
            this.lbp.Name = "lbp";
            this.lbp.Size = new System.Drawing.Size(46, 16);
            this.lbp.TabIndex = 27;
            this.lbp.Text = "player";
            // 
            // ball9
            // 
            this.ball9.BackColor = System.Drawing.Color.Transparent;
            this.ball9.Image = ((System.Drawing.Image)(resources.GetObject("ball9.Image")));
            this.ball9.Location = new System.Drawing.Point(282, 239);
            this.ball9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball9.Name = "ball9";
            this.ball9.Size = new System.Drawing.Size(37, 34);
            this.ball9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball9.TabIndex = 28;
            this.ball9.TabStop = false;
            // 
            // ball10
            // 
            this.ball10.BackColor = System.Drawing.Color.Transparent;
            this.ball10.Image = ((System.Drawing.Image)(resources.GetObject("ball10.Image")));
            this.ball10.Location = new System.Drawing.Point(247, 464);
            this.ball10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball10.Name = "ball10";
            this.ball10.Size = new System.Drawing.Size(37, 34);
            this.ball10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball10.TabIndex = 29;
            this.ball10.TabStop = false;
            // 
            // ball11
            // 
            this.ball11.BackColor = System.Drawing.Color.Transparent;
            this.ball11.Image = ((System.Drawing.Image)(resources.GetObject("ball11.Image")));
            this.ball11.Location = new System.Drawing.Point(299, 522);
            this.ball11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball11.Name = "ball11";
            this.ball11.Size = new System.Drawing.Size(37, 34);
            this.ball11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball11.TabIndex = 30;
            this.ball11.TabStop = false;
            // 
            // ball12
            // 
            this.ball12.BackColor = System.Drawing.Color.Transparent;
            this.ball12.Image = ((System.Drawing.Image)(resources.GetObject("ball12.Image")));
            this.ball12.Location = new System.Drawing.Point(319, 126);
            this.ball12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball12.Name = "ball12";
            this.ball12.Size = new System.Drawing.Size(37, 34);
            this.ball12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball12.TabIndex = 31;
            this.ball12.TabStop = false;
            // 
            // ball13
            // 
            this.ball13.BackColor = System.Drawing.Color.Transparent;
            this.ball13.Image = ((System.Drawing.Image)(resources.GetObject("ball13.Image")));
            this.ball13.Location = new System.Drawing.Point(220, 345);
            this.ball13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball13.Name = "ball13";
            this.ball13.Size = new System.Drawing.Size(37, 34);
            this.ball13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball13.TabIndex = 32;
            this.ball13.TabStop = false;
            // 
            // ball14
            // 
            this.ball14.BackColor = System.Drawing.Color.Transparent;
            this.ball14.Image = ((System.Drawing.Image)(resources.GetObject("ball14.Image")));
            this.ball14.Location = new System.Drawing.Point(494, 369);
            this.ball14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball14.Name = "ball14";
            this.ball14.Size = new System.Drawing.Size(37, 34);
            this.ball14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball14.TabIndex = 33;
            this.ball14.TabStop = false;
            // 
            // ball15
            // 
            this.ball15.BackColor = System.Drawing.Color.Transparent;
            this.ball15.Image = ((System.Drawing.Image)(resources.GetObject("ball15.Image")));
            this.ball15.Location = new System.Drawing.Point(118, 211);
            this.ball15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball15.Name = "ball15";
            this.ball15.Size = new System.Drawing.Size(37, 34);
            this.ball15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball15.TabIndex = 34;
            this.ball15.TabStop = false;
            // 
            // ball9tmr
            // 
            this.ball9tmr.Interval = 10;
            this.ball9tmr.Tick += new System.EventHandler(this.ball9tmr_Tick);
            // 
            // ball10tmr
            // 
            this.ball10tmr.Interval = 10;
            this.ball10tmr.Tick += new System.EventHandler(this.ball10tmr_Tick);
            // 
            // ball11tmr
            // 
            this.ball11tmr.Interval = 10;
            this.ball11tmr.Tick += new System.EventHandler(this.ball11tmr_Tick);
            // 
            // ball12tmr
            // 
            this.ball12tmr.Interval = 10;
            this.ball12tmr.Tick += new System.EventHandler(this.ball12tmr_Tick);
            // 
            // ball13tmr
            // 
            this.ball13tmr.Interval = 10;
            this.ball13tmr.Tick += new System.EventHandler(this.ball13tmr_Tick);
            // 
            // ball14tmr
            // 
            this.ball14tmr.Interval = 10;
            this.ball14tmr.Tick += new System.EventHandler(this.ball14tmr_Tick);
            // 
            // ball15tmr
            // 
            this.ball15tmr.Interval = 10;
            this.ball15tmr.Tick += new System.EventHandler(this.ball15tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::snookerFormdemo.Properties.Resources.table1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 567);
            this.Controls.Add(this.ball15);
            this.Controls.Add(this.ball14);
            this.Controls.Add(this.ball13);
            this.Controls.Add(this.ball12);
            this.Controls.Add(this.ball11);
            this.Controls.Add(this.ball10);
            this.Controls.Add(this.ball9);
            this.Controls.Add(this.lbp);
            this.Controls.Add(this.lbl);
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
            this.Controls.Add(this.ball);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ball9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer balltmr;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.Timer ball2tmr;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbp;
        private System.Windows.Forms.PictureBox ball9;
        private System.Windows.Forms.PictureBox ball10;
        private System.Windows.Forms.PictureBox ball11;
        private System.Windows.Forms.PictureBox ball12;
        private System.Windows.Forms.PictureBox ball13;
        private System.Windows.Forms.PictureBox ball14;
        private System.Windows.Forms.PictureBox ball15;
        private System.Windows.Forms.Timer ball9tmr;
        private System.Windows.Forms.Timer ball10tmr;
        private System.Windows.Forms.Timer ball11tmr;
        private System.Windows.Forms.Timer ball12tmr;
        private System.Windows.Forms.Timer ball13tmr;
        private System.Windows.Forms.Timer ball14tmr;
        private System.Windows.Forms.Timer ball15tmr;
    }
}

