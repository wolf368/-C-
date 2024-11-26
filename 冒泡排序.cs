using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    //冒泡排序：就是将一个数组中的元素按照从小到大或者从大到小
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {9,8,7,6,5,4,3,2,1,0 };
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if(nums[j]>nums[j+1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            Array.Sort(nums);//array为数组，sort帮助升序排序
            //释放核打击
            Array.Reverse(nums);//翻转数组

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
        
    }
}
