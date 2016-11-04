using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[,] PictureBox_map = new PictureBox[15, 15];

            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j < 15; ++j)
                {
                    PictureBox_map[i, j] = new PictureBox();
                    PictureBox_map[i, j].Location = new Point(j * 50, i * 50);

                    PictureBox_map[i, j].Image = Properties.Resources.바닥;
                }
            }
            PictureBox[,] PictureBox_block = new PictureBox[15, 15];
            for (int i = 0; i < 15; ++i)
            {
                if (i == 0 || i == 14)
                {
                    for (int j = 2; j < 6; ++j)
                    {
                        PictureBox_block[i, j] = new PictureBox();
                        PictureBox_block[i, j].Location = new Point(j * 50, i * 50);
                        Random r = new Random();
                        int num_one_or_two = r.Next(1, 2);
                        if (num_one_or_two == 1)
                        {
                            PictureBox_map[i, j].Image = Properties.Resources.걸상;
                        }
                        else
                        {
                            PictureBox_map[i, j].Image = Properties.Resources.책상;
                        }
                    }
                    for (int j = 9; j < 14; ++j)
                    {
                        PictureBox_block[i, j] = new PictureBox(); 
                        PictureBox_block[i, j].Location = new Point(j * 50, i * 50);
                        Random r = new Random();
                        int num_one_or_two = r.Next(1, 2);
                        if (num_one_or_two == 1)
                        {
                            PictureBox_map[i, j].Image = Properties.Resources.걸상;
                        }
                        else
                        {
                            PictureBox_map[i, j].Image = Properties.Resources.책상;
                        }
                    }
                }

            }
        }
    }

}
