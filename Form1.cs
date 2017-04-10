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
        public s()
        {
            
            InitializeComponent();
            List<Department> DepartamentList = new List<Department>
            {
                new Department {departmantName = "ГорНефть", numberOfMaxEmployees = 425, managerName = "Мавсисян Георгий" },
                new Department {departmantName = "Облосной Водоканал",numberOfMaxEmployees = 17, managerName = "Дельчинко Владислав"},
                new Department {departmantName = "ХНУРЭ",numberOfMaxEmployees = 2100, managerName = "Андреев Сергей"},
                new Department {departmantName = "Aldec",numberOfMaxEmployees = 32, managerName = "Алексеев Николай"}
            };
            listBoxDep.DataSource = DepartamentList;
            listBoxDep.DisplayMember = "departmantName";
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
            DepartmentOptions DepForm = new DepartmentOptions();
            DepForm.Show();

        }

        private void buttonDelDep_Click(object sender, EventArgs e)
        {
            
        }
    }
}
