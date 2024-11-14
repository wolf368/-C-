using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue和质数
{
    class Program
    {
        static void Main(string[] args)
        {
            ////计算从1到100除了能被7整除的数之和
            //int i = 1;
            //int sum = 0;
            //while(i<=100)
            //{
            //    if(i%7==0)
            //    {
            //        i++;
            //        continue;//回到循环条件，以下指令不执行
            //        Console.WriteLine("该行代码不执行");
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.ReadKey();

            //找出100内的质数
            //素数、质数：只能被1和本身整除

            for (int i = 2; i <=100; i++)
            {
                bool b = true;
                for (int j =2; j < i; j++)
                {
                    if(i%j==0)
                    {
                        b = false;
                        break;//除尽说明不为质数，也就没有继续的必要了
                    }
                }
                if(b)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
