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
        public Search_Room()
        {
            InitializeComponent();
            
        }

        int Check_Pw = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            int Input_Num;
            Input_Num = Convert.ToInt32(textBox1.Text);
            Input_Num = int.Parse(textBox1.Text);

            for (int i = 0; i < Make_Room.Check_Num; i++)
            {
                if (Make_Room.Room_Number[i] == Input_Num)
                {
                    if (Make_Room.Check_Room[i] == -1)
                    {

                        if (Make_Room.Room_PW[i] == textBox2.Text)
                        {
                            this.Visible = false;
                            Application.OpenForms["Form2"].Close();
                            Game_Room frm = new Game_Room();
                            frm.Owner = this;
                            frm.Show();
                        }

                        else
                        {
                            MessageBox.Show("암호가 틀립니다.");
                        }

                    }


                    else if (Make_Room.Check_Room[i] == 1)
                    {
                        this.Visible = false;
                        Application.OpenForms["Form2"].Close();
                        Game_Room frm = new Game_Room();
                        frm.Owner = this;
                        frm.Show();
                    }

                }

                else
                {
                    MessageBox.Show("없는 방입니다.");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Check_Pw *= -1 ;
            if (Check_Pw == -1)
            {
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
