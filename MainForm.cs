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
        List<Employee> tmpEmployee = new List<Employee>();
        int SelectSort = 0;
        public s()
        {
            InitializeComponent();
            DepartmentList.Add(new Department("Бригада №6", 3, "Кондрюков"));
            DepartmentList.Add(new Department("Университет", 800, "Дэкан"));
            DepartmentList[0].AddEmployee(new Employee("Кондрюков Станислав", 10));
            DepartmentList[0].AddEmployee(new Employee("Степанова Кристина", 11));
            DepartmentList[0].AddEmployee(new Employee("Срибна Мария", 15));
            DepartmentList[1].AddEmployee(new Employee("Кужебяков Сергей", 6300));
            DepartmentList[1].AddEmployee(new Employee("Мартыненко Никита", 5600));
            DepartmentList[1].AddEmployee(new Employee("Кучеренко Мария", 6500));
            DepartmentList[1].AddEmployee(new Employee("Кужебяков Сергей", 6300));
            DepartmentList[1].AddEmployee(new Employee("Джонсон Эколс", 2000));
            DepartmentList[1].AddEmployee(new Employee("Сободаж Дарья", 1700));
            DepartmentList[1].AddEmployee(new Employee("Иванской Дмитрий", 9900));
            bsEmployees.DataSource = DepartmentList[0].ListEmployee;
            bsDepartment.DataSource = DepartmentList;
            listBoxDep.DataSource = bsDepartment;
            listBoxDep.DisplayMember = "departmantName";
            listBoxEmployee.DataSource = bsEmployees;
            listBoxEmployee.DisplayMember = "FullName";
            listBoxDep.MouseDoubleClick += new MouseEventHandler(DepartmentMouseDoubleClick);
            listBoxEmployee.MouseDoubleClick += new MouseEventHandler(EmployeeMouseDoubleClick);
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
                    if (DepartmentList[listBoxDep.SelectedIndex].ListEmployee.Count < DepartmentList[listBoxDep.SelectedIndex].numberOfMaxEmployees)
                    {
                        EmployeeOptions EmployeeForm = new EmployeeOptions();
                        EmployeeForm.Owner = this;
                        if (EmployeeForm.ShowDialog() == DialogResult.OK)
                        {
                            DepartmentList[listBoxDep.SelectedIndex].AddEmployee(new Employee(StaticClassEmployee.FullName, StaticClassEmployee.Salary));
                            bsEmployees.ResetBindings(true);

                        }
                        StaticClassEmployee.NulableAllValue();
                    }
                    else
                    {
                        MessageBox.Show("Достигнуто максимальное количество сотрудников!", "Сообщение", MessageBoxButtons.OK);
                    }
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
                ChangeEmployee();
            };
            buttonSortEmployees.Click += (object s, EventArgs e) =>
            {
                switch (SelectSort)
                {
                    case 0:
                        {
                            var empl0 = from emp in DepartmentList[listBoxDep.SelectedIndex].ListEmployee
                                        orderby emp.FullName ascending
                                        select emp;
                            foreach (var employeeGroup in empl0)
                            {
                                tmpEmployee.Add(new Employee(employeeGroup.FullName, employeeGroup.Salary));
                            }
                            RefreshListAfterSort();
                            SelectSort += 1;
                            break;
                        }
                    case 1:
                        {
                            var empl0 = from emp in DepartmentList[listBoxDep.SelectedIndex].ListEmployee
                                        orderby emp.FullName descending
                                        select emp;
                            foreach (var employeeGroup in empl0)
                            {
                                tmpEmployee.Add(new Employee(employeeGroup.FullName, employeeGroup.Salary));
                            }
                            RefreshListAfterSort();
                            SelectSort = 0;
                            break;
                        }
                    default:
                        SelectSort = 0; break;

                }
            };
            buttonSortSalary.Click += (object s, EventArgs e) =>
                {
                    switch (SelectSort)
                   {
                        case 0:
                            {
                                var empl0 = from emp in DepartmentList[listBoxDep.SelectedIndex].ListEmployee
                                            orderby emp.Salary ascending
                                            select emp;

                                foreach (var employeeGroup in empl0)
                                {
                                    tmpEmployee.Add(new Employee(employeeGroup.FullName, employeeGroup.Salary));
                                }
                                RefreshListAfterSort();
                                SelectSort += 1;
                                break;
                            }
                        case 1:
                            {
                                var empl0 = from emp in DepartmentList[listBoxDep.SelectedIndex].ListEmployee
                                            orderby emp.Salary descending
                                            select emp;
                                foreach (var employeeGroup in empl0)
                                {
                                    tmpEmployee.Add(new Employee(employeeGroup.FullName, employeeGroup.Salary));
                                }
                                RefreshListAfterSort();
                                SelectSort = 0;

                                break;
                            }
                        default:
                            SelectSort = 0; break;
                    };
            };
        }

        private void EmployeeMouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeEmployee();
        }

        private void ChangeEmployee()
        {
            if (bsEmployees.Count > 0)
            {
                StaticClassEmployee.FullName = DepartmentList[listBoxDep.SelectedIndex].ListEmployee[listBoxEmployee.SelectedIndex].FullName;
                StaticClassEmployee.Salary = DepartmentList[listBoxDep.SelectedIndex].ListEmployee[listBoxEmployee.SelectedIndex].Salary;
                EmployeeOptions EmployeeForm = new EmployeeOptions();
                EmployeeForm.Owner = this;
                if (EmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    DepartmentList[listBoxDep.SelectedIndex].ListEmployee[listBoxEmployee.SelectedIndex].ChangeEmployee(StaticClassEmployee.FullName, StaticClassEmployee.Salary);
                    bsEmployees.ResetBindings(false);

                }
                StaticClassEmployee.NulableAllValue();
            }
        }

        private void RefreshListAfterSort()
        {
            DepartmentList[listBoxDep.SelectedIndex].ListEmployee.Clear();
            DepartmentList[listBoxDep.SelectedIndex].ListEmployee.AddRange(tmpEmployee);
            tmpEmployee.Clear();
            bsEmployees.DataSource = DepartmentList[listBoxDep.SelectedIndex].ListEmployee;
            bsEmployees.ResetBindings(true);
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
