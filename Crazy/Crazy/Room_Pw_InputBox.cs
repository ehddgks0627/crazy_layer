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
    public partial class Room_Pw_InputBox : Form
    {
        public Room_Pw_InputBox()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            string str = start.post_query("http://layer7.kr/room.php", "type=list");
            string[] Room = str.Split(';');
            string[] Room_Decomposition = Room[Choose_Room.Room_Key - 1].Split('-');
   
            if (textBox1.Text == "")
                MessageBox.Show("비밀번호를 입력해주세요");
            else
            {
                if (Room_Decomposition[4] == Room_Decomposition[5])
                    MessageBox.Show("방이 꽉 찼습니다.");
                else
                {
                    if ((start.post_query("http://layer7.kr/room.php", "type=join", "id=" + Choose_Room.Room_Key, "key=" + start.User_Key, "nickname=" + start.nick, "pw=" + textBox1.Text) == "1@"))
                    {
                        this.Visible = false;
                        before_game frm = new before_game(Choose_Room.Room_Key);
                        frm.Owner = this;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("비밀번호가 틀렸습니다.");
                }
            }
        }
        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


