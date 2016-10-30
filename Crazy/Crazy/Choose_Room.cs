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
        int key;
        public Choose_Room(int k = 0)
        {
            InitializeComponent();
            key = k;
            label1.Text = Register.Nickname;
            label2.Text = "" + Page_Num;

            int Page_Check_Num = (Make_Room.Check_Num / 4) + 1;
            if (Page_Check_Num != 1 && Make_Room.Check_Num % 4 == 0)
                Page_Check_Num--;

            if (Page_Num == 1)
                button4.Enabled = false;
            else
                button4.Enabled = true;
            if (Page_Num == Page_Check_Num)
                button5.Enabled = false;
            else
                button5.Enabled = true;


            Label[] Label_Num = new Label[32];
            Label[] Label_People = new Label[32];
            PictureBox[] PictureBox_Num = new PictureBox[32];


            for (int i = 0; i < Make_Room.Check_Num; i++)
            {

                PictureBox_Num[i] = new PictureBox();
                PictureBox_Num[i].Size = new Size(253, 163);
                Label_Num[i] = new Label();
                Label_Num[i].Size = new Size(278, 54);
                Label_People[i] = new Label();
                PictureBox_Num[i].Click += new System.EventHandler(this.PictureBox_Num);

                if (i % 4 == 0)
                {
                    PictureBox_Num[i].Location = new Point(633, 268);
                    Label_Num[i].Location = new Point(912, 268);
                    Label_People[i].Location = new Point(966, 406);
                }

                else if (i % 4 == 1)
                {
                    PictureBox_Num[i].Location = new Point(1224, 268);
                    Label_Num[i].Location = new Point(1496, 268);
                    Label_People[i].Location = new Point(1557, 406);
                }

                else if (i % 4 == 2)
                {
                    PictureBox_Num[i].Location = new Point(633, 502);
                    Label_Num[i].Location = new Point(912, 502);
                    Label_People[i].Location = new Point(966, 643);
                }
                else if (i % 4 == 3)
                {
                    PictureBox_Num[i].Location = new Point(1224, 502);
                    Label_Num[i].Location = new Point(1496, 502);
                    Label_People[i].Location = new Point(1557, 643);
                }

                Label_Num[i].Text = Make_Room.Room_name[i] + " / " + Make_Room.Room_Number[i];
                Label_People[i].Text = Make_Room.Room_Now_People[i] + " / " + Make_Room.Room_Size[i];

                if (Make_Room.Check_Room[i] == -1)
                    PictureBox_Num[i].BackgroundImage = Properties.Resources.yes;

                else
                    PictureBox_Num[i].BackgroundImage = Properties.Resources.no;
            }

            for (int i = 0; i < 4; i++)
            {
                Controls.Add(PictureBox_Num[(Page_Num - 1) * 4 + i]);
                Controls.Add(Label_Num[(Page_Num - 1) * 4 + i]);
                Controls.Add(Label_People[(Page_Num - 1) * 4 + i]);
            }
        }

        public static int Check_chatting = 0;

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
            Search_Room frm = new Search_Room(key);
            frm.Owner = this;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Make_Room frm = new Make_Room();
            frm.Show();
            frm.set_key(key);
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

        public static int Page_Num = 1;

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

        private void PictureBox_Num(object sender, EventArgs e)
        {
            Console.WriteLine("{0}", sender);
            this.Visible = false;
            before_game frm = new before_game();
            frm.Owner = this;
            frm.Show();
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Quit_ask frm = new Quit_ask(); // 새 폼 생성
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            start frm = new start(); // 새 폼 생성
            frm.Show();
            this.Close();
        }
    }
}
