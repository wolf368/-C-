using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    class ref参数
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey(); 


        }
        public static void JiangJin(ref double salary)
        {
            salary += 500;
        }
    }    
    //ref参数
    //    能够将一个变量带入到一个方法中改变，改变完成后，再将改变后的值带出方法
}   //    因此要求在方法外赋值
    //out参数无需在方法外赋值
