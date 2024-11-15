using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._14
{
    class 三元表达式
    {
        /*
        三元表达式
        语法：
            表达式1？表达式2：表达式3；
            表达式1一般为一个关系表达式。
            如果表达式1的值为true，那么表达式2的值就是整个三元表达式的值
            如果表达式1的值为false，那么表达式3的值就是整个三元表达式的值
            注意：2的结果类型必须跟3的结果类型一致，并且也要跟整个三元表达式的结果类型一致
        可替代if类型
        */
        static void Main(string[] args)
        {
            //比较得最大数
            Console.WriteLine("请输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int max = n1 > n2 ? n1 : n2;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
