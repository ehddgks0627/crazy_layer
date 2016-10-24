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
    public partial class start : Form
    {

        public start()
        {

            InitializeComponent();
           
            if (Login.check == 0)
            {
                label1.Text = "로그인 해주세요";
            }

            else
            {

                label1.Text = join.Nickname + "님 반갑습니다.";
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
                Form2 frm = new Form2();
                frm.Owner = this;
                frm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            join frm = new join();
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
