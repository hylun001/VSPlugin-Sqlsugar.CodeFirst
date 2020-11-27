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
    }
}
