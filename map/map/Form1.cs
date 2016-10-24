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
            
            int i=0;
            PictureBox[] PictureBox_Num = new PictureBox[255];

            while (true)
            {
                //if(there is no message from server){
                //quit this looping
                //}
                Blocks newblock;
                PictureBox_Num[i] = new PictureBox();
                PictureBox_Num[i].Size = new Size(50, 50);
                //newblock.x=post_query("http://layer7.kr/)
                //newblock.y=post_query("http://layer7.kr/)
                //PictureBox_Num[i].Location = new Point(newblock.x, newblock.y);
                //newblock.item_info=post_query("http://layer7.kr/)
                //PictureBox_Num[i]
                //newblock.block_type=post_query("http://layer7.kr/")
                //newblock.block_image= 어쩌구 저쩌구
                //이미지를 서버에서 받아오는건지 아니면 맵에 저장된걸 불러오는건지 모르겠음.
                ++i;
            }

        }

        
        

        
        public class Blocks
        {
            public int x=0;
            public int y=0;
            public int item_info=0;
            /* 서버에서 값 받아오는게 명확해지면 이 주석은 이제 필요없습니다. 
             * 0 : no item
             * 1 : 물풍선 개수 증가
             * 2 : 이동 속도 증가
             * 3 : 물풍선 화력 증가
             * 4 : 탈것:부엉이
             * 5 : 탈것:느린거북이
             * 6 : 탈것:빠른거북이
             * 7 : 물풍선에 갇혔을때 탈출가능한 바늘
             * 8 : 2초동안 무적 
            */
            public int block_type=0;
            /*
             * 서버에서 값 받아오는게 명확해지면 이 주석은 이제 필요없습니다.
             * 0 : 부술 수 있는 블럭
             * 1 : 부술 수 없는 블럭
             * 2 : 옮길 수 있는 블럭
            */
            public int block_image=0;
            /*
             * 이건 이미지 받으면 나중에 추가하는걸로
            */

        }

        

    }

}
