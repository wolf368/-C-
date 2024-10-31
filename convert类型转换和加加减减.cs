using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert类型转换
{
    class convert类型转换和加加减减
    {//如果两个类型变量不兼容，可用convert转换
        static void Main(string[] args)
        {
            //string s = "123";
            ////将字符串转化为doube或intleixing
            //double d =Convert.ToDouble(s);
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(d);
            //Console.WriteLine(n);
            ////Console.ReadKey();
            ///

            //Console.WriteLine("请输入你的姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入你的语文成绩");
            //string strChinese=Console.ReadLine();
            //Console.WriteLine("请输入你的数学成绩");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("请输入你的英语成绩");
            //string strEnglish = Console.ReadLine();
            //由于字符串相加等于相连，如果要用字符串类型的变量计算
            //则需要将字符串转换为int或double
            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);
            //Console.WriteLine("{0}你的总成绩是{1}，平均成绩是{2}", name, chinese + math + english, (chinese + math + english) / 3);
            //Console.ReadKey();


            Console.WriteLine("请输入一个数字");
            //Console.ReadLine();  可省略，简化变量
            double number = Convert.ToDouble(Console.ReadLine());
            //输入默认为string类型
            Console.WriteLine(number * 2);
            Console.ReadKey();


        }
    }
}
/*
加加减减：
    ++：++分为前++和后++，但最终都是给变量加一
    --:同上
    例如：
    number=10
    result=10+ ++number=21
    result=10+ number++=20
    但++number或number++都=11
    运算中，后加加是先拿原值运算再自身加1
    前加加是自身先加1，再参与运算
    例如
    int a=5;
    int b=a++ + ++a*2+ --a + a++；
        b=  5+7*2+6+6
        a=7
