using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._5
{
    class 异常捕获和变量的作用域
    {
        static void Main(string[] args)
        {
            bool b = true;
            int number=0;
            //try中的代码可能无法执行，所以系统会认为int未赋值，需让int有一个初始值
            Console.WriteLine("请输入一个数字");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(number * 2);
                //或者将此代码放外面
            }
            catch
            {
                Console.WriteLine("输入的内容不能转化成数字");
                b = false;
            }
            if (b)
            //b不是false，说明无异常
            {
                Console.WriteLine(number * 2);
            }

            Console.ReadKey();
        }
    }
}
/*
1.异常捕获：
    在程序中经常会出现各种异常，如果想使程序更稳定，
    可在代码中常用太容易—catch来进行异常捕获。
    语法：
    try
{
   可能会出现异常的代码；
}
    catch
{
    出现异常后要执行的代码；
}

执行过程：如果try中的代码出现异常，那么catch中的代码不会执行，
    如果try中的代码出现了异常的代码，后面还有一百行代码也不会执行，
    而是直接跳到catch中。

    变量的作用域：
    一般从从声明它的那个大括号开始到那个大括号所对应的结束的括号的结束。
    在这个范围内，我们可以访问并使用变量，超出范围则不能使用
*/