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
    public partial class @class : Form
    {
        public @class()
        {
            InitializeComponent();
        }

        private void class_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_class frm = new new_class();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            join_class frm1 = new join_class();
            frm1.TopLevel = false;
            frm1.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm1);
            frm1.Show();
        }
    }
}
