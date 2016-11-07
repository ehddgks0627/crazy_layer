using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace newuser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static PictureBox[,] Bubbles = new PictureBox[15, 15];
        ArrayList list = new ArrayList();
        ArrayList midlist = new ArrayList();
        static ArrayList lastlist = new ArrayList();
        static int x, y;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            inputdata list1 = list[1] as inputdata;
            inputdata list2 = list[2] as inputdata;
            inputdata list3 = list[3] as inputdata;
            inputdata list4 = list[4] as inputdata;
            inputdata midlist1 = midlist[1] as inputdata;
            inputdata midlist2 = midlist[2] as inputdata;
            inputdata midlist3 = midlist[3] as inputdata;
            inputdata midlist4 = midlist[4] as inputdata;
            inputdata lastlist1 = lastlist[1] as inputdata;
            inputdata lastlist2 = lastlist[2] as inputdata;
            inputdata lastlist3 = lastlist[3] as inputdata;
            inputdata lastlist4 = lastlist[4] as inputdata;
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
            if ((midlist1 != list1) || (midlist2 != list2) || (midlist3 != list3) || (midlist4 != list4))//새로운 값이 입력되었을때
            {

                if (list1.stat + list2.stat + list3.stat + list4.stat >= 2)//키값이 2개 이상일때
                {
                    lastlist1 = midlist1;
                    lastlist2 = midlist2;
                    lastlist3 = midlist3;
                    lastlist4 = midlist4;
                }
                else
                {
                    midlist1 = list1;
                    midlist2 = list2;
                    midlist3 = list3;
                    midlist4 = list4;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            inputdata data = new inputdata();

            data = new inputdata();
            data.key = Keys.Space;
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

            data = new inputdata();
            data.key = Keys.Space;
            data.stat = 0;
            midlist.Add(data);

            data = new inputdata();
            data.key = Keys.Right;
            data.stat = 0;
            midlist.Add(data);

            data = new inputdata();
            data.key = Keys.Left;
            data.stat = 0;
            midlist.Add(data);

            data = new inputdata();
            data.key = Keys.Up;
            data.stat = 0;
            midlist.Add(data);

            data = new inputdata();
            data.key = Keys.Down;
            data.stat = 0;
            midlist.Add(data);

            data = new inputdata();
            data.key = Keys.Space;
            data.stat = 0;
            lastlist.Add(data);

            data = new inputdata();
            data.key = Keys.Right;
            data.stat = 0;
            lastlist.Add(data);

            data = new inputdata();
            data.key = Keys.Left;
            data.stat = 0;
            lastlist.Add(data);

            data = new inputdata();
            data.key = Keys.Up;
            data.stat = 0;
            lastlist.Add(data);

            data = new inputdata();
            data.key = Keys.Down;
            data.stat = 0;
            lastlist.Add(data);

            hero myhero = new hero(this);
            timer1.Interval = 50;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);

            for (y = 0; y < 15; ++y)
                for (x = 0; x < 15; ++x)
                {
                    Bubbles[y, x] = new PictureBox();
                    Bubbles[y, x].SizeMode = PictureBoxSizeMode.StretchImage;
                    Bubbles[y, x].Location = new Point(y * 40, x * 40);
                    Bubbles[y, x].Width = 40;
                    Bubbles[y, x].Height = 40;
                    Bubbles[y, x].Image = Properties.Resources.bubble;
                    Bubbles[y, x].Visible = false;
                    this.Controls.Add(Bubbles[y, x]);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hero.move(this, list, Bubbles);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        public class hero
        {
            public static PictureBox pb_hero;//사용자 캐릭터

            public int key;
            public int level = 2;//상태레벨
            public static int speed = 10;//이동속도
            public int i_max_bubble = 1;//버블길이
            public int i_cur_bubble = 1;//

            public hero(Control c_par)
            {

                i_max_bubble = 2;
                i_cur_bubble = 0;

                pb_hero = new PictureBox();
                pb_hero.Location = new Point(20, 20);
                pb_hero.Size = new Size(40, 40);
                pb_hero.Image = Properties.Resources.F;
                pb_hero.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_hero.Visible = true;
                c_par.Controls.Add(pb_hero);
            }

            public static void move(Control moveit, ArrayList list, PictureBox[,] Bubbles)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    inputdata temp = list[i] as inputdata;
                    inputdata temp1 = list[1] as inputdata;
                    inputdata temp2 = list[2] as inputdata;
                    inputdata temp3 = list[3] as inputdata;
                    inputdata temp4 = list[4] as inputdata;
                    inputdata right = lastlist[1] as inputdata;
                    inputdata left = lastlist[2] as inputdata;
                    inputdata up = lastlist[3] as inputdata;
                    inputdata down = lastlist[4] as inputdata;
                    System.Windows.Forms.Timer timer_A;
                    timer_A = new System.Windows.Forms.Timer();
                    timer_A.Interval = 2000;
                    timer_A.Tick += new EventHandler(timer_A_Tick);
                    if (temp.key == Keys.Space)
                    {
                        if (temp.stat == 1)
                        {
                            double x = hero.pb_hero.Location.X;
                            double y = hero.pb_hero.Location.Y;

                            x = Math.Round(x / 40);
                            y = Math.Round(y / 40);

                            int X = (int)x;
                            int Y = (int)y;

                            if (((moveit.Size.Width / 15) * (hero.pb_hero.Location.X / (moveit.Size.Width / 15))) + (moveit.Size.Width / 30) > hero.pb_hero.Location.X && (((moveit.Size.Height / 15) * (hero.pb_hero.Location.X / (moveit.Size.Height / 15))) + (moveit.Size.Height / 30) > hero.pb_hero.Location.X))
                            {
                                Bubbles[X, Y].Visible = true;
                                timer_A.Start();
                            }
                            else if (((moveit.Size.Width / 15) * (hero.pb_hero.Location.X / (moveit.Size.Width / 15))) + (moveit.Size.Width / 30) < hero.pb_hero.Location.X && (((moveit.Size.Height / 15) * (hero.pb_hero.Location.X / (moveit.Size.Height / 15))) + (moveit.Size.Height / 30) < hero.pb_hero.Location.X))
                            {
                                Bubbles[X, Y].Visible = true;
                                timer_A.Start();
                            }
                        }


                        else if (temp.key == Keys.Right)
                        {
                            if (temp.stat == 1)
                            {
                                if ((temp3.stat != up.stat) || (temp4.stat != down.stat))//수직처리
                                {

                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                }
                                else
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);

                                }

                            }
                        }

                        else if (temp.key == Keys.Left)
                        {
                            if (temp.stat == 1)
                            {
                                if ((temp3.stat != up.stat) || (temp4.stat != down.stat))//수직
                                {

                                }
                                else if ((temp1.stat != right.stat))//오른쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.R;
                                }
                                else
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                }

                            }
                        }

                        else if (temp.key == Keys.Up)
                        {
                            if (temp.stat == 1)
                            {
                                if ((temp1.stat != right.stat))//오른쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.R;

                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);

                                }
                                else if ((temp4.stat != down.stat))//반대
                                {

                                }
                                else
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y - hero.speed);
                                    hero.pb_hero.Image = Properties.Resources.B;

                                }

                            }
                        }

                        else if (temp.key == Keys.Down)
                        {
                            if (temp.stat == 1)
                            {
                                if ((temp1.stat != right.stat))//오른쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.R;

                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);

                                }
                                else if ((temp3.stat != up.stat))//반대
                                {

                                }
                                else
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y + hero.speed);
                                    hero.pb_hero.Image = Properties.Resources.F;
                                }

                            }
                        }
                        if (hero.pb_hero.Location.X < 0)//왼쪽으로 너무갔을때
                        {
                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);

                        }
                        else if (hero.pb_hero.Location.X > 584)//오른쪽으로 너무갔을때
                        {
                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);

                        }
                        else if (hero.pb_hero.Location.Y < 0)//위쪽으로 너무갔을때
                        {
                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y + hero.speed);

                        }
                        else if (hero.pb_hero.Location.Y > 561)//아래쪽으로 너무 갔을때
                        {
                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y - hero.speed);

                        }
                    }

                }

            }

        }
        class inputdata
        {
            public Keys key { get; set; }
            public int stat { get; set; }
        }

        class map
        {
            int[,] block = new int[15, 15] {
            { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
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

            //아이템, 물풍선, 타이머
            class timer
            {

            }
        }


    }
}