using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋
{
    class 飞行棋
    {
        //画游戏头
        //初始化地图
        //将整数数组中的数字变成控制台中显示的特殊字符串的过程就是初始化地图
        public static int[] Maps = new int[100]; //默认全为0
        //用静态字段模拟全局变量
        static int[] PlayerPos = new int[2];
        //存储两个玩家的姓名
        static string[] PlayerNames = new string[2];

        static bool[] Flags = new bool[2];//Flags[1]是玩家A的标志 Flags[2]是玩家B的标志 默认全为false

        static void Main(string[] args)
        {
            GameShow();

            #region 输入玩家姓名           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家的姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while(PlayerNames[0]==PlayerNames[1]||PlayerNames[1]=="")
            {
                if(PlayerNames[1]=="")
                {
                    Console.WriteLine("玩家的姓名不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能与玩家A的姓名相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }

            }
            #endregion

            //玩家姓名输入后，我们应该先清屏
            Console.Clear();
            GameShow();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}的姓名用A表示", PlayerNames[0]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}的姓名用B表示", PlayerNames[1]);
            
            //在画地图前应先初始化地图，否则地图各个元素全为0，无法画出其它元素
            InitalMap();
            DrawMap();

            while(PlayerPos[0]<99&&PlayerPos[1]<99)
            {
                if (Flags[0] == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("玩家{0}无耻地赢了玩家{1}", PlayerNames[0], PlayerNames[1]);
                    Console.ReadKey();
                    break;
                }
                if (Flags[1] == false)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("玩家{0}无耻地赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    Console.ReadKey();
                    break;
                }

            }//while

            Console.ReadKey(true);//按下的键不显示在控制台中
        }

        /// <summary>
        /// 画游戏头
        /// </summary>
        public static void GameShow()
        {
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****双人骑士版飞行棋*****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************");
        }

        /// <summary>
        /// 地图初始化
        /// </summary>
        public static void InitalMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)//暂停
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }
        
        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘：☆  地雷：×  暂停：△  时空隧道：卐 ");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }//for
            #endregion

            //画完第一横行换行
            Console.WriteLine();

            #region 第一竖行
            for (int i=30;i<35;i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
               Console.Write( DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion

            #region 第二横行
            for (int i = 64; i>=35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();

            #region 第二竖行
            for (int i = 65; i < 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第三横行
            for (int i = 70; i < 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion

            Console.WriteLine();


        }//DrawMap方法的结尾

        public static string DrawStringMap(int i)
        {
            string str = "";
            #region 画图
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                str="<>";
            }
            else if (PlayerPos[0] == i)
            {
                str="A";
            }
            else if (PlayerPos[1] == i)
            {
                str="B";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str="□ ";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        str = "× ";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "△ ";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "卐";
                        break;

                }//switch
            }//else
            return str;
            #endregion
            
        }
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷骰子", PlayerNames[playerNumber]);
            Console.ReadKey();
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playerNumber], rNumber);
            PlayerPos[playerNumber] += rNumber;           
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            if (PlayerPos[playerNumber] == PlayerPos[1- playerNumber])
            {
                Console.WriteLine("玩家{0}踩到玩家{1}，玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1- playerNumber], PlayerNames[1- playerNumber]);
                PlayerPos[1- playerNumber] -= 6;
                Console.ReadKey(true);
            }
            else//踩到关卡
            {
                //玩家坐标
                switch (Maps[PlayerPos[playerNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:                       
                        Console.WriteLine("玩家{0}踩到了幸运方块，请选择交1--交换位置 2--轰炸对方",PlayerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerNames[playerNumber], PlayerNames[1- playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1- playerNumber];
                                PlayerPos[1- playerNumber] = temp;
                                Console.WriteLine("交换完成！！！按任意键继续");
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1},玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1- playerNumber], PlayerNames[1- playerNumber]);
                                Console.ReadKey(true);
                                PlayerPos[1- playerNumber] -= 6;
                                
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[playerNumber]);
                                Console.ReadKey(true);
                                break;

                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2 1--交换位置 2--轰炸对方");
                                input = Console.ReadLine();

                            }

                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        PlayerPos[playerNumber] -= 6;
                        ChangePos();
                        break;
                    case 3: Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playerNumber]);
                        PlayerPos[0] += 10;
                        Console.ReadKey(true);
                        break;
                }//switch
            }//else
            Console.Clear();
            ChangePos();//perfect
            DrawMap();
        }

        public static void ChangePos()
        {
            if(PlayerPos[0]<0)
            {
                PlayerPos[0] = 0;
            }
            if(PlayerPos[0]>99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] > 99)
            {
                PlayerPos[0] = 99;
            }
        }
    }

}
