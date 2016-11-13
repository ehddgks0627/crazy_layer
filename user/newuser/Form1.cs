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
        static PictureBox[,] splash = new PictureBox[15, 15];
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
            inputdata list5 = list[5] as inputdata;
            inputdata midlist1 = midlist[1] as inputdata;
            inputdata midlist2 = midlist[2] as inputdata;
            inputdata midlist3 = midlist[3] as inputdata;
            inputdata midlist4 = midlist[4] as inputdata;
            inputdata midlist5 = midlist[5] as inputdata;
            inputdata lastlist1 = lastlist[1] as inputdata;
            inputdata lastlist2 = lastlist[2] as inputdata;
            inputdata lastlist3 = lastlist[3] as inputdata;
            inputdata lastlist4 = lastlist[4] as inputdata;
            inputdata lastlist5 = lastlist[5] as inputdata;
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
            else if (e.KeyCode == Keys.Z)
            {
                inputdata temp = list[5] as inputdata;
                if (temp.key == e.KeyCode)
                {
                    if (temp.stat != 1)
                    {
                        temp.stat = 1;
                    }
                }
            }
            if ((midlist1 != list1) || (midlist2 != list2) || (midlist3 != list3) || (midlist4 != list4) || (midlist5 != list5))//새로운 값이 입력되었을때
            {

                if (list1.stat + list2.stat + list3.stat + list4.stat >= 2)//키값이 2개 이상일때
                {
                    lastlist1 = midlist1;
                    lastlist2 = midlist2;
                    lastlist3 = midlist3;
                    lastlist4 = midlist4;
                    lastlist5 = midlist5;
                }
                else
                {
                    midlist1 = list1;
                    midlist2 = list2;
                    midlist3 = list3;
                    midlist4 = list4;
                    midlist5 = list5;
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
            data.key = Keys.Z;
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
            data.key = Keys.Z;
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

            data = new inputdata();
            data.key = Keys.Z;
            data.stat = 0;
            lastlist.Add(data);

            timer1.Interval = 50;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            hero myhero = new hero(this);

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
            for (y = 0; y < 15; ++y)
                for (x = 0; x < 15; ++x)
                {
                    splash[y, x] = new PictureBox();
                    splash[y, x].SizeMode = PictureBoxSizeMode.StretchImage;
                    splash[y, x].Location = new Point(y * 40, x * 40);
                    splash[y, x].Width = 40;
                    splash[y, x].Height = 40;
                    splash[y, x].Image = Properties.Resources.water;
                    splash[y, x].Visible = false;
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
            else if (e.KeyCode == Keys.Z)
            {
                inputdata data = list[5] as inputdata;
                data.stat = 0;
            }
        }

        public class hero
        {
            public static PictureBox pb_hero;//사용자 캐릭터

            public static int key;
            public static int level = 2;//상태레벨
            public static int speed = 10;//이동속도
            public static int i_max_bubble = 1;//버블길이
            public static int i_cur_bubble = 1;
            public static int nowbubble = 0;
            public static int dart_locationX;
            public static int dart_locationY;

            public static int[,] map = new int[15, 15] {
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

            public static int[,] item = new int[15, 15] {
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
            };//맵의 아이템


            public hero(Control c_par)
            {

                i_max_bubble = 2;
                i_cur_bubble = 0;

                pb_hero = new PictureBox();
                pb_hero.Location = new Point(0, 0);
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
                    if (temp.key == Keys.Space)
                    {
                        if (temp.stat == 1)
                        {
                            int x = hero.pb_hero.Location.X;
                            int y = hero.pb_hero.Location.Y;
                            Bubbles[x / 40, y / 40].Visible = true;
                        }
                    }


                    else if (temp.key == Keys.Right)
                    {
                        if (temp.stat == 1)
                        {
                            if (hero.pb_hero.Location.X / 40 >= 0 && hero.pb_hero.Location.X / 40 < 15)
                            {
                                if ((temp3.stat != up.stat) || (temp4.stat != down.stat))//수직처리
                                {

                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    if (hero.pb_hero.Location.X / 40 > 0)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40 - 1, hero.pb_hero.Location.Y / 40] != 0)//블럭이 있을경우
                                        {
                                        }
                                        else
                                        {
                                            if (hero.pb_hero.Location.X - hero.speed > 0)
                                            {
                                                hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                                hero.pb_hero.Image = Properties.Resources.L;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (map[hero.pb_hero.Location.X / 40, hero.pb_hero.Location.Y / 40] != 0)//블럭이 있을경우
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.L;
                                        }
                                    }
                                }
                                else
                                {
                                    if (map[hero.pb_hero.Location.X / 40 + 1, hero.pb_hero.Location.Y / 40] != 0)
                                    {
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                        hero.pb_hero.Image = Properties.Resources.R;
                                    }
                                }
                            }
                            else
                            {
                                if ((temp3.stat != up.stat) || (temp4.stat != down.stat))//수직처리
                                {

                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.L;
                                }
                                else
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.R;
                                }
                            }
                        }
                    }

                    else if (temp.key == Keys.Left)
                    {
                        if (temp.stat == 1)
                        {
                            if (hero.pb_hero.Location.X / 40 < 15 && hero.pb_hero.Location.X / 40 >= 0)
                            {
                                if ((temp3.stat != up.stat) || (temp4.stat != down.stat))//수직
                                {

                                }
                                else if ((temp1.stat != right.stat))//오른쪽
                                {

                                }
                                else
                                {
                                    if (hero.pb_hero.Location.X / 40 < 15 && hero.pb_hero.Location.X / 40 > 0)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40 - 1, hero.pb_hero.Location.Y / 40] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.L;
                                        }
                                    }
                                    else
                                    {
                                        if (map[hero.pb_hero.Location.X / 40, hero.pb_hero.Location.Y / 40] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.L;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if ((temp3.stat != up.stat) || (temp4.stat != down.stat))//수직
                                {

                                }
                                else if ((temp1.stat != right.stat))//오른쪽
                                {

                                }
                                else
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.L;
                                }
                            }
                        }

                        else if (temp.key == Keys.Up)
                        {
                            if (temp.stat == 1)
                            {
                                if ((temp1.stat != right.stat))//오른쪽
                                {
                                    if (hero.pb_hero.Location.Y / 40 > 0 && hero.pb_hero.Location.Y / 40 < 14 && hero.pb_hero.Location.X / 40 > 0 && hero.pb_hero.Location.X / 40 < 15)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40 + 1, hero.pb_hero.Location.Y / 40] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.R;
                                        }
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                        hero.pb_hero.Image = Properties.Resources.R;
                                    }
                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    if (hero.pb_hero.Location.Y / 40 > 0 && hero.pb_hero.Location.Y / 40 < 14 && hero.pb_hero.Location.X / 40 > 0 && hero.pb_hero.Location.X / 40 < 15)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40 - 1, hero.pb_hero.Location.Y / 40] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.L;
                                        }
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                        hero.pb_hero.Image = Properties.Resources.L;
                                    }
                                }
                                else if ((temp4.stat != down.stat))//반대
                                {

                                }
                                else
                                {
                                    if (hero.pb_hero.Location.Y / 40 > 0 && hero.pb_hero.Location.Y / 40 < 14 && hero.pb_hero.Location.X / 40 > 0 && hero.pb_hero.Location.X / 40 < 15)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40, hero.pb_hero.Location.Y / 40 - 1] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y - hero.speed);
                                            hero.pb_hero.Image = Properties.Resources.B;
                                        }
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y - hero.speed);
                                        hero.pb_hero.Image = Properties.Resources.B;
                                    }
                                }
                            }
                            else
                            {
                                if ((temp1.stat != right.stat))//오른쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.R;
                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.L;
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
                                    if (hero.pb_hero.Location.Y / 40 < 14 && hero.pb_hero.Location.Y / 40 > 0 && hero.pb_hero.Location.X / 40 > 0 && hero.pb_hero.Location.X / 40 < 15)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40 + 1, hero.pb_hero.Location.Y / 40] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.R;
                                        }
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                        hero.pb_hero.Image = Properties.Resources.R;
                                    }
                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    if (hero.pb_hero.Location.Y / 40 < 14 && hero.pb_hero.Location.Y / 40 > 0 && hero.pb_hero.Location.X / 40 > 0 && hero.pb_hero.Location.X / 40 < 15)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40 - 1, hero.pb_hero.Location.Y / 40] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                            hero.pb_hero.Image = Properties.Resources.L;
                                        }
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                        hero.pb_hero.Image = Properties.Resources.L;
                                    }
                                }
                                else if ((temp3.stat != up.stat))//반대
                                {

                                }
                                else
                                {
                                    if (hero.pb_hero.Location.Y / 40 < 14 && hero.pb_hero.Location.Y / 40 > 0 && hero.pb_hero.Location.X / 40 > 0 && hero.pb_hero.Location.X / 40 < 15)
                                    {
                                        if (map[hero.pb_hero.Location.X / 40, hero.pb_hero.Location.Y / 40 + 1] != 0)
                                        {
                                        }
                                        else
                                        {
                                            hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y + hero.speed);
                                            hero.pb_hero.Image = Properties.Resources.F;
                                        }
                                    }
                                    else
                                    {
                                        hero.pb_hero.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y + hero.speed);
                                        hero.pb_hero.Image = Properties.Resources.F;
                                    }
                                }
                            }
                            else
                            {
                                if ((temp1.stat != right.stat))//오른쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X + hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.R;
                                }
                                else if ((temp2.stat != left.stat))//왼쪽
                                {
                                    hero.pb_hero.Location = new Point(hero.pb_hero.Location.X - hero.speed, hero.pb_hero.Location.Y);
                                    hero.pb_hero.Image = Properties.Resources.L;
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
                        else if (temp.key == Keys.Z)
                        {
                            if (temp.stat == 1)
                            {
                                Console.Write("god");
                                int dev;
                                dev = check_Direction();
                                Thread thread_Dart = new Thread(shoot_Dart(dev));
                                thread_Dart.Start();
                            }
                        }
                    }
                }
            }

            private static ThreadStart shoot_Dart(int direction)
            {
                switch (direction)
                {
                    case 0:
                        PictureBox DartR = new PictureBox();

                        DartR.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y);
                        DartR.Size = new Size(40, 40);
                        DartR.Image = Properties.Resources.Dart_Right;
                        DartR.SizeMode = PictureBoxSizeMode.StretchImage;
                        DartR.Visible = true;
                        DartR.Controls.Add(DartR);

                        for (; DartR.Location.X < 940 && DartR.Location.X < 920;)
                        {
                            if (Bubbles[DartR.Location.X / 40, DartR.Location.Y / 40].Visible == true)
                            {
                                pung(DartR.Location.X, DartR.Location.Y);
                                break;
                            }
                            DartR.Location = new Point(DartR.Location.X + 50, DartR.Location.Y);
                            Thread.Sleep(200);
                        }
                        DartR.Controls.Remove(DartR);
                        break;

                    case 1:
                        PictureBox DartL = new PictureBox();

                        DartL.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y);
                        DartL.Size = new Size(40, 40);
                        DartL.Image = Properties.Resources.Dart_left;
                        DartL.SizeMode = PictureBoxSizeMode.StretchImage;
                        DartL.Visible = true;
                        DartL.Controls.Add(DartL);

                        for (; DartL.Location.X < 940 && DartL.Location.X < 920;)
                        {
                            if (Bubbles[DartL.Location.X / 40, DartL.Location.Y / 40].Visible == true)
                            {
                                pung(DartL.Location.X, DartL.Location.Y);
                                break;
                            }
                            DartL.Location = new Point(DartL.Location.X - 50, DartL.Location.Y);
                            Thread.Sleep(200);
                        }
                        DartL.Controls.Remove(DartL);
                        break;

                    case 2:
                        PictureBox DartU = new PictureBox();

                        DartU.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y);
                        DartU.Size = new Size(40, 40);
                        DartU.Image = Properties.Resources.Dart_up;
                        DartU.SizeMode = PictureBoxSizeMode.StretchImage;
                        DartU.Visible = true;
                        DartU.Controls.Add(DartU);

                        for (; DartU.Location.X < 940 && DartU.Location.X < 920;)
                        {
                            if (Bubbles[DartU.Location.X / 40, DartU.Location.Y / 40].Visible == true)
                            {
                                pung(DartU.Location.X, DartU.Location.Y);
                                break;
                            }
                            DartU.Location = new Point(DartU.Location.X, DartU.Location.Y - 50);
                            Thread.Sleep(200);
                        }
                        DartU.Controls.Remove(DartU);
                        break;

                    case 3:
                        PictureBox DartD = new PictureBox();

                        DartD.Location = new Point(hero.pb_hero.Location.X, hero.pb_hero.Location.Y);
                        DartD.Size = new Size(40, 40);
                        DartD.Image = Properties.Resources.Dart_down;
                        DartD.SizeMode = PictureBoxSizeMode.StretchImage;
                        DartD.Visible = true;
                        DartD.Controls.Add(DartD);

                        for (; DartD.Location.X < 940 && DartD.Location.X < 920;)
                        {
                            if (Bubbles[DartD.Location.X / 40, DartD.Location.Y / 40].Visible == true)
                            {
                                pung(DartD.Location.X, DartD.Location.Y);
                                break;
                            }
                            DartD.Location = new Point(DartD.Location.X, DartD.Location.Y + 50);
                            Thread.Sleep(200);
                        }
                        DartD.Controls.Remove(DartD);
                        break;
                }
                return null;
            }

            static void pung(int X, int Y)
            {
                Bubbles[hero.pb_hero.Location.X, hero.pb_hero.Location.Y].Visible = false;
                Thread splash_thread = new Thread(splashEffect(X, Y));
                splash_thread.Start();
            }

            private static ThreadStart splashEffect(int X, int Y)
            {
                int R = 1, L = 1, U = 1, D = 1;
                X /= 40;
                Y /= 40;
                for (int i = 1; i <= hero.i_max_bubble; ++i)//블럭을 만날때까지 이펙트 표시
                {
                    //L
                    if (X - i >= 0 && L == 1)//블럭이 있을때
                    {
                        if (map[X - i, Y] == 1)
                        {
                            map[X - i, Y] = 0;
                            L -= 1;
                        }
                    }
                    else if (L == 1 && X - i >= 0)//못부술때
                    {
                        if (map[X - i, Y] == 2)
                            L -= 1;
                    }
                    else if (X - i >= 0 && L == 1)//블럭이 없을때
                    {
                        if (map[X - i, Y] == 0)
                        {
                            splash[X - i, Y].Visible = true;
                        }
                    }

                    //R
                    if (X + i <= 14 && R == 1)
                    {
                        if (map[X + i, Y] == 1)
                        {
                            map[X + i, Y] = 0;
                            R -= 1;
                        }
                    }
                    else if (R == 1 && X + i <= 14)
                    {
                        if (map[X + i, Y] == 2)
                            R -= 1;
                    }
                    else if (R == 1 && X + i <= 14)
                    {
                        if (map[X + i, Y] == 0)
                            splash[X + i, Y].Visible = true;
                    }

                    //U
                    if (Y - i >= 0 && U == 1)
                    {
                        if (map[X, Y - i] == 1)
                        {
                            map[X, Y - i] = 0;
                            U -= 1;
                        }
                    }
                    else if (U == i && Y - i >= 0)
                    {
                        if (map[X, Y - i] == 2)
                            U -= 1;
                    }
                    else if (U == 1 && Y - i >= 0)
                    {
                        if (map[X, Y - i] == 0)
                            splash[X, Y - i].Visible = true;
                    }

                    //D
                    if (Y + i <= 14 && D == 1)
                    {
                        if (map[X, Y + i] == 1)
                        {
                            map[X, Y + i] = 0;
                            D -= 1;
                        }

                    }
                    else if (D == 1 && Y + i <= 14)
                    {
                        if (map[X, Y + i] == 2)
                            D -= 1;
                    }
                    else if (D == 1 && Y + i <= 14)
                    {
                        if (map[X, Y + i] == 0)
                            splash[X, Y + i].Visible = true;
                    }
                }
                Thread.Sleep(500);
                for (int i = 1; i <= hero.i_max_bubble; ++i)//표시된 이펙트 제거
                {
                    if (X - i >= 0)
                        if (splash[X - i, Y].Visible == true)
                            splash[X - i, Y].Visible = false;
                    if (X + i <= 14)
                        if (splash[X + i, Y].Visible == true)
                            splash[X + i, Y].Visible = false;
                    if (Y - i >= 0)
                        if (splash[X, Y - i].Visible == true)
                            splash[X, Y - i].Visible = false;
                    if (Y + i <= 14)
                        if (splash[X, Y + i].Visible == true)
                            splash[X, Y + i].Visible = false;
                }
                return null;
            }

            static int check_Direction()
            {
                if (hero.pb_hero.Image == Properties.Resources.R)
                    return 0;
                else if (hero.pb_hero.Image == Properties.Resources.L)
                    return 1;
                else if (hero.pb_hero.Image == Properties.Resources.B)
                    return 2;
                else if (hero.pb_hero.Image == Properties.Resources.F)
                    return 3;
                else
                    return 9;
            }

        }

        class inputdata
        {
            public Keys key { get; set; }
            public int stat { get; set; }
        }

        //public class map
        //{
        //    int[,] block = new int[15, 15] {
        //    { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
        //    { 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
        //    { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
        //    { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
        //    { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 },
        //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        //    { 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0 },
        //    { 0, 0, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 0 ,0 },
        //    { 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0 },
        //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        //    { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 },
        //    { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
        //    { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
        //    { 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
        //    { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
        //    };//맵의 블럭 유무상태



        //    //아이템, 물풍선, 타이머
        //    class timer
        //    {

        //    }
        //}
    }
}