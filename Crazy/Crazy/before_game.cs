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
    public partial class before_game : Form
    {
        int player_char = 0;

        public before_game()
        {
            InitializeComponent();
        }

        private void game_exit_Click(object sender, EventArgs e)
        {
            Quit_ask frm = new Quit_ask(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show();
        }

        private void social_open_Click(object sender, EventArgs e)
        {

        }

        private void game_start_Click(object sender, EventArgs e)
        {
            if (ready_check())
            {
                this.Visible = false;
                ingame frm = new ingame(); // 새 폼 생성¬
                frm.Owner = this; // 새 폼의 오너를 현재 폼으로
                frm.Show();
            }
        }

        private bool ready_check()
        {
            return true;
        }

        static string post_query(params string[] postDatas) // 첫 인자는 무조건 URL주소
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

        public void select_dao_Click(object sender, EventArgs e)
        {
            player_char = 0;
            selected_char.Image = Properties.Resources.selected_dao;
            selected_char.Refresh();
        }

        public void selct_dizny_Click(object sender, EventArgs e)
        {
            player_char = 1;
            selected_char.Image = Properties.Resources.selected_diz;
            selected_char.Refresh();
        }

        public void select_uni_Click(object sender, EventArgs e)
        {
            player_char = 2;
            selected_char.Image = Properties.Resources.selected_bazzi;
            selected_char.Refresh();
        }

        public void select_bazzi_Click(object sender, EventArgs e)
        {
            player_char = 3;
            selected_char.Image = Properties.Resources.selected_uni;
            selected_char.Refresh();
        }
    }
}
