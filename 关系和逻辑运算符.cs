using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关系和逻辑运算符
{
    class 关系和逻辑运算符
    {
        static void Main(string[] args)
        {
            //bool b = 1500 > 1;
            //Console.WriteLine(b);
            //Console.ReadKey();

            Console.WriteLine("小苏输入你的语文成绩");
            //string strChinese = Console.ReadLine();
            double chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("小苏，请输入你的数学成绩");
            double math = Convert.ToDouble(Console.ReadLine());
            bool b = math > 90 && chinese > 90;
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
/*
关系运算符：
    >
    <
    <=
    >=
    ==
    ！=

bool类型
再C#中用Bool类型描述对或者错
bool类型只有两个值 一个true 一个false


逻辑运算符：
    &&逻辑与
    ||逻辑或
    ！逻辑非
逻辑运算符两边一般都是关系表达式或bool类型的值
&&要比&效率更高，||同理。因为%%和||只要前面满足后练就不在计算，而&和|运算到底

复合赋值运算符：
+= 
int number=10;
number+=20;//是number=number+20的缩写
number=30
-=
*=
/=
%=
*/
    
