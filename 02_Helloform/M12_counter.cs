using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Helloform
{
    public partial class M12_counter : Form
    {
        public M12_counter()
        {
            InitializeComponent();
        }
        int I;
        private void button1_Click(object sender, EventArgs e)
        {
            
            I += 1;
            label1.Text = "Count :" + I;
        }
        UseStatic us = new UseStatic();

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
