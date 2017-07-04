using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace newuser
{
    public partial class Form1 : Form
    {
        int[,] map = new int[15, 15] {
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
        public static PictureBox[,] floooor = new PictureBox[15, 15];
        public static PictureBox[,] splash = new PictureBox[15, 15];
        public static PictureBox[,] blocks = new PictureBox[15, 15];
        hero myhero = new hero();//hero클래스의 객체로 myhero선언 인자값은 이벤트를 받기위한 form1(this)
        ArrayList list = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

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
            int x, y;
            for (y = 0; y < 15; ++y)
                for (x = 0; x < 15; ++x)
                {
                    if (map[y, x] == 1)
                    {
                        blocks[y, x] = new PictureBox();//이거
                        blocks[y, x].SizeMode = PictureBoxSizeMode.StretchImage;
                        blocks[y, x].Location = new Point(y * 40, x * 40);
                        blocks[y, x].Width = 40;
                        blocks[y, x].Height = 40;
                        blocks[y, x].Image = Properties.Resources.removeable;
                        blocks[y, x].Visible = true;
                        this.Controls.Add(blocks[y, x]);
                    }
                    else if (map[y, x] == 2)
                    {
                        blocks[y, x] = new PictureBox();
                        blocks[y, x].SizeMode = PictureBoxSizeMode.StretchImage;
                        blocks[y, x].Location = new Point(y * 40, x * 40);
                        blocks[y, x].Width = 40;
                        blocks[y, x].Height = 40;
                        blocks[y, x].Image = Properties.Resources.ward;
                        blocks[y, x].Visible = true;
                        this.Controls.Add(blocks[y, x]);
                    }

                    floooor[y, x] = new PictureBox();
                    floooor[y, x].SizeMode = PictureBoxSizeMode.StretchImage;
                    floooor[y, x].Location = new Point(y * 40, x * 40);
                    floooor[y, x].Width = 40;
                    floooor[y, x].Height = 40;
                    floooor[y, x].Image = Properties.Resources.floor;
                    floooor[y, x].Visible = true;

                    splash[y, x] = new PictureBox();
                    splash[y, x].SizeMode = PictureBoxSizeMode.StretchImage;
                    splash[y, x].Location = new Point(y * 40, x * 40);
                    splash[y, x].Width = 40;
                    splash[y, x].Height = 40;
                    splash[y, x].Image = Properties.Resources.water;
                    splash[y, x].Visible = false;

                    this.Controls.Add(splash[y, x]);
                    this.Controls.Add(floooor[y, x]);
                }

            timer1.Interval = 50;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);

        }

        private void timer1_Tick(object sender, EventArgs e)//메인 메소드 지속적 리프레쉬
        {
            for (int i = 0; i < list.Count; i++)
            {
                inputdata temp = list[i] as inputdata;//각각의 키값과 상태를 저장할 temp객체
                inputdata temp1 = list[1] as inputdata;
                inputdata temp2 = list[2] as inputdata;
                inputdata temp3 = list[3] as inputdata;
                inputdata temp4 = list[4] as inputdata;
                pos nowpos = new pos();
                if (temp.key == Keys.Space)
                {
                    if (temp.stat == 1)
                    {
                        bubble balloon = new bubble(this, myhero.getuserpos());
                    }
                }

                else if (temp.key == Keys.Right && (temp3.stat != 1 && temp4.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        myhero.sync(myhero.pb_hero.Location.X + myhero.speed, myhero.pb_hero.Location.Y);
                        myhero.pb_hero.Image = Properties.Resources.R;

                    }
                }

                else if (temp.key == Keys.Left && (temp3.stat != 1 && temp4.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        myhero.sync(myhero.pb_hero.Location.X - myhero.speed, myhero.pb_hero.Location.Y);
                        myhero.pb_hero.Image = Properties.Resources.L;
                    }
                }

                else if (temp.key == Keys.Up && (temp1.stat != 1 && temp2.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        myhero.sync(myhero.pb_hero.Location.X, myhero.pb_hero.Location.Y - myhero.speed);
                        myhero.pb_hero.Image = Properties.Resources.B;
                    }
                }

                else if (temp.key == Keys.Down && (temp1.stat != 1 && temp2.stat != 1))
                {
                    if (temp.stat == 1)
                    {
                        myhero.sync(myhero.pb_hero.Location.X, myhero.pb_hero.Location.Y + myhero.speed);
                        myhero.pb_hero.Image = Properties.Resources.F;
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
    public class pos
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class hero
    {
        public PictureBox pb_hero;//사용자 캐릭터
        public int key;
        pos userpos = new pos();
        public int level = 2;//상태레벨
        public int speed = 10;//이동속도
        public int i_max_bubble = 1;//버블길이
        public int i_cur_bubble = 1;//버블갯수
        
        public hero(Control c_bar)
        {
            userpos.x = 0;
            userpos.y = 0;
            i_max_bubble = 2;
            i_cur_bubble = 0;
            pb_hero = new PictureBox();
            pb_hero.Location = new Point(userpos.x, userpos.y);
            pb_hero.Size = new Size(40, 40);
            pb_hero.Image = Properties.Resources.F;
            pb_hero.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_hero.Visible = true;
            c_bar.Controls.Add(pb_hero);
        }
        public void sync(int newx, int newy)
        {
            userpos.x = newx;
            userpos.y = newy;
            pb_hero.Location = new Point(userpos.x, userpos.y);
        }
        public pos getuserpos()
        {
            return userpos;
        }
    }

    public class bubble
    {
        public PictureBox bp_bubble = new PictureBox();
        public PictureBox pb_bubble = new PictureBox();
        System.Windows.Forms.Timer timer_A;
        pos bubblepos = new pos();
        public bubble(Control fuck, pos userpos)
        {
            pb_bubble = new PictureBox();

            timer_A = new System.Windows.Forms.Timer();
            timer_A.Interval = 2000;
            timer_A.Tick += new EventHandler(timer_A_Tick);
            bubblepos = userpos;
            pb_bubble.Location = new Point(bubblepos.x, bubblepos.y);
            pb_bubble.Image = Properties.Resources.bubble;
            pb_bubble.Size = new System.Drawing.Size(40, 40);
            pb_bubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_bubble.Visible = true;
            fuck.Controls.Add(pb_bubble);
            
            timer_A.Start();

        }
        public void timer_A_Tick(object sender, EventArgs e)
        {
            pb_bubble.Visible = false;
            //물풍선갯수 감소 (i_cur_bubble
            //터지는 이펙트ㄱ
            //터지는것기준으로 양옆 i_max_bubble만큼 픽쳐박스생성
            //충돌판정필요
            //종료
        }
    }
}