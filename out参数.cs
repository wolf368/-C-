using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数的使用
{

    class out参数
    {
        static void Main(string[] args)
        {
            /*
            //写一个方法 求一个数组中的最大值、最小值、总和、平均值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //将要返回4个值，放到一个数组中返回
            int[] res=GetMaxMinSumAvg(numbers);
            Console.WriteLine("最大值是{0},最小值是{1},总和是{2},平均值是{3}", res[0], res[1], res[2], res[3]);
            Console.ReadKey();
            */

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int newmax = 0;
            //int newmin = 0;
            //int newsum = 0;
            //int newavg = 0;
            //Test(numbers, out newmax,out newmin,out newsum,out newavg);
            //Console.WriteLine(newmax);
            //Console.WriteLine(newmin);
            //Console.WriteLine(newsum);
            //Console.WriteLine(newavg);
            //Console.ReadKey();



            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string userPwd = Console.ReadLine();
            string msg;
            bool b = IsLongin(userName, userPwd, out msg);
            Console.WriteLine("登录结果{0}", b);
            Console.WriteLine("登录信息{1}", msg);
            Console.ReadKey();
            
        }
        //public static int[] GetMaxMinSumAvg(int[] nums)
        //{
        //    int[] res = new int[4];
        //    //假设res【0】存最大值 res【1】存最小值 res【2】存最小值 res【3】平均值
        //    res[0] = nums[0];//max
        //    res[1] = nums[1];//min
        //    res[2] = 0;//sum
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if(nums[i]>res[0])
        //        {
        //            res[0] = nums[1];
        //        }
        //        if(nums[i]<res[1])
        //        {
        //            res[1] = nums[i];
        //        }
        //        res[2] += nums[1];
        //        res[3] = res[2] / nums.Length;
        //    }
        //    return res;
        //}

        //out参数
        //    如果你在一个方法中，返回多个相同类型的值的时候，可以考虑返回一个数组，
        //    但是，如果返回多个不同类型的值的时候，返回数组就不可行，这个时候考虑out参数
        //    out参数就侧重在一个方法中可以返回多个不同类型的值


        /// <summary>
        /// 计算一个整数数组的最大值、最小值、平均值、总和
        /// </summary>
        /// <param name="nums">要求值的数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void Test(int[]nums,out int max,out int min,out int sum,out int avg)
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[1];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
                
            }
            avg = sum / nums.Length;
        }
        /// <summary>
        /// 判断用户登录是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">多余返回的登录信息</param>
        /// <returns>返回登录结果</returns>
        public static bool IsLongin(string name,string pwd,out string msg)
        {
            if(name=="admin"&&pwd=="123")
            {
                msg = "登录成功";
                return true;
            }
            else if(name=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if(pwd=="123")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }
    }
}
