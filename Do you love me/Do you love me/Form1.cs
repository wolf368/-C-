using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_you_love_me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        /// <summary>
        /// 当鼠标进入按钮的可见部分是，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新坐标
            //按钮的最新坐标的范围 是窗体的宽度-按钮的宽度
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;

            Random r = new Random();
            //给按钮一个新的随机坐标
            button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(〃'▽'〃)");
            this.Close();//关闭主窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你这个屌丝点到了");
            this.Close();
        }
    }
}
