using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的调用
{
    //我们在main函数中调用test（）函数，称main为调用者，称test（）为被调用者
   //如果被调用者想要得到调用者的值：
   // 1.传递参数
   // 2.使用静态字段来模拟全局变量
   //如果调用者想要得到被调用者的值：
   // 1、返回值
    class Program
    {
        public static int _number = 10;
        //字段 属于类的字段
        static void Main(string[] args)
        {
            //int a = 3;
            //int res=Test(a);
            //Console.WriteLine(res);
            //Console.ReadKey();

            //bool b=IsRun(2000);
            //Console.WriteLine(b);
            //Console.ReadKey();

            //int a = 10;
            //int b = 20;
            //GetMax(a,b);//实参
            //同在一类中，类名可省略


            string str=Console.ReadLine();
            GetNumber(str);
        }
        public static int Test(int b)
        {
            b= b + 5;
            return b;
        }
        /// <summary>
        /// 判断给定的年份是否为闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsRun(int year)
        {
            bool b = ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));
            return b;
        }


        /// <summary>
        /// 计算两个整数之间的最大值 并且返回最大值
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <returns>返回最大值</returns>
        public static int GetMax(int n1,int n2)//形参
        {
            int max = n1 > n2 ? n1 : n2;
            return max;
        }
        //不管是形参还是实参都是在内存中开辟了空间


        //方法的功能一定要单一
        //方法中最忌讳的就是出现用户输入的字眼
        /// <summary>
        /// 判断用户输入的是否是数字
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetNumber(string s)
        {
            while(true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }

    }
}
