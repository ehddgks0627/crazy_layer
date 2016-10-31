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
            Make_Room frm = new Make_Room(key);
            frm.Owner = this;
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
            before_game frm = new before_game(key);
            frm.Owner = this;
            frm.Show();
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
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

        private void Choose_Room_Load(object sender, EventArgs e)
        {

        }
    }
}
