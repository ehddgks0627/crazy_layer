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

        public static string key;
        private void Yes_Click(object sender, EventArgs e)
        {
            string str = start.post_query("http://layer7.kr/room.php", "type=list");
            string[] Room = str.Split(';');
            string[] Room_Decomposition = Room[Choose_Room.Use_Room_Pw_InputBox - 1].Split('-');
   
            Console.WriteLine("{0}", str);
            Console.WriteLine("{0},{1}", Room_Decomposition[1],Room_Decomposition[0]);
        //return : id=( )-pw=( )-title=( )-owner_nickname=( )-max=( )-now=( )-started=( );
        //type=join;id=( );key=( );nickname=( );pw=( ); #pw는 선택
        //data: id = ( ); pw = ( );
        //    return : key = ( ) - nickname = ( ) or 0
            if (textBox1.Text == "")
                MessageBox.Show("비밀번호를 입력해주세요");
            else
            {
                if (Room_Decomposition[4] == Room_Decomposition[5])
                    MessageBox.Show("방이 꽉 찼습니다.");
                else
                {
                    if ((start.post_query("http://layer7.kr/room.php", "type=join", "id=" + Choose_Room.Use_Room_Pw_InputBox, "key=" + key, "nickname=" + start.nick, "pw=" + textBox1.Text) == "1@"))
                    {
                        this.Visible = false;
                        before_game frm = new before_game(Choose_Room.Use_Room_Pw_InputBox);
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


