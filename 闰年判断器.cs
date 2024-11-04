using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 闰年判断器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的年份");
            int year =Convert.ToInt32(Console.ReadLine());
            //年份能够被四百整除
            //年份能够被4整除但不能被100整除
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            //逻辑与&&的优先级高于逻辑或||，但加()可以使结果一目了然
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
