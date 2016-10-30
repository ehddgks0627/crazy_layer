using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy
{
    public partial class Choose_Room : Form
    {
        public Choose_Room()
        {
            InitializeComponent();

            label1.Text = Register.Nickname;
            label2.Text = "" + Page_Num;

            int Page_Check_Num = (20 /*방현재 최대 수 서버에서받아옴*/  / 4) + 1;

            if (Page_Check_Num != 1 && 20 /*방현재 최대 수 서버에서 받아몸*/ % 4 == 0)
                Page_Check_Num--;

            if (Page_Num == 1) 
                button4.Enabled = false;             //<- 버튼 활성화 비활성화 확인
            else
                button4.Enabled = true;

            if (Page_Num == Page_Check_Num)         //-> 버튼 활성화 비활성화 확인
                button5.Enabled = false;
            else
                button5.Enabled = true;

            Label Label_Num = new Label();
            Label Label_People = new Label();
            PictureBox PictureBox_Num = new PictureBox();

            for (int i = 0; i < 20 /* 만들어진 방 총 갯수 서버에서 받아옴*/; i++)
            {
                PictureBox_Num = new PictureBox();
                PictureBox_Num.Size = new Size(253, 163);
                Label_Num = new Label();
                Label_Num.Size = new Size(278, 54);
                Label_People = new Label();
                PictureBox_Num.Click += new System.EventHandler(this.PictureBox_Num);

                if (i % 4 == 0)
                {
                    PictureBox_Num.Location = new Point(633, 268);
                    Label_Num.Location = new Point(912, 268);
                    Label_People.Location = new Point(966, 406);
                }
                else if (i % 4 == 1)
                {
                    PictureBox_Num.Location = new Point(1224, 268);
                    Label_Num.Location = new Point(1496, 268);
                    Label_People.Location = new Point(1557, 406);
                }
                else if (i % 4 == 2)
                {
                    PictureBox_Num.Location = new Point(633, 502);
                    Label_Num.Location = new Point(912, 502);
                    Label_People.Location = new Point(966, 643);
                }
                else if (i % 4 == 3)
                {
                    PictureBox_Num.Location = new Point(1224, 502);
                    Label_Num.Location = new Point(1496, 502);
                    Label_People.Location = new Point(1557, 643);
                }

                Label_Num.Text = Make_Room.Room_name + " / " + ""/*방 번호 서버에서 받아올꺼*/;
                Label_People.Text = ""/*현재 방 인원 서버에서 받음*/ + " / " + Make_Room.Room_Size;

                if (Make_Room.Check_Room == -1)
                    PictureBox_Num.BackgroundImage = Properties.Resources.yes;
                else
                    PictureBox_Num.BackgroundImage = Properties.Resources.no;
            }

            for (int i = 0; i < 4; i++)
            {
                Controls.Add(PictureBox_Num);
                Controls.Add(Label_Num);             //페이지에 따른 방 목록을 등록
                Controls.Add(Label_People);
            }
        }

        public static int Check_chatting = 0;   //채팅 처음이면 입력하는건지 확인 하는변수

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length != 0 && e.KeyCode == Keys.Enter)
            {
                Chatting_Box.Items.Add(Register.Nickname + " : " + textBox1.Text);
                textBox1.Text = "";
                Chatting_Box.SelectedIndex = Chatting_Box.Items.Count - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Room frm = new Search_Room();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Make_Room frm = new Make_Room();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Shop frm = new Shop();
            frm.Owner = this;
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Check_chatting == 0)
            {
                textBox1.Text = "";
                Check_chatting = 1;
            }
        }

        public static int Page_Num = 1; //현재내가 몇번째 페이지인지 확인하는 변수

        private void button4_Click(object sender, EventArgs e)
        {
            Page_Num--;
            label2.Text = "" + Page_Num;
            this.Visible = false;
            Choose_Room frm = new Choose_Room();
            frm.Owner = this;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Page_Num++;
            label2.Text = "" + Page_Num;
            this.Visible = false;
            Choose_Room frm = new Choose_Room();
            frm.Owner = this;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Choose_Room frm = new Choose_Room();
            frm.Owner = this;
            frm.Show();
        }

        private void PictureBox_Num(object sender, EventArgs e)
        {
            this.Visible = false;
            before_game frm = new before_game();
            frm.Owner = this;
            frm.Show();
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Quit_ask frm = new Quit_ask(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            start frm = new start(); // 새 폼 생성¬
            frm.Show();
            this.Close();
        }
    }
}
