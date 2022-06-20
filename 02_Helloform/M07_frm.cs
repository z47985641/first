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
    public partial class M07_frm : Form
    {
        public M07_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member MB01 = new Member() ;
            MB01.Name = "林靖軒";
            MB01.Age = 25 ;
            MessageBox.Show("姓名 :" + MB01.Name + ", 年齡 :" + MB01.Age);
            // 將class 實作後給於資料並使用messgebox 顯示出來

            Member MB02 = new Member()
            {
                Name = "林**",
                Age = 28
            };
            //於實作時就將資料帶入

            MessageBox.Show("姓名 :" + MB02.Name + ", 年齡 :" + MB02.Age);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //this.button1.Click += new System.EventHandler(this.button1_Click);
            btnRegister01.Click += new EventHandler(btnRegister01Click);
            //加入btnRegister click事件
            btnRegister02.Click += BtnRegister02_Click;
            //使用 tab 鍵加入click事件
        }

        private void BtnRegister02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("register02 success");
            //click事件後的內容
        }

        private void btnRegister01Click(object sender, EventArgs e)
        {
            MessageBox.Show("register01 success");
            //click事件後的內容
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnRegister01.Click -= new EventHandler(btnRegister01Click);
            //利用-= 將事件解除
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Text = "變換成功";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult Result;

            Result = MessageBox.Show("今天禮拜日嗎?","問一下吧~", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //Messagebox 第一組string 文字為表單中顯示之文字其他應用 第二組為表單名稱
            //MessageBoxButtons->可以顯示其他按鈕 MessageBoxIcon-> 顯示圖示

            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("瘋了嗎?");
            }
            else
            {
                MessageBox.Show("好的");
             }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            M02_Hellofrm hellofrm = new M02_Hellofrm();
            hellofrm.ShowDialog();

            // 實作另一表單成為另一物件， ShowDialog() 為強制表單回應
            
            if (hellofrm .DialogResult  ==   DialogResult.OK)
            //若表單回傳DialogResult = OK 則顯示以下方法
            {
                MessageBox.Show("嗨嗨");
            }
        }
    }
}
