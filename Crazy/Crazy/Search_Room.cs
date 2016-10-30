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

        public Search_Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int room_id;
            room_id = Convert.ToInt32(textBox1.Text);
            room_id = int.Parse(textBox1.Text);

            for (int i = 0; i < Make_Room.Check_Num; i++)
            {
                if (Make_Room.Room_Number[i] == room_id)
                {
                    if (Make_Room.Check_Room[i] == -1)
                    {
                        if (Make_Room.Room_PW[i] == textBox2.Text)
                        {
                            this.Visible = false;
                            Application.OpenForms["Form2"].Close();
                            before_game frm = new before_game();
                            frm.Owner = this;
                            frm.Show();
                        }
                        else
                            MessageBox.Show("암호가 틀립니다.");
                    }
                    else if (Make_Room.Check_Room[i] == 1)
                    {
                        this.Visible = false;
                        Application.OpenForms["Form2"].Close();
                        before_game frm = new before_game();
                        frm.Owner = this;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show("없는 방입니다.");
            }
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
                textBox2.ReadOnly = false;
            else
                textBox2.ReadOnly = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
