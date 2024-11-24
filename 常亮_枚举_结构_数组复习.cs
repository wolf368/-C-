using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常亮_枚举_结构_数组复习
{
    class 常亮_枚举_结构_数组复习
    {
        public enum Gender//enum 为枚举关键字 规范开发
        {
            男,
            女,
            武装直升机
        }


        public struct Person//struct为结构的关键字 一次声明多个变量
        {
            public string _name;
            public string _age;
            public string _gender;    
        }

        static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._gender = "男";
            zsPerson._age = "21";

            //数组 可以一次存储多个相同类型的变量
            int[] number = new int[10];
            number[2] = 3;


            //Gender gender = Gender.武装直升机;
            //string s = "男";
            //Gender g = (Gender)Enum.Parse(typeof(Gender), s);


            //常量 枚举 结构 数组
            //const int number = 1;
        }
    }
}
