using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Helloform
{
    partial class MyFirstClass
    {
        public void Method06()// 使用partial clss 來讓不同分類檔可以共同執行同個分類
        // 唯一注意namespace 及class名字需一致
        { 
            Method03();
            Method04();
            Method05();
        }
    }

    public class Member
    {
        public string Name;
        public int Age;
        // 建立資料 設定字串的姓名及數字的年齡

    }
}
