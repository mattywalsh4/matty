using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gibjohn8
{
    public partial class Form1 : Form
    {
        Class1 call = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            call.change(button1.Text, "username");
            @class frm = new @class();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            @class frm1 = new @class();
            frm1.TopLevel = false;
            frm1.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm1);
            frm1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            signin frm = new signin();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}
