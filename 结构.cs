using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct person
    {
        public string _name;//字段
        public int _age;
        public Gender _gender;
    }
    public enum Gender
    {
        男,
        女
    }
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    class 结构
    {
        static void Main(string[] args)
        {
            //person zsPerson;
            //zsPerson._name = "zhangsan";
            //zsPerson._age = 21;
            //zsPerson._gender =Gender.男;
            //一次性声明多个变量
            //person lsPerson;
            //lsPerson._name = "lisi";
            //lsPerson._age = 21;
            //lsPerson._gender =Gender.女;
            //Console.WriteLine(zsPerson._name);
            //Console.WriteLine(lsPerson._name);
            //Console.ReadKey();
            //变量在程序运行期间只能存贮一个值，而字段可以储存多个值


            MyColor mc;
            mc._red = 255;
            mc._blue = 0;
            mc._green = 0;


        }
    }
}
