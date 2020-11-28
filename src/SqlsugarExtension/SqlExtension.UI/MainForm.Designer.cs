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
            this.button1 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1526, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtModelString
            // 
            this.txtModelString.Location = new System.Drawing.Point(447, 172);
            this.txtModelString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelString.Multiline = true;
            this.txtModelString.Name = "txtModelString";
            this.txtModelString.ReadOnly = true;
            this.txtModelString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtModelString.Size = new System.Drawing.Size(1073, 491);
            this.txtModelString.TabIndex = 1;
            // 
            // comboBoxDbProject
            // 
            this.comboBoxDbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbProject.FormattingEnabled = true;
            this.comboBoxDbProject.Location = new System.Drawing.Point(136, 104);
            this.comboBoxDbProject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDbProject.Name = "comboBoxDbProject";
            this.comboBoxDbProject.Size = new System.Drawing.Size(590, 23);
            this.comboBoxDbProject.TabIndex = 2;
            this.comboBoxDbProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxDbProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Db实体模型输出";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 135);
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
            this.labelOutputDir.Location = new System.Drawing.Point(133, 142);
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
            this.txtConnstring.Size = new System.Drawing.Size(1121, 37);
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
            this.button3.Location = new System.Drawing.Point(1279, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "连接数据库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeDb
            // 
            this.treeDb.CheckBoxes = true;
            this.treeDb.Location = new System.Drawing.Point(13, 172);
            this.treeDb.Name = "treeDb";
            this.treeDb.Size = new System.Drawing.Size(386, 491);
            this.treeDb.TabIndex = 10;
            this.treeDb.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeDb_BeforeExpand);
            this.treeDb.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDb_NodeMouseClick);
            this.treeDb.Click += new System.EventHandler(this.treeDb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 1068);
            this.Controls.Add(this.treeDb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStartProject);
            this.Controls.Add(this.txtConnstring);
            this.Controls.Add(this.labelOutputDir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDbProject);
            this.Controls.Add(this.txtModelString);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

