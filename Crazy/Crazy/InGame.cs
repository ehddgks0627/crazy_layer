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
    public partial class ingame : Form
    {
        public ingame()
        {
            InitializeComponent();
        }

        private void gmae_out_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            before_game frm = new before_game(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show();
        }
    }
}