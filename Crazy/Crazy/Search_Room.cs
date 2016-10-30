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
    public partial class Search_Room : Form
    {
        int check_pw = 1;
        int key;

        public Search_Room(int k)
        {
            InitializeComponent();
            key = k;
            r_id.Text = "";
            r_pw.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r_id.Text == "")
                MessageBox.Show("방 번호를 입력해주세요");
            else
                MessageBox.Show(start.post_query("http://layer7.kr/room.php", "type=join", "id=" + r_id.Text, "pw=" + r_pw.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Visible = true;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_pw *= -1;
            if (check_pw == -1)
                r_pw.ReadOnly = false;
            else
                r_pw.ReadOnly = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
