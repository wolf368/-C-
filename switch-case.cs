using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            double salary = 5000;
            Console.WriteLine("请输入对李四年终奖的评定");
            string level = Console.ReadLine();
            /*
            if(level=="A")
            {
                salary += 500;//salary=salary+500
            }
            else if (level=="B")
            {
                salary += 200;
            }
            else if(level=="C")
            {
  
            }
            else if(level=="D")
            {
                salary -= 200;
            }
            else//输入的不是ABCD
            {
                Console.WriteLine("输入错误，程序错误");
                b = false;
            }
            if (b)
            {
                Console.WriteLine("李思来年的工资是{0}", salary);
                Console.ReadKey();*/

           switch(level)
            { 
                case "A":salary += 500;
                    break;
                case "B":salary += 200;
                    break;
                case "C":break;
                case "D":salary -= 200;
                    break;
                default:Console.WriteLine("输入错误，请再次输入");
                    break;
            }
            Console.WriteLine("李四明年的工资是{0}",salary);
            Console.ReadKey();
        }
    }
}
/*
switch-case：
用来处理多条件的定值判断
语法：
switch（变量或者表达式的值)
{   
    case 值1：要执行的代码；
    break；
    case 值2：要执行的代码；
    break；
    case 值3:要执行的代码；
    break；
    。。。。
    default：要执行的代码；
    break；
 }
执行过程：
程序执行到switch胡，首先将括号中变量或表达式计算出来，
然后拿着这个值依次跟每个case后面所带的值进行匹配
一旦匹配成功，则执行case所带的代码，执行完成后，遇到break，
跳出switch-case。
如果跟每个case所带的值都不匹配，就执行default，
如果连default都没有就什么都不做
*/
/*
    switch:一般只能用于等值比较
    if-else：可以处理范围
    switch能做的if else都能做
    也可以将范围值转化为定值，如int90,91，92,93,94.。。99除以10后都等于9
*/