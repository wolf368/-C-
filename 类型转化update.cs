using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换update
{
    class 类型转化update
    {
        static void Main(string[] args)
        {
            //convert转换，成功就成功，失败就抛异常
            //int number=Convert.ToInt32("123abc")

            //int.Parse的效率稍高，convert本质是对parse的调用
            //int number = int.Parse("123abc");
            //Console.WriteLine(number);
            //Console.ReadKey();

            int number = 100;
            //tryparse为方法或者函数
            //方法就是帮你做一件事的人
            //bool 参数（完成一个方法所必须提供的条件） 返回值（看到的结果）
            bool b=int.TryParse("123abc", out number);
            Console.WriteLine(b);
            Console.WriteLine(number);
            Console.ReadKey();

        }
    }
}
