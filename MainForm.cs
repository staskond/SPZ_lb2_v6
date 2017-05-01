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
        BindingSource bsEmployees = new BindingSource();
        public s()
        {
            InitializeComponent();
            DepartmentList.Add(new Department("Бригада №6", 3, "Кондрюков"));
            DepartmentList[0].AddEmployee(new Employee("Кондрюков Станислав", 11));
            DepartmentList[0].AddEmployee(new Employee("Степанова Кристина", 11));
            DepartmentList[0].AddEmployee(new Employee("Срибна Мария", 11));
            bsEmployees.DataSource = DepartmentList[0].ListEmployee;
            bsDepartment.DataSource = DepartmentList;
            listBoxDep.DataSource = bsDepartment;
            listBoxDep.DisplayMember = "departmantName";
            listBoxEmployee.DataSource = bsEmployees;
            listBoxEmployee.DisplayMember = "FullName";
            listBoxDep.MouseDoubleClick += new MouseEventHandler(DepartmentMouseDoubleClick);
            buttonAddDep.Click += (object s, EventArgs e) =>
            {
                DepartmentOptions DepForm = new DepartmentOptions();
                DepForm.Owner = this;
                if (DepForm.ShowDialog() == DialogResult.OK)
                {
                    DepartmentList.Add(new Department(StaticClassDep.nameDep,
                        StaticClassDep.maxEmployee,
                        StaticClassDep.ManagerName));
                    bsDepartment.ResetBindings(true);
                    StaticClassDep.NulableAllValue();
                   
                }
            };
            buttonDelDep.Click += (object s, EventArgs e) =>
            {
                if (bsDepartment.Count > 0)
                {
                    bsDepartment.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Cписок депортаментов пуст, удалять нечего.", "Сообщение", MessageBoxButtons.OK);
                }
            };
            buttonChangeDep.Click += (object s, EventArgs e) =>
            {
                if (bsDepartment.Count > 0)
                {
                    StaticClassDep.nameDep = DepartmentList[listBoxDep.SelectedIndex].departmantName;
                    StaticClassDep.maxEmployee = DepartmentList[listBoxDep.SelectedIndex].numberOfMaxEmployees;
                    StaticClassDep.ManagerName = DepartmentList[listBoxDep.SelectedIndex].managerName;
                    DepartmentOptions DepForm = new DepartmentOptions();
                    DepForm.Owner = this;
                    if (DepForm.ShowDialog() == DialogResult.OK)
                    {
                        DepartmentList[listBoxDep.SelectedIndex].ChangeDepartment(StaticClassDep.nameDep,
                            StaticClassDep.maxEmployee,
                            StaticClassDep.ManagerName);
                        bsDepartment.ResetBindings(false);
                    }
                    StaticClassDep.NulableAllValue();
                }
                else
                {
                    MessageBox.Show("Cписок депортаментов пуст, изменять нечего.", "Сообщение", MessageBoxButtons.OK);
                }
            };
            buttonAddEmployee.Click += (object s, EventArgs e) =>
            {
                if (bsDepartment.Count > 0)
                {
                    EmployeeOptions EmployeeForm = new EmployeeOptions();
                    EmployeeForm.Owner = this;
                    if(EmployeeForm.ShowDialog() == DialogResult.OK)
                    {
                        DepartmentList[listBoxDep.SelectedIndex].AddEmployee(new Employee(StaticClassEmployee.FullName, StaticClassEmployee.Salary));
                         bsEmployees.ResetBindings(true);
                        
                    }
                    StaticClassEmployee.NulableAllValue();
                }
            };
            buttonDelEmployee.Click += (object s, EventArgs e) =>
            {
                if (bsEmployees.Count > 0)
                {
                    bsEmployees.RemoveCurrent();
                }
            };

            buttonChangeEmployee.Click += (object s, EventArgs e) =>
            {
                if(bsEmployees.Count > 0)
                {
                    StaticClassEmployee.FullName = DepartmentList[listBoxDep.SelectedIndex].ListEmployee[listBoxEmployee.SelectedIndex].FullName;
                    StaticClassEmployee.Salary = DepartmentList[listBoxDep.SelectedIndex].ListEmployee[listBoxEmployee.SelectedIndex].Salary;
                    EmployeeOptions EmployeeForm = new EmployeeOptions();
                    EmployeeForm.Owner = this;
                    if(EmployeeForm.ShowDialog() == DialogResult.OK)
                    {
                        DepartmentList[listBoxDep.SelectedIndex].ListEmployee[listBoxEmployee.SelectedIndex].ChangeEmployee(StaticClassEmployee.FullName, StaticClassEmployee.Salary);
                        bsEmployees.ResetBindings(false);
                        
                    }
                    StaticClassEmployee.NulableAllValue();
                }
            };
        }
        

        private void DepartmentMouseDoubleClick(object sender, MouseEventArgs e)
        {
            bsEmployees.DataSource = DepartmentList[listBoxDep.SelectedIndex].ListEmployee;
            bsEmployees.ResetBindings(true);
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
