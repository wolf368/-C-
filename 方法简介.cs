using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    class 方法简介
    {//一个函数（方法）就像一个专门做这件事的人，我们调用这个人让他做一些事
        //我们需要提供一些参数（条件）给他，执行完成后返还结果（参数值）


        /*
        方法：
        函数就是将一堆代码重用的一种机制
        函数的语法：
        [public] static 返回值类型 方法名([参数列表])
        {
            方法体;
        }
        public:访问修饰符，公开的公共的，哪都可以访问
        static：静态的
        返回值类型：如果不需要写返回值，写void
        方法名：Pascal 每个单词的首字母都大写，其余字母小写
        参数列表：完成这个方法所必须提供给这个方法的条件，如果没有参数小括号也不能省略
        */
        /// <summary>
        /// 计算两个整数间的最大值并且最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>

        //计算两个整数间的最大值
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
            //return:
            //1.在方法中返回要返回的值
            //2.立即结束本次方法（函数）
        }

        //方法写好后，如果想要被执行，必须要在Main函数中被调用。
        //方法的调用语法：
        //    类名.方法名([参数]);
        //在某些情况下类名可以省略，如果你写的方法跟main（）函数同在一个类中，这个时候类名可以省略
        static void Main(string[] args)
        {
            int max=方法简介.GetMax(1, 3);
            Console.WriteLine(max);
        }
        

    }
}
