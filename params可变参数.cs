using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params可变参数
{
    class params可变参数
    {
        static void Main(string[] args)
        {
            Test("张三", 311343334,99, 98, 77);
            Console.ReadKey();
        }
        //params可变参数
        //    将实参列表中跟可变参数数组类型一致的元素都当做数组当中的元素
        public static void Test(string name,int id, params int[] score)//params必须是形参中的最后一位
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}本次的成绩是{1},学号是{2}", name, sum,id);
        }
    }
    

}
