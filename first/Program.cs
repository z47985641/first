using _02_Helloform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            Console.Write("請輸入姓名: ");
            string NAME = Console.ReadLine();
            Console.Write("你好啊!"+NAME );

            MyFirstClass nc = new MyFirstClass() ; 
            // 呼叫另個專案中的class
            // 加入參考 -> 專案
            // 被呼叫的class 要注意修飾詞須能被其他專案呼叫(public)
            nc.Method06();

            Console.ReadKey() ;
        }
    }
}
