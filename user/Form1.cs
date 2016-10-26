using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace BTP
{
    public partial class Form1 : Form
    {
        PictureBox balloon;
        public Form1()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.speedup = new System.Windows.Forms.PictureBox();
            this.user1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speedup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // speedup
            // 
            this.speedup.Image = global::BTP.Properties.Resources.k16315978;
            this.speedup.Location = new System.Drawing.Point(300, 300);
            this.speedup.Name = "speedup";
            this.speedup.Size = new System.Drawing.Size(60, 60);
            this.speedup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speedup.TabIndex = 1;
            this.speedup.TabStop = false;
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.Color.Transparent;
            this.user1.Image = global::BTP.Properties.Resources.F;
            this.user1.Location = new System.Drawing.Point(46, 51);
            this.user1.Margin = new System.Windows.Forms.Padding(0);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(60, 60);
            this.user1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user1.TabIndex = 0;
            this.user1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Controls.Add(this.speedup);
            this.Controls.Add(this.user1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keydown);
            ((System.ComponentModel.ISupportInitialize)(this.speedup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }
        public struct user
        {
            public int fast, num, width, top, left;
            public user(int speed, int Maxinum_balloon_num, int explosion_width, int userX, int userY)
            {
                fast = speed;
                num = Maxinum_balloon_num;
                width = explosion_width;
                top = userY;
                left = userX;
            }
        }

        public void keydown(object sender, PreviewKeyDownEventArgs e)
        {
            user userA = new user(10, 1, 1, 50, 50);
            int[,] game = new int[15, 15];
            if (e.KeyCode == Keys.Left)
            {
                user1.Location = new System.Drawing.Point(user1.Left- userA.fast , user1.Top);
                if (user1.Left < 0)
                {
                    user1.Left += userA.fast;
                }
                this.user1.Image = global::BTP.Properties.Resources.r;
            }
            else if (e.KeyCode == Keys.Right)
            {
                user1.Location = new System.Drawing.Point(user1.Left + userA.fast, user1.Top);
                if (user1.Left > 900)
                {
                    user1.Left -= userA.fast;
                }
                this.user1.Image = global::BTP.Properties.Resources.l;

            }
            else if (e.KeyCode == Keys.Up)
            {
                user1.Location = new System.Drawing.Point(user1.Left, user1.Top - userA.fast);
                if (user1.Top < 0)
                {
                    user1.Top += userA.fast;
                }
                this.user1.Image = global::BTP.Properties.Resources.B;

            }
            else if (e.KeyCode == Keys.Down)
            {
                user1.Location = new System.Drawing.Point(user1.Left, user1.Top + userA.fast);
                if (user1.Top > 900)
                {
                    user1.Top -= userA.fast;
                }
                this.user1.Image = global::BTP.Properties.Resources.F;

            }
            else if (e.KeyCode == Keys.Space)
            {
                if (game[user1.Left / 60, user1.Top / 60] == 15611)
                {

                }
                else
                {
                    balloon = new PictureBox();
                    System.Windows.Forms.Timer timer_A = new System.Windows.Forms.Timer();
                    timer_A.Interval = 3000;
                    timer_A.Tick += new EventHandler(timer_A_Tick);
                    balloon.Location = new System.Drawing.Point((user1.Left / 60) * 60, (user1.Top / 60) * 60);
                    balloon.Image = global::BTP.Properties.Resources.ezgif_1448237685;
                    balloon.Size = new System.Drawing.Size(60, 60);
                    balloon.Margin = new System.Windows.Forms.Padding(0);
                    balloon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    balloon.Visible = true;
                    game[user1.Left / 60, user1.Top / 60] = 15611;
                    Controls.Add(balloon);
                    timer_A.Start();
                }
                //타이머 종료후 풍선 터짐
            }
            userA.top = user1.Top;
            userA.left = user1.Left;
           
            if ((user1.Top / 60) * 60 == 300 && (user1.Left / 60) * 60 == 300)
            {
               
                userA.fast += 20;
                Console.WriteLine("{0}", userA.fast);
            }
        }
        public void timer_A_Tick(object sender, EventArgs e)
        {
            balloon.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
}
   
}