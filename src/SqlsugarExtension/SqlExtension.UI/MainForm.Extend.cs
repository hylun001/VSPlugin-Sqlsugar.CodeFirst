using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SqlExtension.Models;
using System.IO;

namespace SqlExtension.UI
{
    public partial class MainForm //: Form
    {
        private void InitUIComponent()
        {
            BindComboBox();
        }

        private void BindComboBox()
        {
            // 启动项木 下拉框
            {
                var dataList = CurFormData.ProjectList.ToJsonString().ToJson<List<ProjectDto>>();
                this.comboBoxStartProject.DataSource = dataList;
                this.comboBoxStartProject.DisplayMember = "ProjectName";
                this.comboBoxStartProject.ValueMember = "ProjectFullPath";

                for (var i = 0; i < dataList.Count; i++)
                {
                    var item = dataList[i];
                    var dir = Path.GetDirectoryName(item.ProjectFullPath);
                    // F:\MyCode\SqlsugarVsExtension\src\SqlsugarDemo\SqlsugarDemo\appsettings.json
                    var matchFileName = Path.Combine(dir, "appsettings.json");

                    if (File.Exists(matchFileName))
                    {
                        this.comboBoxStartProject.SelectedIndex = i;
                        break;
                    }
                }
            }

            // 输出目录 下拉框
            {
                var dataList = CurFormData.ProjectList.ToJsonString().ToJson<List<ProjectDto>>();
                this.comboBoxDbProject.DataSource = dataList;
                this.comboBoxDbProject.DisplayMember = "ProjectName";
                this.comboBoxDbProject.ValueMember = "ProjectFullPath";

                var regex = new Regex("(.*\\.db)|(.*entit.*)$", RegexOptions.IgnoreCase);
                var index = CurFormData.ProjectList.FindIndex(a => regex.IsMatch(a.ProjectName));
                if (index >= 0)
                {
                    this.comboBoxDbProject.SelectedIndex = index;
                }
            }
        }
    }
}
