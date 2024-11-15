using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //产生随机数
            //1.创造能产生随机数的对象
            Random r = new Random();
            //放到循环外面，防止反复开辟空间，引起卡顿
            while (true)
            {
                //让产生随机数的这个对象调用方法来产生随机数
                int rNumber = r.Next(1, 11);
                //左闭右开
                Console.WriteLine(rNumber);
                Console.ReadKey();
                */
            Random r = new Random();
            while (true)
            {
                Console.WriteLine("请输入一个名字,我来判断他上辈子的死法");
                string name = Console.ReadLine();
                int rNumber = r.Next(1, 7);
                if (name == "李仕尧")
                {
                    Console.WriteLine("李仕尧是腰缠弯管，在众人的祝福下善终的");
                 }
                else
                {
                    switch (rNumber)
                    {
                        case 1:
                            Console.WriteLine("{0}上辈子是吃翔噎死的", name);
                            break;
                        case 2:
                            Console.WriteLine("{0}上辈子是被飞机撞死的", name);
                            break;
                        case 3:
                            Console.WriteLine("{0}上辈子是精尽而亡的", name);
                            break;
                        case 4:
                            Console.WriteLine("{0}上辈子是踩到香蕉皮摔死的", name);
                            break;
                        case 5:
                            Console.WriteLine("{0}上辈子是饿死的", name);
                            break;
                        case 6:
                            Console.WriteLine("{0}上辈子是玩游戏累死的", name);
                            break;
                        case 7:
                            Console.WriteLine("{0}上辈子是驴踹死的", name);
                            break;

                    }
                }
            }
            Console.ReadKey();




        }
    }
}

