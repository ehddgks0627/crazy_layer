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
        public Make_Room()
        {
            InitializeComponent();


            Check_Room[Check_Num] = 1;
            Room_Number[Check_Num] = (Check_Num + 1);
            Room_Now_People[Check_Num] = 1;

        }
        public string post_query(params string[] postDatas) // 첫 인자는 무조건 URL주소
        {
            HttpWebRequest wReq;
            HttpWebResponse wRes;
            var resResult = "";
            var uri = new Uri(postDatas[0]); // string 을 Uri 로 형변환

            wReq = (HttpWebRequest)WebRequest.Create(uri); // WebRequest 객체 형성 및 HttpWebRequest 로 형변환
            wReq.Method = "POST"; // 전송 방법 "GET" or "POST"
            wReq.ServicePoint.Expect100Continue = false;
            wReq.ContentType = "application/x-www-form-urlencoded";
            String postData = "";
            for (int i = 1; i < postDatas.Length; i++)
            {
                if (i != 1)
                    postData += "&";
                postData += postDatas[i];
            }
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            Stream dataStream = wReq.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            using (wRes = (HttpWebResponse)wReq.GetResponse())
            {
                Stream respPostStream = wRes.GetResponseStream();
                StreamReader readerPost = new StreamReader(respPostStream, Encoding.GetEncoding("UTF-8"), true);
                resResult = readerPost.ReadToEnd();
            }
            return resResult;
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
            Room_name[Check_Num] = textBox1.Text;
            Room_PW[Check_Num] = textBox2.Text;


            if (Room_name[Check_Num].Length == 0)
            {
                MessageBox.Show("방제목을 입력해주세요.");
            }

            else if (Check_Room[Check_Num] == -1)
            {
                if (Room_PW[Check_Num].Length > 3)
                {
                    if (comboBox1.Text != "")
                    {
                        Room_Size[Check_Num] = Convert.ToInt32(comboBox1.Text);
                        Check_Num++;
                        this.Visible = false;
                        Application.OpenForms["Form2"].Close();
                        before_game frm = new before_game();
                        frm.Owner = this;
                        frm.Show();
                    }

                    else
                    {
                        MessageBox.Show("인원수를 선택해주세요");
                    }
                }

                else
                {
                    MessageBox.Show("비밀번호 4글자 이상을 입력해주세요.");
                }

            }

            else if (Check_Room[Check_Num] == 1)
            {
                if (comboBox1.Text != "")
                {
                    Room_Size[Check_Num] = Convert.ToInt32(comboBox1.Text);
                    Check_Num++;
                    this.Visible = false;
                    Application.OpenForms["Choose_Room"].Close();
                    if(Room_PW[0].Equals(""))
                        post_query("http://layer7.kr/room.php", "type=create", "max="+Room_Size[1], "owner_key="+Login.key);
                    else
                        post_query("http://layer7.kr/room.php", "type=create", "max=" + Room_Size[1], "owner_key=" + Login.key, "pw="+Room_PW[0]);
                    before_game frm = new before_game();
                    frm.Owner = this;
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("인원수를 선택해주세요");
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Check_Room[Check_Num] = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Check_Room[Check_Num] *= -1;
            if (Check_Room[Check_Num] == -1)
            {
                textBox2.ReadOnly = false;
            }

            else
            {
                textBox2.ReadOnly = true;
            }

        }

    }
}
