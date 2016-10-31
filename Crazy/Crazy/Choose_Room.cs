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
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Crazy
{
    public partial class Choose_Room : Form
    {
        int key;
        Thread t;
        send_sock chat_send;
        listen_sock chat_listen;
        public Choose_Room(int k = 0)
        {
            chat_send = new send_sock("239.0.0.222", 2222);
            chat_listen = new listen_sock("239.0.0.222", 2222);
            t = new Thread(chat_listen.listen);
            t.Start();
            InitializeComponent();
            key = k;
        }

        public static int Check_chatting = 0;

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length != 0 && e.KeyCode == Keys.Enter)
            {
                chat_send.sendbuf(textBox1.Text);
                textBox1.Text = "";
                Chatting_Box.SelectedIndex = Chatting_Box.Items.Count - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Room frm = new Search_Room(key);
            frm.Owner = this;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Make_Room frm = new Make_Room(key);
            frm.Owner = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Shop frm = new Shop();
            frm.Owner = this;
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Check_chatting == 0)
            {
                textBox1.Text = "";
                Check_chatting = 1;
            }
        }

        public static int Page_Num = 1;

        private void button4_Click(object sender, EventArgs e)
        {
            Page_Num--;
            label2.Text = "" + Page_Num;
            this.Visible = false;
            Choose_Room frm = new Choose_Room();
            frm.Owner = this;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Page_Num++;
            label2.Text = "" + Page_Num;
            this.Visible = false;
            Choose_Room frm = new Choose_Room();
            frm.Owner = this;
            frm.Show();

        }

        private void PictureBox_Num(object sender, EventArgs e)
        {
            Console.WriteLine("{0}", sender);
            this.Visible = false;
            before_game frm = new before_game(key);
            frm.Owner = this;
            frm.Show();
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Quit_ask frm = new Quit_ask(); // 새 폼 생성
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            start frm = new start(); // 새 폼 생성
            frm.Show();
            this.Close();
        }

        public class send_sock
        {
            public UdpClient udpclient = null;
            private IPAddress multiaddress;
            private IPEndPoint remoteEP;
            byte[] buffer = null;
            public send_sock(string ip, int port)
            {
                udpclient = new UdpClient();
                multiaddress = IPAddress.Parse(ip);
                udpclient.JoinMulticastGroup(multiaddress);
                remoteEP = new IPEndPoint(multiaddress, port);
            }
            public bool sendbuf(string message)
            {
                buffer = Encoding.Unicode.GetBytes(message);
                udpclient.Send(buffer, buffer.Length, remoteEP);
                return true;
            }
            public void closesock()
            {
                if (udpclient != null)
                    udpclient.Close();
                else
                    MessageBox.Show("서버 안열림여");
            }
        }
        public class listen_sock
        {
            public UdpClient udpclient = null;
            public IPAddress multiaddress;
            private IPEndPoint localEp;
            public listen_sock(string ip, int port)
            {
                udpclient = new UdpClient();

                udpclient.ExclusiveAddressUse = false;
                localEp = new IPEndPoint(IPAddress.Any, 2222);

                udpclient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpclient.ExclusiveAddressUse = false;

                udpclient.Client.Bind(localEp);

                multiaddress = IPAddress.Parse("239.0.0.222");
                udpclient.JoinMulticastGroup(multiaddress);
            }
            public void listen()
            {
                while (true)
                {
                    byte[] data = udpclient.Receive(ref localEp);
                    string strData = Encoding.Unicode.GetString(data);
                    MessageBox.Show(strData);
                    
                    if (strData == "quit")
                        break;
                }
            }
            public void close()
            {
                udpclient.Close();
            }
        }
    }
}