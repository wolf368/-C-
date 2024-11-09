using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环结构
{
    class while循环
    {
        static void Main(string[] args)
        {
            int a = 1;
            /*
            while(a<=100)
            {
                Console.WriteLine("我下次考试一定要细心\t{0}",a);
                a += 1;//a++;
            }
            */
            /*
            int sum = 0;
            while(a<=100)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }
                a++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            */


            /*
            //输入班级人数，然后依次输入学员成绩，计算平均成绩和总成绩
            //循环体：提示输入学员成绩，接收，转成整数类型，加到总成绩
            //循环条件；小于等于班级人数
            Console.WriteLine("请输入班级人数");
            int count = Convert.ToInt32(Console.ReadLine());
            float sum = 0;//存放总成绩
            int i = 1;//声明一个循环变量记录循环次数
            while(i<=count)
            {
                Console.WriteLine("请输入第{0}个学员的成绩",i);
                int score = Convert.ToInt32(Console.ReadLine());
                //表示把每一个学员的成绩加到总成绩当中
                sum += score;
                i++;
            }
            Console.WriteLine("{0}个人的班级总成绩是{1}，平均成绩是{2}",count,sum,sum / count);
            */
            /*
            //提示用户输入用户名和密码 要求用户名等于admin密码等于123
            //只要用户名或者密码错误就重新输入
            //但是，最多只能输三次
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string code = Console.ReadLine();
            int i = 1;
            while (name != "admin" ||code != "123")
            {
                Console.WriteLine("用户名或密码错误，请重新输入");
                name = Console.ReadLine();
                code = Console.ReadLine();
                i++;
                if (i <= 3)
                { }
                else
                {
                    Console.WriteLine("错误次数频繁，账户注销");
                    Console.ReadKey();
                    break;
                }
            }
            */


            string name = "";
            string pwd = "";
            do
            {
                Console.WriteLine("请输入用户名");
                name = Console.ReadLine();
                Console.WriteLine("请输入密码");
                pwd = Console.ReadLine();
            } while (name != "admin" || pwd != "123");
            Console.WriteLine("登陆成功");

            Console.ReadKey();
        }
    }
}
/*
循环结构：
    whelie循环：
    whlie（循环条件）
    {
    循环体：
    }
     执行过程：首先判断循环条件是否成立；成立，返回一个true，
    则执行循环体，执行完一次后，再次返回循环条件判断。
    依次类推，若不成立，则跳出循环。

    死循环：
    while(true)
    { }

    特点；先判断，再执行，有可能一遍循环都不执行

do-while:
    语法：
    do
    {
        循环体；
    }while（循环条件）
    执行过程：程序首先会执行do中的循环体，执行完成后，去判断do-while循环的循环条件，
               如果成立，则继续执行do中的循环体。
    特点：先循环，再判断

break:
1）跳出switch—case结构
2）跳出while循环
*/
