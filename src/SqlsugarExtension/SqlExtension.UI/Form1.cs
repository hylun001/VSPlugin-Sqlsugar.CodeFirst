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
    public partial class Form1 : Form
    {
        private readonly OpenFormDto CurFormData;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(OpenFormDto dto) : this()
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
