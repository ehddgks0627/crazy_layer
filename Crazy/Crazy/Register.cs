﻿using System;
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

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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


        public static string ID = null;
        public static string PW = null;
        public static string Nickname = null;
        public static int Key = 0;



        private void button1_Click(object sender, EventArgs e)
        {

            ID = textBox1.Text;
            PW = textBox2.Text;
            string PW_Re = textBox3.Text;
            Nickname = textBox4.Text;

            if (ID.Length > 16 | ID.Length < 6)
            {
                MessageBox.Show("아이디는 6 ~ 16 글자로 입력해주세요. ");
            }

            else if (PW.Length < 8 | PW.Length > 20)
            {
                MessageBox.Show("패스워드는 8 ~ 20 글자로 입력해주세요. ");
            }

            else if (PW != PW_Re)
            {
                MessageBox.Show("패스워드가 다릅니다.");
            }

            else if (Nickname.Length < 2 | Nickname.Length > 12)
            {
                MessageBox.Show("닉네임은 2 ~ 12글자로 입력해주세요.");
            }

            else
            {
                MessageBox.Show(post_query("http://layer7.kr/register.php", "id=" + textBox1.Text, "pw=" + textBox2.Text, "nickname=" + textBox4.Text));  // 쿼리날림
                this.Visible = false;
                start frm = new start();
                frm.Owner = this;
                frm.Show();
                Key++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            start frm = new start();
            frm.Owner = this;
            frm.Show();
        }
    }
}
