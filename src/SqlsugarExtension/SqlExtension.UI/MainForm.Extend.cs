using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.comboBoxDbProject.DataSource = CurFormData.ProjectList;
            this.comboBoxDbProject.DisplayMember = "ProjectName";
            this.comboBoxDbProject.ValueMember = "ProjectFullPath";

            //// CurFormData.ProjectList
            //CurFormData.ProjectList.ForEach(item =>
            //{
            //    this.comboBoxDbProject.Items.Add($"{item.ProjectName} {item.ProjectFullPath}");
            //});
        }
    }
}
