using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 占位符
{
    class 占位符和交换变量
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 20;
            //int n3 = 30;
            //Console.WriteLine("第一个数字是{0},第二个数字是{1},第三个数字是{2} ", n1, n2, n3);//占位符
            //Console.WriteLine("第一个数字是" + n1 + "，第二个数字是" + n2 + "，第三个数字是" + n3 + "。");//连接符
            //Console.ReadKey();


            int n1 = 10;
            int n2 = 20;
            int temp = n1; //此时n1仍为10，temp也为10
            n1 = n2;
            n2 = temp;
            Console.WriteLine("交换后n1的值是{0}，n2的值是{1}",n1,n2);
            Console.ReadKey();
        }
    }
}
//挖几个坑填几个坑，少填没效果
//                ，多填出异常
//    输出顺序：按照挖坑的顺序