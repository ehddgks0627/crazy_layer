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
        int key;

        public before_game(int k)
        {
            InitializeComponent();
            key = k;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Choose_Room frm = new Choose_Room(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show();
        }
    }
}