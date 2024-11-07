using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断年份
{
    class Program
    {
        static void Main(string[] args)
        {
            try//年份
            {
                Console.WriteLine("请输入一个年份");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入一个月份");
                        try//月份
                        {
                            int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2://由于有平年和闰年的不同，所以首先判断是否为闰年
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("输入的月份不符合要求，程序退出");
                        Console.ReadKey();
                    }
                        }//try月份的括号
                        catch//跟月份配对
                        {
                            Console.WriteLine("月份错误，程序退出");
                        }
                            //跟if配对


            }//try年份的括号
            catch//跟年份的try配对
            {
                Console.WriteLine("输入的年份有误，程序退出");
                Console.ReadKey();
             }
}
    }
        }
