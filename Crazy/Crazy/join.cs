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

    public partial class join : Form
    {
        public join()
        {
            InitializeComponent();
        }


            public static string ID = null;
            public static string PW = null;
            public static string Nickname = null;
            public static int Key = 0;
    


        private void button1_Click(object sender, EventArgs e)
        {
        
            ID = textBox1.Text;
            PW = textBox2.Text;
            Nickname = textBox3.Text;

            if (ID.Length > 16 | ID.Length < 6)
            {
                MessageBox.Show("아이디는 6 ~ 16 글자로 입력해주세요. ");
            }

            else if (PW.Length < 8 | PW.Length > 20)
            {
                MessageBox.Show("패스워드는 8 ~ 20 글자로 입력해주세요. ");
            }

            else if (Nickname.Length < 2 | Nickname.Length > 12)
            {
                MessageBox.Show("닉네임은 2 ~ 12글자로 입력해주세요.");
            }

            else
            {
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
