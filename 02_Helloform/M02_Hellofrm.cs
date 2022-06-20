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
    public partial class M02_Hellofrm : Form
    {
        public M02_Hellofrm()
        {
            InitializeComponent();
        }

      
        private void Btn_name_Click(object sender, EventArgs e)
        {
            String NAME = TXT_name.Text ;
            MessageBox.Show("你好啊!" + NAME);

         }
    }
}
