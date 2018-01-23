namespace library4
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.loginradioButton5 = new System.Windows.Forms.RadioButton();
            this.loginradioButton4 = new System.Windows.Forms.RadioButton();
            this.loginbutton = new System.Windows.Forms.Button();
            this.logintextBoxuserpassword = new System.Windows.Forms.TextBox();
            this.loginlabel3 = new System.Windows.Forms.Label();
            this.logintextBoxusername = new System.Windows.Forms.TextBox();
            this.loginlabel2 = new System.Windows.Forms.Label();
            this.loginradioButton3 = new System.Windows.Forms.RadioButton();
            this.loginradioButton2 = new System.Windows.Forms.RadioButton();
            this.loginradioButton1 = new System.Windows.Forms.RadioButton();
            this.loginlabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "读者界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Welcome to Soon\'s Library";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(102, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "只显示可借阅的";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 153);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 21);
            this.textBox4.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "出版社：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 127);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 21);
            this.textBox3.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "作者：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "empty",
            "technology",
            "math",
            "story"});
            this.comboBox1.Location = new System.Drawing.Point(69, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 20);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 100);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 21);
            this.textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 73);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 21);
            this.textBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "书编号：";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "查询图书";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(564, 245);
            this.dataGridView1.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.loginradioButton5);
            this.tabPage2.Controls.Add(this.loginradioButton4);
            this.tabPage2.Controls.Add(this.loginbutton);
            this.tabPage2.Controls.Add(this.logintextBoxuserpassword);
            this.tabPage2.Controls.Add(this.loginlabel3);
            this.tabPage2.Controls.Add(this.logintextBoxusername);
            this.tabPage2.Controls.Add(this.loginlabel2);
            this.tabPage2.Controls.Add(this.loginradioButton3);
            this.tabPage2.Controls.Add(this.loginradioButton2);
            this.tabPage2.Controls.Add(this.loginradioButton1);
            this.tabPage2.Controls.Add(this.loginlabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户登录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(477, 117);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "超级管理员";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // loginradioButton5
            // 
            this.loginradioButton5.AutoSize = true;
            this.loginradioButton5.Location = new System.Drawing.Point(477, 86);
            this.loginradioButton5.Name = "loginradioButton5";
            this.loginradioButton5.Size = new System.Drawing.Size(59, 16);
            this.loginradioButton5.TabIndex = 30;
            this.loginradioButton5.TabStop = true;
            this.loginradioButton5.Text = "管理员";
            this.loginradioButton5.UseVisualStyleBackColor = true;
            // 
            // loginradioButton4
            // 
            this.loginradioButton4.AutoSize = true;
            this.loginradioButton4.Location = new System.Drawing.Point(478, 53);
            this.loginradioButton4.Name = "loginradioButton4";
            this.loginradioButton4.Size = new System.Drawing.Size(47, 16);
            this.loginradioButton4.TabIndex = 29;
            this.loginradioButton4.TabStop = true;
            this.loginradioButton4.Text = "教师";
            this.loginradioButton4.UseVisualStyleBackColor = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(461, 250);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 28;
            this.loginbutton.Text = "登录";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // logintextBoxuserpassword
            // 
            this.logintextBoxuserpassword.Location = new System.Drawing.Point(388, 201);
            this.logintextBoxuserpassword.Name = "logintextBoxuserpassword";
            this.logintextBoxuserpassword.PasswordChar = '*';
            this.logintextBoxuserpassword.Size = new System.Drawing.Size(148, 21);
            this.logintextBoxuserpassword.TabIndex = 27;
            // 
            // loginlabel3
            // 
            this.loginlabel3.AutoSize = true;
            this.loginlabel3.Location = new System.Drawing.Point(331, 204);
            this.loginlabel3.Name = "loginlabel3";
            this.loginlabel3.Size = new System.Drawing.Size(41, 12);
            this.loginlabel3.TabIndex = 26;
            this.loginlabel3.Text = "密码：";
            // 
            // logintextBoxusername
            // 
            this.logintextBoxusername.Location = new System.Drawing.Point(388, 159);
            this.logintextBoxusername.Name = "logintextBoxusername";
            this.logintextBoxusername.Size = new System.Drawing.Size(148, 21);
            this.logintextBoxusername.TabIndex = 25;
            // 
            // loginlabel2
            // 
            this.loginlabel2.AutoSize = true;
            this.loginlabel2.Location = new System.Drawing.Point(329, 162);
            this.loginlabel2.Name = "loginlabel2";
            this.loginlabel2.Size = new System.Drawing.Size(53, 12);
            this.loginlabel2.TabIndex = 24;
            this.loginlabel2.Text = "用户名：";
            // 
            // loginradioButton3
            // 
            this.loginradioButton3.AutoSize = true;
            this.loginradioButton3.Location = new System.Drawing.Point(403, 117);
            this.loginradioButton3.Name = "loginradioButton3";
            this.loginradioButton3.Size = new System.Drawing.Size(59, 16);
            this.loginradioButton3.TabIndex = 23;
            this.loginradioButton3.TabStop = true;
            this.loginradioButton3.Text = "博士生";
            this.loginradioButton3.UseVisualStyleBackColor = true;
            // 
            // loginradioButton2
            // 
            this.loginradioButton2.AutoSize = true;
            this.loginradioButton2.Location = new System.Drawing.Point(403, 86);
            this.loginradioButton2.Name = "loginradioButton2";
            this.loginradioButton2.Size = new System.Drawing.Size(59, 16);
            this.loginradioButton2.TabIndex = 22;
            this.loginradioButton2.TabStop = true;
            this.loginradioButton2.Text = "研究生";
            this.loginradioButton2.UseVisualStyleBackColor = true;
            // 
            // loginradioButton1
            // 
            this.loginradioButton1.AutoSize = true;
            this.loginradioButton1.Location = new System.Drawing.Point(403, 55);
            this.loginradioButton1.Name = "loginradioButton1";
            this.loginradioButton1.Size = new System.Drawing.Size(59, 16);
            this.loginradioButton1.TabIndex = 21;
            this.loginradioButton1.TabStop = true;
            this.loginradioButton1.Text = "本科生";
            this.loginradioButton1.UseVisualStyleBackColor = true;
            // 
            // loginlabel1
            // 
            this.loginlabel1.AutoSize = true;
            this.loginlabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginlabel1.Location = new System.Drawing.Point(317, 55);
            this.loginlabel1.Name = "loginlabel1";
            this.loginlabel1.Size = new System.Drawing.Size(65, 12);
            this.loginlabel1.TabIndex = 20;
            this.loginlabel1.Text = "用户类型：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 357);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton loginradioButton5;
        private System.Windows.Forms.RadioButton loginradioButton4;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox logintextBoxuserpassword;
        private System.Windows.Forms.Label loginlabel3;
        private System.Windows.Forms.TextBox logintextBoxusername;
        private System.Windows.Forms.Label loginlabel2;
        private System.Windows.Forms.RadioButton loginradioButton3;
        private System.Windows.Forms.RadioButton loginradioButton2;
        private System.Windows.Forms.RadioButton loginradioButton1;
        private System.Windows.Forms.Label loginlabel1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

