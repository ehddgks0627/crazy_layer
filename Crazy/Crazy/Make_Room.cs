using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Crazy
{
    public partial class Make_Room : Form
    {
        int key;

        public Make_Room(int k)
        {
            InitializeComponent();
            key = k;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string respon;
            if (room_sub.Text.Length == 0)
                MessageBox.Show("방제목을 입력해주세요.");

            else if (pwd.CheckState == CheckState.Checked)
            {
                if (room_pwd.Text.Length > 3)
                {
                    if (room_max.Text != "")
                    {
                        respon = start.post_query("http://layer7.kr/room.php", "type=create", "title=" + room_sub.Text, "max=" + room_max.Text, "owner_key=" + key, "pw=" + room_pwd.Text);
                        if (respon[0] != '0')
                        {
                            this.Visible = false;
                            before_game frm = new before_game(key);
                            frm.Owner = this.Owner;
                            frm.Show();
                            this.Close();
                        }
                        else
                            MessageBox.Show("방 생성 실패");
                    }
                    else
                        MessageBox.Show("인원수를 선택해주세요");
                }
                else
                    MessageBox.Show("비밀번호 4글자 이상을 입력해주세요.");
            }

            else if (pwd.CheckState == CheckState.Unchecked)
            {
                if (room_max.Text != "")
                {
                 respon = start.post_query("http://layer7.kr/room.php", "type=create", "title=" + room_sub.Text, "max=" + room_max.Text, "owner_key=" + key);
                    MessageBox.Show(key.ToString());
                    if (respon[0] != '0')
                    {
                        this.Visible = false;
                        before_game frm = new before_game(key);
                        frm.Owner = this.Owner;
                        frm.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("방 생성 실패");
                }
                else
                    MessageBox.Show("인원수를 선택해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pwd.CheckState == CheckState.Checked)
                room_pwd.ReadOnly = false;
            else
                room_pwd.ReadOnly = true;
        }
    }
}
