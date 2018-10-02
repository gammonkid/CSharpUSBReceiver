using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFF_Generic_HID_Demo_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int val;

        public int Value
        {
            get { return val; }
            set { val = value; }
        }
        public int init
        {
            set {
                trackBar1.Value = value;
                Sensitivity.Text = value.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Value = trackBar1.Value;
            Sensitivity.Text = Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
