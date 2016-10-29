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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static int check = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("로그인 성공");
                check++;
                this.Visible = false;
                start frm = new start();
                frm.Owner = this;
                frm.Show();
            }

            else
            {
                MessageBox.Show("아이디 / 패스워드가 잘못 되었습니다.");
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
