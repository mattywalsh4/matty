using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_game
{
    public partial class Form1 : Form
    {
        public int timeLeft;
        public int a;
        public int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            Random r = new Random();
            a = r.Next(12);
            b = r.Next(12);
            label1.Text = a.ToString();
            label2.Text = b.ToString();

            timer1.Start();

            Startbtn.Enabled = false;
            Donebtn.Enabled = true;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timertxt.Text = timeLeft.ToString();
            }
            if (timeLeft == 0)
            {
                Donebtn.Enabled = false;
                Startbtn.Enabled = true;
                timer1.Stop();
                timertxt.Text = "You Lose!";

            }
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            Donebtn.Enabled = false;
            Startbtn.Enabled = true;
            timer1.Stop();

            int c = a + b;
            if (ansertxt.Text == c.ToString()) 
            {
                timer1.Stop();
                timertxt.Text = "You Win!";
            } else 
            {
                timertxt.Text = "You Lose!";
            }

        }
    }
}
