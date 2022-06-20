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
    public partial class M015_CTS : Form
    {
        public M015_CTS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 100;
            MessageBox.Show("A:" + A);
            int B = A;
            MessageBox.Show("A:" + A + "B:" + B);
            B = 200;
            MessageBox.Show("A:" + A + "B:" + B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox TX = textBox1;

            TX.Text = "31457897";
            TX.BackColor = Color.Red;
            TX.ForeColor = Color.Green;


        }
    }
}
