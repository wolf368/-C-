using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("今天天气好\n处处好风光");
            //转义符就是一个“\”+一个特殊的字符，组成一个具有特殊意义的字符
            //   \n:表示换行


            //Console.ReadKey();
            //Console.WriteLine("我想在这里输入\"\"一个英文半角符号");
            //        \":表示一个英文半角的双引号；
            //Console.ReadKey();


            string name1 = "换手机都护东湖湾和";
            string name2 = "扩大开放交付物";
            string name3 = "成都电费";
            string name4 = "额吉分解";
            Console.WriteLine("{0}\t{1}" ,name1, name2);
            Console.WriteLine("{0}\t\t{1}" ,name3, name4);
            Console.ReadKey();
             //    \t:表示一个Tap键的空格
             //      \b:表n示一个退格键
              //     \r\n:windows操作系统不认识/n,只认识/r/n
              //     \\:表示一个\
        }      //     @:取消\在字符串中的转义作用;将字符串按原格式输出
    }
}
