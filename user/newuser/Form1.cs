﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace newuser
{
    public partial class Form1 : Form
    {
        int[,] arr = new int[15, 15] {
            { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
            { 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 0 ,0 },
            { 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
            };//맵의 블럭 유무상태
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList list = new ArrayList();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                inputdata temp = list[0] as inputdata;
                if (temp.key == e.KeyCode)
                {
                    if (temp.stat != 1)
                    {
                        temp.stat = 1;
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                inputdata temp = list[1] as inputdata;
                if (temp.key == e.KeyCode)
                {
                    if (temp.stat != 1)
                    {
                        temp.stat = 1;
                    }
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                inputdata temp = list[2] as inputdata;
                if (temp.key == e.KeyCode)
                {
                    if (temp.stat != 1)
                    {
                        temp.stat = 1;
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                inputdata temp = list[3] as inputdata;
                if (temp.key == e.KeyCode)
                {
                    if (temp.stat != 1)
                    {
                        temp.stat = 1;
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                inputdata temp = list[4] as inputdata;
                if (temp.key == e.KeyCode)
                {
                    if (temp.stat != 1)
                    {
                        temp.stat = 1;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            inputdata data = new inputdata();//list 배열에 동적으로 inputdata타입인 data를 초기화 후 추가함
            data.key = Keys.Space;//각각의 data는 키값과 상태변수를 가지고있음
            data.stat = 0;
            list.Add(data);

            data = new inputdata();
            data.key = Keys.Right;
            data.stat = 0;
            list.Add(data);

            data = new inputdata();
            data.key = Keys.Left;
            data.stat = 0;
            list.Add(data);

            data = new inputdata();
            data.key = Keys.Up;
            data.stat = 0;
            list.Add(data);

            data = new inputdata();
            data.key = Keys.Down;
            data.stat = 0;
            list.Add(data);

            hero myhero = new hero(this);//hero클래스의 객체로 myhero선언 인자값은 이벤트를 받기위한 form1(this)
            timer1.Interval = 50;//물풍선 타이머를 설정할 옵션들
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)//타이머가 다 될 경우
        {
            for (int i = 0; i < list.Count; i++)
            {
                inputdata temp = list[i] as inputdata;//각각의 키값과 상태를 저장할 temp객체
                inputdata temp1 = list[1] as inputdata;
                inputdata temp2 = list[2] as inputdata;
                inputdata temp3 = list[3] as inputdata;
                inputdata temp4 = list[4] as inputdata;
                if (temp.key == Keys.Space)
                {
                    if (temp.stat == 1)
                    {
                        bubble balloon = new bubble(this);
                        Console.Write("guud");
                    }
                }

                else if (temp.key == Keys.Right && (temp3.stat != 1 && temp4.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                        //hero.pb_hero.Image = Properties.Resources.B;

                    }
                }

                else if (temp.key == Keys.Left && (temp3.stat != 1 && temp4.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                        //hero.pb_hero.Image = Properties.Resources.B;
                    }
                }

                else if (temp.key == Keys.Up && (temp1.stat != 1 && temp2.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y - hero.speed);
                        hero.pb_hero.Image = Properties.Resources.B;
                    }
                }

                else if (temp.key == Keys.Down && (temp1.stat != 1 && temp2.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y + hero.speed);
                        hero.pb_hero.Image = Properties.Resources.F;
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)//키를 누른후 뗄 경우 키값의 상태를 눌리지 않음으로 전환
        {
            if (e.KeyCode == Keys.Space)
            {
                inputdata data = list[0] as inputdata;
                data.stat = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                inputdata data = list[1] as inputdata;
                data.stat = 0;
            }

            else if (e.KeyCode == Keys.Left)
            {
                inputdata data = list[2] as inputdata;
                data.stat = 0;
            }

            else if (e.KeyCode == Keys.Up)
            {
                inputdata data = list[3] as inputdata;
                data.stat = 0;
            }

            else if (e.KeyCode == Keys.Down)
            {
                inputdata data = list[4] as inputdata;
                data.stat = 0;
            }
        }
    }

    class inputdata
    {
        public Keys key { get; set; }
        public int stat { get; set; }
    }

    public class hero
    {
        public static PictureBox pb_hero;//사용자 캐릭터

        public int key;
        public int i_x;//내좌표
        public int i_y;
        public int level = 2;//상태레벨
        public static int speed = 10;//이동속도
        public int i_max_bubble = 1;//버블길이
        public int i_cur_bubble = 1;//버블갯수

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
            pb_hero.Image = Properties.Resources.F;
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
                    int i_delay = 0;
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
        public PictureBox bp_bubble;
        public PictureBox pb_bubble;
        System.Windows.Forms.Timer timer_A;
        public bubble(Control fuck)
        {
            //bp_bubble = new PictureBox();
            pb_bubble = new PictureBox();

            timer_A = new System.Windows.Forms.Timer();
            timer_A.Interval = 2000;
            timer_A.Tick += new EventHandler(timer_A_Tick);

            //bp_bubble.Location = new System.Drawing.Point(100, 100);
            //bp_bubble.Image = Properties.Resources.bubble;
            //bp_bubble.Size = new System.Drawing.Size(60, 60);
            //bp_bubble.Margin = new System.Windows.Forms.Padding(0);
            //bp_bubble.SizeMode = PictureBoxSizeMode.StretchImage;
            //bp_bubble.Visible = true;


            pb_bubble.Location = new Point(100, 100);
            pb_bubble.Image = global::newuser.Properties.Resources.bubble;
            pb_bubble.Size = new System.Drawing.Size(60, 60);
            pb_bubble.Margin = new System.Windows.Forms.Padding(0);
            pb_bubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_bubble.Visible = true;
            
            //bp_bubble.Controls.Add(pb_bubble);
            timer_A.Start();

        }
        public void timer_A_Tick(object sender, EventArgs e)
        {
            //물풍선갯수 감소 (i_cur_bubble
            //터지는 이펙트ㄱ
            //터지는것기준으로 양옆 i_max_bubble만큼 픽쳐박스생성
            //충돌판정필요
            //종료
        }
    }
}