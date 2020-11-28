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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtModelString = new System.Windows.Forms.TextBox();
            this.comboBoxDbProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.labelOutputDir = new System.Windows.Forms.Label();
            this.txtConnstring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStartProject = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.treeDb = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModelString
            // 
            this.txtModelString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModelString.Location = new System.Drawing.Point(0, 0);
            this.txtModelString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelString.Multiline = true;
            this.txtModelString.Name = "txtModelString";
            this.txtModelString.ReadOnly = true;
            this.txtModelString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtModelString.Size = new System.Drawing.Size(874, 673);
            this.txtModelString.TabIndex = 1;
            // 
            // comboBoxDbProject
            // 
            this.comboBoxDbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbProject.FormattingEnabled = true;
            this.comboBoxDbProject.Location = new System.Drawing.Point(140, 89);
            this.comboBoxDbProject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDbProject.Name = "comboBoxDbProject";
            this.comboBoxDbProject.Size = new System.Drawing.Size(590, 23);
            this.comboBoxDbProject.TabIndex = 2;
            this.comboBoxDbProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxDbProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Db实体模型输出";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "选择目录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelOutputDir
            // 
            this.labelOutputDir.AutoSize = true;
            this.labelOutputDir.Location = new System.Drawing.Point(293, 128);
            this.labelOutputDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutputDir.Name = "labelOutputDir";
            this.labelOutputDir.Size = new System.Drawing.Size(79, 15);
            this.labelOutputDir.TabIndex = 5;
            this.labelOutputDir.Text = "fileLabel";
            // 
            // txtConnstring
            // 
            this.txtConnstring.Location = new System.Drawing.Point(140, 34);
            this.txtConnstring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConnstring.Multiline = true;
            this.txtConnstring.Name = "txtConnstring";
            this.txtConnstring.Size = new System.Drawing.Size(1121, 37);
            this.txtConnstring.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
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
            this.comboBoxStartProject.Location = new System.Drawing.Point(140, 5);
            this.comboBoxStartProject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStartProject.Name = "comboBoxStartProject";
            this.comboBoxStartProject.Size = new System.Drawing.Size(594, 23);
            this.comboBoxStartProject.TabIndex = 7;
            this.comboBoxStartProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartProject_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "连接数据库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeDb
            // 
            this.treeDb.CheckBoxes = true;
            this.treeDb.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDb.Location = new System.Drawing.Point(0, 0);
            this.treeDb.Name = "treeDb";
            this.treeDb.Size = new System.Drawing.Size(355, 673);
            this.treeDb.TabIndex = 10;
            this.treeDb.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeDb_BeforeExpand);
            this.treeDb.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDb_NodeMouseClick);
            this.treeDb.Click += new System.EventHandler(this.treeDb_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 110);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 76);
            this.button4.TabIndex = 11;
            this.button4.Text = "生成当前模型文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 421);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 76);
            this.button5.TabIndex = 12;
            this.button5.Text = "生成已勾选模型文件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(140, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 31);
            this.button6.TabIndex = 13;
            this.button6.Text = "打开所在文件夹";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 829);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtConnstring);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.comboBoxStartProject);
            this.panel2.Controls.Add(this.labelOutputDir);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.comboBoxDbProject);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1429, 156);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.treeDb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1429, 673);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1229, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 673);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtModelString);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(355, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(874, 673);
            this.panel5.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 829);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtModelString;
        private System.Windows.Forms.ComboBox comboBoxDbProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelOutputDir;
        private System.Windows.Forms.TextBox txtConnstring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStartProject;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeDb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}

