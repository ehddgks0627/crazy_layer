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
        int[] random_setting = new int[20] { 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 5 };
        public int random_()
        {
            Random r = new Random();
            int num_ = r.Next(0, 19);


            return random_setting[num_];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] item_on_block = new int[15, 15];
            /*
             * 0 : 아이템 없음
             * 1 : 추가중
            */
            
            int[,] arr = new int[15, 15] {
            { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 0 ,0 },
            { 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
            };//맵의 블럭 유무상태 {from 택서소스}
            /*
             * 0 : 빈 공간(이미지 : 바닥)
             * 1 : 부술 수 있는 블럭(이미지 : 걸상)
             * 2 : 부술 수 없는 블럭(이미지 : 책상)
             * 3 : 준비중
            */

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
                for(int j=0; j<15; ++j)
                {
                    if (arr[i, j] == 0)
                    {
                        continue;
                    }
                    else if (arr[i, j] == 1)
                    {
                        PictureBox_block[i, j] = new PictureBox();
                        PictureBox_block[i, j].Location = new Point(j * 50, i * 50);
                        PictureBox_block[i, j].Image = Properties.Resources.걸상;
                    }
                    else if (arr[i, j] == 2)
                    {
                        PictureBox_block[i, j] = new PictureBox();
                        PictureBox_block[i, j].Location = new Point(j * 50, i * 50);
                        PictureBox_block[i, j].Image = Properties.Resources.책상;
                    }
                    item_on_block[i, j] = random_();
                }
            }
        }
    }

}
