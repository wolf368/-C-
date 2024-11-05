using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 如果结构
{
    class 如果结构
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的学习时间");
            //int mins = Convert.ToInt32(Console.ReadLine());
            //if(mins>60)
            //{
            //    Console.WriteLine("辛苦了，你可以去玩电脑了");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("爬，滚去学习");
            //}
            //Console.ReadKey();



            //Console.WriteLine("请输入学员的成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score>=90)
            //{
            //    Console.WriteLine("A");
            //}
            //if(score>=80&&score<90)
            //{
            //    Console.WriteLine("B");
            //}
            //if (score>=70&&score<80)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score>=60&&score<70)
            //{
            //    Console.WriteLine("D");
            //}
            //if(score<60)
            //永远与跟他最近的if配对,所以此处只要不在60到70范围内都会输出E，
            //故此处不可用else
            //{
            //    Console.WriteLine("E");
            //}
            //Console.ReadKey();



            Console.WriteLine("请输入用户密码");
            string swd = Console.ReadLine();
            if (swd == "123456")
            {
                Console.WriteLine("登录成功");
                     Console.ReadKey();
            }
            else//要求用户再次输入
            {
                Console.WriteLine("密码错误，请再次输入");
                swd = Console.ReadLine();
                if (swd == "123456")
                {
                    Console.WriteLine("登陆成功");                 
                }
                else//第二次错误
                {
                    Console.WriteLine("密码第二次错误，程序终止");
                }
            }
            Console.ReadKey();
        }//最后一行代码要留三个括号
    }
}
/*
顺序结构：程序从main函数进入。从上到下一行一行执行，不会落下任何一行
分支结构：if  if-else
选择结构：if else-if switch-case
循环结构：while do-while for for-each


if语句：（分支结构）
语法：
if（判断条件）
{
要执行的代码；
}
判断条件：一般为关系表达式或者bool类型的值
过程：判断if小括号中的判断条件，true则执行，flase则跳过
if结构特点：先判断，再执行，有可能一行代码都不执行

if else（分支结构）
语法：
if（判断条件）
{
  执行的代码；
}
执行过程：程序执行到if。首先判断if小括号的条件是否成立。
如果成立，也就是返回一个true，则执行if所带大括号中的代码
执行完成后，跳出if-else结构。
如果if所带的小括号判断条件不成立，即返回一个false，
则跳过if，执行else大括号中的语句，完成后跳出if-else结构
特点：先判断，再执行，最少执行一行代码


if else-if（选择结构）只执行一种情况。
作用：用来处理多条件的区间性判断
语法：
if（判断条件）
{
  要执行的代码；
}
else if
{
要执行的代码；
}
else if
{
要执行的代码；
}
。。。。
else
{
要执行的代码；
}
执行过程：首先判断第一个是否成立，如果条件成立，
也就是返回一个true，执行完成后，立即跳出if-else结构。
如果不成立，则依次向下判断。如果每个if都不成立，则执行else
。如果连else都没有则什么也不做。

*/