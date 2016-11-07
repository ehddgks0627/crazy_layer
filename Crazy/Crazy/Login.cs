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
            InitializeComponent();
            ID_BOX.Text = "";
            PW_BOX.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respon = start.post_query("http://layer7.kr/login.php", "id=" + ID_BOX.Text, "pw=" + PW_BOX.Text);
            string[] respons = respon.Split('-');

            if (respon[0] != '0')
            {
                MessageBox.Show("로그인 성공");
                start.logged = true;
                start.nick = respons[1].Substring(0, respons[1].Length - 1);
                start.User_Key = Convert.ToInt16(respons[0]);
                this.Visible = false;
                var handle = this.Owner as start;
                handle.set_var(Convert.ToInt32(respons[0]));
                this.Owner.Visible = true;
                this.Close();
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
            this.Close();
        }
    }
}
