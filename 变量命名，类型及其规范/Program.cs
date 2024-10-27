using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量的认识
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;//声明或定义了整数类型的变量
            number = 20;
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
//红色波浪线：语法错误    绿色波浪线：警告线，可能会出现错误。
//存储变量的语法:
//变量的类型 变量名;
//变量名 = 值；

//如果要使用变量，需要先声明再赋值再使用

//    int(代表整数类型）


//    int number://在内存中开辟了一块能够存储整数的空间
//   number = 100;//表示把100存储到了这个空间内

//   = 表示赋值

//double= 3.14; //既能表示小数类型，也能表示整数类型，小数点后15到16位

//string zsname = "张三abc";
//string 表示字符串类型，可存储多个文本
//同时字符串类型的值必须用""括起来
//string s="";//字符串可以存储 空
//  string 蓝色字体，独属于C#      String 几种语言都有
//char
//    char gender = '男';
//字符只能存一个，且不能为空。

// decimal money = 100m;
//    decimal 金钱类型，值后需加上一个m/M（money的缩写），可精确到小数点后
//    精度极高
命名/*规则：
    *****首先要保证变量有意义，既能让他人一目了然
    1）给变量起名字必须以字母开头（现阶段）。
    2）后面可以跟任意字母，数字，下划线。
    注意：
    1）起的名字不要与C#系统中的关键字重复
    2）在C#中大小写是敏感的
    3）同一个变量名不允许被重复定义或声明；

    命名规范:
    1.Camel 骆驼命名规范。要求变量名首单词要小写，其余每个单词的首字母要大写
    多用于给变量的命名
    2.Pascal 命名规范：要求每个单词的首字母都要大写，其余字母小写
    多用于给类或方法命名*/