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
    public partial class M04_OPHelloFrm : Form
    {
        public M04_OPHelloFrm()
        {
            InitializeComponent();
        }

        private void BtnOPFrm_Click(object sender, EventArgs e)
        {

            // 開啟第二視窗
            M02_Hellofrm OpFrm = new M02_Hellofrm();
            OpFrm.Show();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            MyFirstClass M05 = new MyFirstClass(); //使用Method05 public呼叫 private 方法
            M05.Method05() ;
        }

        private void method_try_Click(object sender, EventArgs e)
        {
            MyFirstClass MTD = new MyFirstClass() ;

            // MTD.Method01(); -> method01 無法呼叫
            // MTD.Method02(); -> method02 無法呼叫
            MTD.Method03();
            MTD.Method04();

        }

        string BirthYear(int Age)
        {
            int birthday = DateTime.Now.Year - Age;//DateTime.Now.Year -> 抓取現今時間的年份(西元) 
            string Result = "您的出生年為" + birthday + "年"; // 宣告回傳變數型態需與方法的型態一致
            return Result ;//回傳值
        }
        private void OP_method_Click(object sender, EventArgs e)
        {
            string Year = BirthYear(25);//須將方法的回傳值再次宣告成新變數
            MessageBox.Show(Year);//顯示結果
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyFirstClass MTD = new MyFirstClass();// 使用partial clss 來讓不同分類檔可以共同執行同個分類
            MTD.Method06();
        }

        private void M04_OPHelloFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
