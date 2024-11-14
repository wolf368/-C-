
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 程序调试：
    1）f11逐语句调试（单步调试）
    2）F10逐过程调试
    3）断点调试
*/

namespace 断点调试
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("欢迎光临");
            //}
            //Console.ReadKey();


            //找出100—999间的水仙花数
            //水仙花数：百位的立方+十位的立方+各位的立方=当前这个百位数字
            //如153
            //百位：153/100
            //十位：153%100/10
            //个位：153%10
            //for (int i = 100; i <= 999; i ++)
            //{
            //    int b = i / 100;
            //    int s = i % 100 / 10;
            //    int g = i % 10;
            //    if (b * b * b + s * s * s + g * g * g == i)
            //    {
            //        Console.WriteLine("水仙花数{0}", i);
            //    }
            //    Console.ReadKey();

            //加法器
            Console.WriteLine("请输入一个数字");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=number;i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, number - i, number);
            }
            Console.ReadKey();
            
        }
    }
}
/*
for循环
   语法：
   for(表达式1；表达式2；表达式3)
   {
    循环体；
    }
表达式1一般为声明循环变量，记录循环次数（int=0；）
表达式2一般为循环条件（i<10)
表达式3一般为改变循环条件的代码，使循环条件终不再成立(i++)

过程：
先执行1，然后执行2，如果2返回的为true，执行循环体。
执行循环体后执行3，然后执行2，判断。true则循环，flase则跳出
*/