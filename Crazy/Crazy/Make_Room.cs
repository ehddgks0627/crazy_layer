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
       
        public static string[] Room_name = new string[32];
        public static string[] Room_PW = new string[32];
        public static int[] Room_Size = new int[32];     //방 최대 인원수
        public static int[] Room_Now_People = new int[32]; // 방 인원 체크
        public static int[] Check_Room = new int[32]; // 비밀방인지 공개방인지 체크
        public static int[] Room_Number = new int[32]; // 방번호 
        public static int Check_Num = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (room_sub.Text.Length == 0)
                MessageBox.Show("방제목을 입력해주세요.");

            else if (pwd.CheckState == CheckState.Checked)
            {
                if (room_pwd.Text.Length > 3)
                {
                    if (room_max.Text != "")
                    {
                        this.Visible = false;
                        before_game frm = new before_game(key);
                        frm.Owner = this.Owner;
                        frm.Show();
                        this.Close();
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
                    string respon;
                    if (Room_PW[0].Equals(""))
                        respon = start.post_query("http://layer7.kr/room.php", "type=create", "max=" + Room_Size[1], "owner_key=" + key);
                    else
                        respon = start.post_query("http://layer7.kr/room.php", "type=create", "max=" + Room_Size[1], "owner_key=" + key, "pw=" + Room_PW[0]);
                    before_game frm = new before_game(key);
                    frm.Owner = this.Owner;
                    frm.Show();
                    this.Close();
                }

                else
                    MessageBox.Show("인원수를 선택해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Check_Room[Check_Num] = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pwd.CheckState == CheckState.Unchecked)
                room_pwd.ReadOnly = false;
            else
                room_pwd.ReadOnly = true;
        }
    }
}
