using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class bio100 : Form
    {
        //Set random var
        Random rnd = new Random();
        int number;
        public int timeLeft;

        int num = 0;
        //Arrays
        string[] Science = { "Calcium", "Hassium", "Iron", "Osmium", "Platinum", "Rhodium", "Thorium", "Zinc", "Mercury", "Lutetium" };
        string[] Symbols = { "Ca", "Hs", "Fe", "Os", "Pt", "Rh", "Th", "Zn", "Hg", "Lu" };



        //Store chosen element
        string element;

        public bio100 ()
        {
            InitializeComponent();
        }

        private void initiate()
        {
            //Choose and display random element
            number = rnd.Next(1, (Science.Length));
            element = Science[number];
            elementtxt.Text = element;

            //Clear text box for new question
            answertxt.Text = null;
        }

        private void bio100_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();

        }

        private void checkbtn_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            if (answertxt.Text == Symbols[number])
            {
                num = num + 100;
                timeLeft = 50;
                label3.Text = num.ToString();
                
            }
            else
            {
                num = num - 100;
                label3.Text = num.ToString();
               
            }
            initiate();
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
              timer1.Stop();
              timertxt.Text = "You Lose!";
              Startbtn.Enabled = true;
              checkbtn.Enabled = false;

            }
          
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            initiate();
            label3.Text = num.ToString();
            timeLeft = 50;
            timer1.Start();
            Startbtn.Enabled = false;
            checkbtn.Enabled = true;
        }
    }
}