using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Timers;

namespace newuser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class hero
    {
        private PictureBox pb_hero;//사용자 캐릭터
        private Control Parent;//?
        private Thread th_key_handler;//?

        private int i_x;//내좌표
        private int i_y;
        private int level;
        private int speed;

        private int i_max_bubble;//버블길이
        private int i_cur_bubble;//버블갯수

        public static bool b_KEY_UP;//키
        public static bool b_KEY_DOWN;
        public static bool b_KEY_LEFT;
        public static bool b_KEY_RIGHT;
        public bool b_MOVING;

        public hero(Control c_par)
        {


            i_x = 0;//맵에따라 위치설정
            i_y = 0;

            i_max_bubble = 2;
            i_cur_bubble = 0;
            b_KEY_UP = false;
            b_KEY_DOWN = false;
            b_KEY_LEFT = false;
            b_KEY_RIGHT = false;
            b_MOVING = false;

            pb_hero = new PictureBox();
            pb_hero.Location = new Point(25, 25);
            pb_hero.Size = new Size(50, 50);
            pb_hero.Image = Properties.Resources.pika;
            pb_hero.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_hero.Visible = true;
            c_par.Controls.Add(pb_hero);
            th_key_handler = new Thread(new ThreadStart(key_handler));
            th_key_handler.Start();
            Parent = c_par;
        }

        public void Dispose()
        {
            th_key_handler.Abort();
        }

        private void key_handler()
        {
            try
            {
                while (true)
                {
                    if (b_KEY_UP == true && i_y > 0)
                    {
                        for (int i = 0; i <= (Parent.Size.Height - pb_hero.Size.Height - 100) / 15; i++)
                        {
                            pb_hero.Location = new Point(pb_hero.Location.X, pb_hero.Location.Y - 1);
                            Delay(1000000);
                        }
                        i_y--;
                    }
                    if (b_KEY_LEFT == true && i_x > 0)
                    {
                        for (int i = 0; i <= (Parent.Size.Width - pb_hero.Size.Width - 100) / 15; i++)
                        {
                            pb_hero.Location = new Point(pb_hero.Location.X - 1, pb_hero.Location.Y);
                            Delay(1000000);
                        }
                        i_x--;
                    }
                    if (b_KEY_DOWN == true && i_y < 15)
                    {
                        for (int i = 0; i <= (Parent.Size.Height - pb_hero.Size.Height - 100) / 15; i++)
                        {
                            pb_hero.Location = new Point(pb_hero.Location.X, pb_hero.Location.Y + 1);
                            Delay(1000000);
                        }
                        i_y++;
                    }
                    if (b_KEY_RIGHT == true && i_x < 15)
                    {
                        for (int i = 0; i <= (Parent.Size.Width - pb_hero.Size.Width - 100) / 15; i++)
                        {
                            pb_hero.Location = new Point(pb_hero.Location.X + 1, pb_hero.Location.Y);
                            Delay(1000000);
                        }
                        i_x++;
                    }
                    int i_delay=0;
                    Delay(i_delay * 100);//??
                }
            }
            catch { }
        }

        private void Delay(int i_i)
        {
            int i_n = 0;
            while (i_n++ < i_i) ;
        }

        public int get_x() { return i_x; }
        public int get_y() { return i_y; }
        public void set_x(int _i_x) { i_x = _i_x; }
        public void set_y(int _i_y) { i_y = _i_y; }
    }

    public class bubble
    {
        private PictureBox bp_bubble;
        public bubble()
        {
            bp_bubble = new PictureBox();
            bp_bubble.Location = new System.Drawing.Point(0, 0);
            bp_bubble.Image = global::newuser.Properties.Resources.ezgif_1448237685;
            bp_bubble.Size = new System.Drawing.Size(60, 60);
            bp_bubble.Margin = new System.Windows.Forms.Padding(0);
            bp_bubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            bp_bubble.Visible = true;
            bp_bubble.Controls.Add(bp_bubble);
        }
        public void timer1()
        {
            System.Windows.Forms.Timer timer_A = new System.Windows.Forms.Timer();
            timer_A.Interval = 2000;
            timer_A.Tick += new EventHandler(timer_A_Tick);
        }
        public void timer_A_Tick(object sender, EventArgs e)
        {
            bp_bubble.Visible = false;
            //터지는 이펙트
            //종료
        }
    }
}