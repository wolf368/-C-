using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    /*
枚举
    语法：
    {public} enum 枚举名
    {
        值1，
        值2，
        值3，
    。。。。
    }
    public：访问修饰符，公开的公共的，哪都可以访问
    enum：关键字，声明枚举的关键字
    枚举名：要符合Pascal命名规范
    规范开发
    枚举就是一个变量类型，int double string
     只是枚举的声明、赋值、使用的方式跟那些普通的变量类型不一样
    */



    //将枚举声明到命名空间下面，类的外面，表示这个命名空间下，所有的类都可以使用这个枚举
    //public enum Gender
    //{
    //    男,
    //    女
    //}
    //声明了一个枚举 Gender

    //public enum Sesons
    //{
    //    春,
    //        夏,
    //        秋,
    //        冬
    //}

    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave=5,
        Busy,
        QMe
    }
    class 枚举
    {
        //大学管理系统
        //性别 年龄 性别 系别年级
        //性别
        static void Main(string[] args)
        {
            //Gender gender = Gender.男;
            //Sesons s = Sesons.春;


            #region 将枚举强转为int
            //QQState state = QQState.OnLine;
            //枚举类型默认可以跟int类型相互转换 枚举类型跟int类型兼容
            //默认从零开始,依次递增，也可为枚举赋上数值，接下来依然会依次递增
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion


            #region 将int强转为枚举
            //int n1 = 5;
            //QQState state = (QQState)n1;
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion

            #region 将枚举类型转化成字符串类型
            //QQState state2 = QQState.QMe;
            //string s = state2.ToString();
            //Console.WriteLine(state2);
            //Console.ReadKey();
            #endregion

            #region 将字符串转化为枚举类型
            //string s = "0";
            //将s转为枚举，不可强转
            //convert.toint32() int.parse() int.TryParse()
            //调用Parse（）方法的目的就是为了让他帮助我们将一个字符串转换成对应的枚举类型
            //
            //(要转化的枚举类型)Enum.Parse(typeof(要转化的枚举类型),"要转化的字符串")
            //如果要转化的为数字，则就算枚举中没有也不会抛异常
            //要转化的为文本，如果枚举中没有，则会抛异常
            #endregion

            Console.WriteLine("请选择您的QQ在线状态 1_Online 2_OffLine 5_Leave 6_Busy");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
            }
            Console.ReadKey();
        }
    }
}
