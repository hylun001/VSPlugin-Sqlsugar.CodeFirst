namespace SqlExtension.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxDbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.labelOutputDir = new System.Windows.Forms.Label();
            this.txtConnstring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStartProject = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 620);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 417);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1416, 104);
            this.textBox1.TabIndex = 1;
            // 
            // comboBoxDbProject
            // 
            this.comboBoxDbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbProject.FormattingEnabled = true;
            this.comboBoxDbProject.Location = new System.Drawing.Point(136, 171);
            this.comboBoxDbProject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDbProject.Name = "comboBoxDbProject";
            this.comboBoxDbProject.Size = new System.Drawing.Size(590, 23);
            this.comboBoxDbProject.TabIndex = 2;
            this.comboBoxDbProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxDbProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Db实体模型输出";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "选择目录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelOutputDir
            // 
            this.labelOutputDir.AutoSize = true;
            this.labelOutputDir.Location = new System.Drawing.Point(144, 216);
            this.labelOutputDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutputDir.Name = "labelOutputDir";
            this.labelOutputDir.Size = new System.Drawing.Size(79, 15);
            this.labelOutputDir.TabIndex = 5;
            this.labelOutputDir.Text = "fileLabel";
            // 
            // txtConnstring
            // 
            this.txtConnstring.Location = new System.Drawing.Point(136, 49);
            this.txtConnstring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConnstring.Multiline = true;
            this.txtConnstring.Name = "txtConnstring";
            this.txtConnstring.Size = new System.Drawing.Size(1158, 72);
            this.txtConnstring.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "项目配置";
            // 
            // comboBoxStartProject
            // 
            this.comboBoxStartProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartProject.FormattingEnabled = true;
            this.comboBoxStartProject.Location = new System.Drawing.Point(136, 20);
            this.comboBoxStartProject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStartProject.Name = "comboBoxStartProject";
            this.comboBoxStartProject.Size = new System.Drawing.Size(594, 23);
            this.comboBoxStartProject.TabIndex = 7;
            this.comboBoxStartProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartProject_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1330, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "连接数据库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 901);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStartProject);
            this.Controls.Add(this.txtConnstring);
            this.Controls.Add(this.labelOutputDir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDbProject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxDbProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelOutputDir;
        private System.Windows.Forms.TextBox txtConnstring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStartProject;
        private System.Windows.Forms.Button button3;
    }
}

