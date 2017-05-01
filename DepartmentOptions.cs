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
            textBoxDepName.Text = StaticClassDep.nameDep;
            textBoxManagerName.Text = StaticClassDep.ManagerName;
            maskedTextBoxMaxEmployee.Text = StaticClassDep.maxEmployee.ToString();
            btApply.Click += (object s, EventArgs e) =>
            {
                if (textBoxDepName.TextLength >= 1 && textBoxManagerName.TextLength  >= 1 && maskedTextBoxMaxEmployee != null)
                {
                    StaticClassDep.nameDep = textBoxDepName.Text;
                    StaticClassDep.ManagerName = textBoxManagerName.Text;
                    StaticClassDep.maxEmployee = Convert.ToInt32(maskedTextBoxMaxEmployee.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Название департамента / имя управляющего не может быть пустым", "Сообщение", MessageBoxButtons.OK);
                }
            };
            btCancel.Click += (object s, EventArgs e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
        }
    }
}
