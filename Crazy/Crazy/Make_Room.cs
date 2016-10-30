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
    public partial class Make_Room : Form
    {
        public Make_Room()
        {
            InitializeComponent();
            Check_Room = 1;
            Room_Now_People = 1;
        }

        public static string Room_name;
        public static string Room_PW;
        public static int Room_Size;     //방 최대 인원수
        public static int Room_Now_People; // 방 인원 체크
        public static int Check_Room; // 비밀방인지 공개방인지 체크

        private void button1_Click(object sender, EventArgs e)
        {
            Room_name = textBox1.Text;
            Room_PW = textBox2.Text;


            if (Room_name.Length == 0)
                MessageBox.Show("방제목을 입력해주세요.");

            else if (Check_Room == -1)
            {
                if (Room_PW.Length > 3)
                {
                    if (comboBox1.Text != "")
                    {
                        Room_Size = Convert.ToInt32(comboBox1.Text);
                        this.Visible = false;
                        Application.OpenForms["Form2"].Close();
                        before_game frm = new before_game();
                        frm.Owner = this;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("인원수를 선택해주세요");
                }
                else
                    MessageBox.Show("비밀번호 4글자 이상을 입력해주세요.");
            }

            else if (Check_Room == 1)
            {
                if (comboBox1.Text != "")
                {
                    Room_Size = Convert.ToInt32(comboBox1.Text);
                    this.Visible = false;
                    Application.OpenForms["Form2"].Close();
                    before_game frm = new before_game();
                    frm.Owner = this;
                    frm.Show();
                }
                else
                    MessageBox.Show("인원수를 선택해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Check_Room = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Check_Room *= -1;

            if (Check_Room == -1)
                textBox2.ReadOnly = false;
              else
                textBox2.ReadOnly = true;
        }

    }
}
