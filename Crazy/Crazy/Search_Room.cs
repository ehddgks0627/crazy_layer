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
    public partial class Search_Room : Form
    {
        int check_pw = 1;
        int key;

        public Search_Room(int k)
        {
            InitializeComponent();
            key = k;
            r_id.Text = "";
            r_pw.Text = "";
        }

        public static string Room_List = (start.post_query("http://layer7.kr/room.php", "type=list"));
        public static string[] Room = Room_List.Split(';');

        //3-0-fuck-admin-7-1-0   7 맥스 1

        private void button1_Click(object sender, EventArgs e)
        {
            if (r_id.Text == "")
                MessageBox.Show("방 번호를 입력해주세요");
            else
            {
                if (pwd.CheckState == CheckState.Unchecked)
                {
                    if (start.post_query("http://layer7.kr/room.php", "type=join", "id=" + r_id.Text, "key=" + key) == "1@")
                    {
                        string[] Room_Decomposition = Room[Convert.ToInt16(r_id.Text) - 1].Split('-');
                        if (Room_Decomposition[4] != Room_Decomposition[5])
                        {
                            this.Visible = false;
                            before_game frm = new before_game(key);
                            frm.Owner = this;
                            frm.Show();
                        }
                        else
                            MessageBox.Show("방이 꽉 찼습니다.");

                        MessageBox.Show(start.post_query("http://layer7.kr/room.php", "type=join", "id=" + r_id.Text, "key=" + key));
                    }
                    else
                        MessageBox.Show("없는 방 입니다.");
                }

                else
                {
                    if (start.post_query("http://layer7.kr/room.php", "type=join", "id=" + r_id.Text, "key=" + key, "pw=" + r_pw.Text) == "1@")
                    {
                        string[] Room_Decomposition = Room[Convert.ToInt16(r_id.Text) - 1].Split('-');
                        if (Room_Decomposition[4] != Room_Decomposition[5])
                        {
                            this.Visible = false;
                            before_game frm = new before_game(key);
                            frm.Owner = this;
                            frm.Show();
                        }
                        else
                            MessageBox.Show("방이 꽉 찼습니다.");

                        MessageBox.Show(start.post_query("http://layer7.kr/room.php", "type=join", "id=" + r_id.Text, "key=" + key, "pw=" + r_pw.Text));
                    }
                    else
                        MessageBox.Show("없는 방 입니다.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Visible = true;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_pw *= -1;
            if (check_pw == -1)
                r_pw.ReadOnly = false;
            else
                r_pw.ReadOnly = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}