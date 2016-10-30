using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Crazy
{
    public partial class start : Form
    {
        public static string post_query(params string[] postDatas) // 첫 인자는 무조건 URL주소
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
        public start()
        {

            InitializeComponent();
           
            if (Login.check == 0)
            {
                label1.Text = "로그인 해주세요";
            }

            else
            {

                label1.Text = Register.Nickname + "님 반갑습니다.";
                Button Logout_Button = new Button();
                Logout_Button.Location = new Point(30, 30);
                Logout_Button.Size = new Size(70, 70);
                Logout_Button.Text = "Logout";
                Controls.Add(Logout_Button);
                Logout_Button.Click += Logout_Button_Click;

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Login.check == 0)
            {
                MessageBox.Show("로그인 해주세요");
            }

            else
            {
                this.Visible = false;
                Choose_Room frm = new Choose_Room();
                frm.Owner = this;
                frm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register frm = new Register();
            frm.Owner = this;
            frm.Show(); 
            
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 성공");
            Login.check = 0;

            this.Visible = false;
            start frm = new start();
            frm.Owner = this;
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login frm = new Login();
            frm.Owner = this;
            frm.Show();
        }
    }

}
