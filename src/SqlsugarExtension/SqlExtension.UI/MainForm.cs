using SqlExtension.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SqlExtension.UI
{
    public partial class MainForm : Form
    {
        private readonly OpenFormDto CurFormData;
        public MainForm()
        {
            CurFormData = new OpenFormDto();
            CurFormData.ProjectList.Add(new ProjectDto
            {
                ProjectName = "SqlExtension.Core",
                ProjectFullPath = @"F:\MyCode\SqlsugarVsExtension\src\SqlsugarExtension\SqlExtension.Core\SqlExtension.Core.csproj"
            });
            CurFormData.ProjectList.Add(new ProjectDto
            {
                ProjectName = "SqlsugarDemo",
                ProjectFullPath = @"F:\MyCode\SqlsugarVsExtension\src\SqlsugarDemo\SqlsugarDemo\SqlsugarDemo.csproj"
            });
            CurFormData.ProjectList.Add(new ProjectDto
            {
                ProjectName = "Demo.SugarEntities",
                ProjectFullPath = @"E:\demo\SqlsugarVsExtension\src\SqlsugarDemo\Demo.Entitys\Demo.SugarEntities.csproj"
            });

            InitializeComponent();

            InitUIComponent();
        }

        public MainForm(OpenFormDto dto) : this()
        {
            CurFormData = dto;

            this.textBox1.Text = dto.ToJsonString(true);
        }



        private void button1_Click(object sender, EventArgs e)
        {


            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Multiselect = true;//该值确定是否可以选择多个文件
            //// dialog.Title = "请选择文件夹";
            //dialog.Filter = "所有文件(*.*)|*.*";
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string file = dialog.FileName;
            //    MessageBox.Show(file);
            //}
        }

        private void comboBoxDbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var path = (comboBoxDbProject.SelectedItem as ProjectDto)?.ProjectFullPath;

            if (!path.IsNullOrWhiteSpace())
            {
                var dir = System.IO.Path.GetDirectoryName(path); 
                this.labelOutputDir.Text = dir;
                this.folderBrowserDialogOutput.SelectedPath = dir;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialogOutput.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.labelOutputDir.Text = folderBrowserDialogOutput.SelectedPath;
            }
        }

        private void comboBoxStartProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtConnstring.Text = "";
            var path = (comboBoxStartProject.SelectedItem as ProjectDto)?.ProjectFullPath;

            if (path.IsNullOrWhiteSpace())
            {
                return;
            }

            var dir = System.IO.Path.GetDirectoryName(path);
            var matchFileName = Path.Combine(dir, "appsettings.json");

            if (!File.Exists(matchFileName))
            {
                return;
            }

            var fileContent = File.ReadAllText(matchFileName);
            var regex = new Regex("(?<=\\\")[^\\\"]*?Uid=.*?(?=\\\")", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            var match = regex.Match(fileContent);
            if (!match.Success)
            {
                return;
            }

            this.txtConnstring.Text = match.Value;
        }
    }
}
