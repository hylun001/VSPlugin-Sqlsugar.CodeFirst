using SqlExtension.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                ProjectName = "Demo.SugarEntities",
                ProjectFullPath = @"E:\demo\SqlsugarVsExtension\src\SqlsugarDemo\Demo.Entitys\Demo.SugarEntities.csproj"
            });
            CurFormData.ProjectList.Add(new ProjectDto
            {
                ProjectName = "SqlsugarDemo",
                ProjectFullPath = @"E:\demo\SqlsugarVsExtension\src\SqlsugarDemo\SqlsugarDemo\SqlsugarDemo.csproj"
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
            MessageBox.Show("hello word");
        }

        private void comboBoxDbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var path = (comboBoxDbProject.SelectedItem as ProjectDto)?.ProjectFullPath;
            this.labelOutputDir.Text = path;

            if (!path.IsNullOrWhiteSpace())
            {
                this.folderBrowserDialogOutput.SelectedPath = System.IO.Path.GetDirectoryName(path);
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
    }
}
