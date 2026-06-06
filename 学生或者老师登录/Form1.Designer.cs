
namespace 学生或者老师登录
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(116, 112);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(52, 15);
            this.Name.TabIndex = 0;
            this.Name.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "密码";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(222, 102);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(268, 25);
            this.textName.TabIndex = 2;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(222, 174);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(268, 25);
            this.textPwd.TabIndex = 3;
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(119, 242);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(58, 19);
            this.rdoStudent.TabIndex = 4;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "学生";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Location = new System.Drawing.Point(365, 242);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(58, 19);
            this.rdoTeacher.TabIndex = 5;
            this.rdoTeacher.TabStop = true;
            this.rdoTeacher.Text = "老师";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(222, 312);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(105, 23);
            this.Login.TabIndex = 6;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(985, 490);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.rdoTeacher);
            this.Controls.Add(this.rdoStudent);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name);
            //this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoTeacher;
        private System.Windows.Forms.Button Login;
    }
}

