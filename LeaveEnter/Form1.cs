using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
