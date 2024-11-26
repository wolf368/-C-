using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    //数组:
    //一次性储存多个相同变量。
    //语法:
    //    数组类型[] 数组名 数组类型[数组长度];
    class Program
    {
        static void Main(string[] args)
        {
            //数组类型[] 数组名=new 数组类型[数组长度]；
            //int[] nums = new int[10];
            //此时已在内存中开辟了10块连续的空间，我们管每一块空间叫做这个数组的元素
            //如果想要访问数组中的某一个元素，需要这个元素的下标或索引
            //下标或索引从0开始
            //nums[0] = 1;
            //nums[1] = 2;
            //nums[2] = 3;
            //nums[3] = 4;
            //nums[4] = 5;
            //nums[5] = 6;
            //nums[6] = 7;
            //nums[7] = 8;
            //nums[8] = 9;
            //nums[9] = 10;
            //for (int i = 0; i < nums.Length; i++)//已知循环次数
            //{
            //    nums[i] = i+1;
            //}
            //我们通过循环给数组赋值，同样通过循环对数组进行取值
            //for (int i = 0; i <nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);

            //}
            //Console.ReadKey();

            //string[] str = new string[10];//此时只有10个null
            ////null表示未开空间 ""表示在内存中已开空间，但所存为空
            //bool[] bolls = new bool[10];//此时元素全为false

            ////数组类型[] 数组名=new 数组类型[数组长度]；
            ////int[] nums = new int[10];

            ////数组的声明方式
            ////int[] numsTwo = { 1, 2, 3, 4, 5, 6, 7 };
            ////int[] numsThree = new int[3] { 1, 2, 3 };


            ////从一个数组中取出最大的整数，最小的整数，总和，平均值
            ////声明一个int类型的数组 并且随意赋值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////声明两个变量用来存最大值和最小值
            //int max = nums[0];//先假定第一个元素为最大或最小
            //int min = nums[0];
            //int sum = 0;
            ////循环比较
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //关于循环中nums【i】的理解方式
            //    //1.代表数组中循环到的元素
            //    //2.代表数组的每个元素
            //    //如果数组中循环到的元素比max大，则赋值给max
            //    if(nums[i]>max)
            //    {
            //        max = nums[i];
            //    }
            //    if(nums[i]<min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];

            //}
            //Console.WriteLine("这个数的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, sum /nums.Length);
            //Console.ReadKey();


            //string[] names = { "老杨", "老牛", "老马", "老张", "老王", "老李" };
            //string name = null;
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    name += names[i] + "|";
            //}
            //Console.WriteLine(name+names[names.Length-1]);
            //Console.ReadKey();

            string[] str = { "我", "是", "好人" };
            for (int i = 0; i < str.Length/2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - i] = temp;
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();
        }
    }
}
