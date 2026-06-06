using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生或者老师登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked || rdoTeacher.Checked)
            {
                string name = textName.Text.Trim();
                string pwd = textPwd.Text;
                if (rdoStudent.Checked)
                {
                    if (name == "student" && pwd == "student")
                    {
                        MessageBox.Show("学生登录成功");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                        textName.Clear();
                        textPwd.Clear();
                        textName.Focus();
                    }
                }
                else if (rdoTeacher.Checked)
                {
                    if (name == "teacher" && pwd == "teacher")
                    {
                        MessageBox.Show("教师登录成功");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                        textName.Clear();
                        textPwd.Clear();
                        textName.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择身份");
            }
        }
    }
}
