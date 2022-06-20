using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Helloform
{
     public partial class MyFirstClass
    {

        void Method01() //class 中未指定修飾詞時，預設為Private (only for 類別本身使用)
        {
            MessageBox.Show("Method01");
        }

        private void Method02()//Private (only for 類別本身使用)
        {
            MessageBox.Show("Method02");
        }

        public void Method03()//public (所有地方都可以使用)
        {
            MessageBox.Show("Method03");
        }

        internal void Method04()//internal (同一組件中所有的類別都可以使用)
        {
            MessageBox.Show("Method04");
        }
        public void Method05()//用public 呼叫當地的private方法
        {
            Method01();
            Method02();
        }

    }
    public class Usestatic
    {
        public int InstanceCount;
        public static int StaticCount; 
    }

}
