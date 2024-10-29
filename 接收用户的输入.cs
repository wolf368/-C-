using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接受用户的输入
{
    class 接收用户的输入
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名");//同样具有暂停功能
            string name = Console.ReadLine();
            //string 可储存 3.14 11 男 张三等类型
            //接受用户在控制台台的输入
            Console.WriteLine("您的姓名是{0}",name);
            Console.ReadKey();

            Console.WriteLine("美女，你喜欢吃啥子哟");
            string food = Console.ReadLine();
            Console.WriteLine("haha,这么巧，我也喜欢吃{0}", food);
            Console.ReadKey();
        }
    }
}
