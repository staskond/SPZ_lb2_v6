using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh_lb2_v6
{
    public partial class DepartmentOptions : Form
    {
        public DepartmentOptions()
        {
            InitializeComponent();
            btApply.Click += (object s, EventArgs e) =>
            {
                this.DialogResult = DialogResult.OK;
                if (textBoxDepName != null && textBoxManagerName != null && maskedTextBoxMaxEmployee != null)
                {
                    StaticClassDep.nameDep = textBoxDepName.Text;
                    StaticClassDep.ManagerName = textBoxManagerName.Text;
                    StaticClassDep.maxEmployee = Convert.ToInt32(maskedTextBoxMaxEmployee.Text);
                    this.Close();
                }
            };

        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
