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
    public partial class Login : Form
    {
        public Login()
        {
            ID_BOX.Text = "";
            PW_BOX.Text = "";
            InitializeComponent();
        }
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
        public static int check = 0;
        public static int key;
        public static string nickname;
        private void button1_Click(object sender, EventArgs e)
        {
            string respon = post_query("http://layer7.kr/login.php", "id=" + ID_BOX.Text, "pw=" + PW_BOX.Text);
            string[] respons = respon.Split('-');
            key = Convert.ToInt32(respons[0]);
            nickname = respons[1];
            if (respon[0] != '0') 
            {
                
                MessageBox.Show("로그인 성공");
                check++;
                this.Visible = false;
                start frm = new start();
                frm.Owner = this;
                frm.Show();
            }
            else
                MessageBox.Show("아이디 / 패스워드가 잘못 되었습니다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            start frm = new start();
            frm.Owner = this.Owner;
            frm.Show();
   
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
