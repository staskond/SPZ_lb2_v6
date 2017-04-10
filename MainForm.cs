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
    public partial class s : Form
    {
        List<Department> DepartmentList = new List<Department>();
        BindingSource bsDepartment = new BindingSource();
        public s()
        {
            InitializeComponent();
            DepartmentList.Add(new Department("asda", 12, "asda"));
            bsDepartment.DataSource = DepartmentList;
            listBoxDep.DataSource = bsDepartment;
            listBoxDep.DisplayMember = "departmantName";
            buttonAddDep.Click += (object s, EventArgs e) =>
            {
                DepartmentOptions DepForm = new DepartmentOptions();
                DepForm.Owner = this;
                if(DepForm.ShowDialog() == DialogResult.OK)
                {
                    listBoxDep.BeginUpdate();
                    DepartmentList.Add(new Department(StaticClassDep.nameDep,
                        StaticClassDep.maxEmployee,
                        StaticClassDep.ManagerName));
                   // bsDepartment.ResetBindings(true);
                    var result = MessageBox.Show("hey", "Error Window", MessageBoxButtons.OK);
                }
            };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void s_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddDep_Click(object sender, EventArgs e)
        {

        }
    }
}
