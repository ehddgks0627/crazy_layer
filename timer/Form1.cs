using System;
using System.Windows.Forms;

namespace Timer_oo
{
    public partial class Form1 : Form
    {
        private int TimerCount = 0;
        int i=2;

        public Form1()
        {
            InitializeComponent();

            TimerCount = 60;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label1.Text = i.ToString();
            TimerCount -= 1;
            label2.Text = TimerCount + "";
            
            if (TimerCount == 0)
            {

                TimerCount = 60;
                label1.Text = i.ToString();
                i--;
            }

            if (i == -1)
            {
                timer2.Stop();
                MessageBox.Show("Finish.");
            }
        }
    }
}