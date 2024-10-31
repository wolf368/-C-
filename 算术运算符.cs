using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;  
            int n2 = 3;   //整数类型相除依然是整数
            double result = n1*1.0 / n2;  //*1.0转化为double类型
            Console.WriteLine("{0:0.00}",result);//保留两位小数
            Console.ReadKey();


            //int chinese = 90;
            //int math = 80;
            //int english = 67;
            //Console.WriteLine("总成绩是{0}，平均成绩是{1}",chinese + math + english, (chinese + math + english) / 3);
            //Console.ReadKey();


            //int number = 10;
            //double d = number;//自动类型转换 隐士类型转换（小范围转化为大范围）

            //double d = 303.6;
            //double--->int  强制类型转换 显示类型转换（大范围转小范围）
            //   +两边都是数字起相加作用，有任意一边是字符串则其链接作用
        }
    }
}
