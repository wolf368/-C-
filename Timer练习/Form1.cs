using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当窗体加载时，将系统时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒啦，关不掉了吧(*^▽^*)");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        /// <summary>
        /// 每隔一秒就把当前的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString();
            //7点30分15秒播放音乐
            if (DateTime.Now.Hour == 7 && DateTime.Now.Minute == 30 && DateTime.Now.Second == 15)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"";
                sp.Play();
            }
        }
    }
}
