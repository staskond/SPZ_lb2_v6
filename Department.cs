﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh_lb2_v6
{
    public class Department
    {
        public string departmantName { set; get; }
        public int numberOfMaxEmployees { set; get; }
        public string managerName {  set; get; }
        public List<Employee> ListEmployee = new List<Employee>();
        public Department(string _depName, int _maxEmployees, string _nameManager)
        {
            ChangeDepartment(_depName, _maxEmployees, _nameManager);
        }
        public void ChangeDepartment(string _depName, int _maxEmployees, string _nameManager)
        {
            try
            {
                if (_depName.Length > 0 && _nameManager.Length > 0)
                {
                    managerName = _nameManager;
                    departmantName = _depName;
                }
                else
                {
                    throw new ArgumentException("Название департамента/имя менеджера не может быть пустым");
                }
                if (_maxEmployees > 0)
                    numberOfMaxEmployees = _maxEmployees;
                else
                {
                    throw new ArgumentException("Количество сотрудников не может быть меньше одного.");
                }
            }
            catch (ArgumentException e)
            {
                var result = MessageBox.Show(e.Message, "Error Window", MessageBoxButtons.OK);
            }
            catch (Exception e1)
            {
                var result = MessageBox.Show(e1.Message, "Error Window", MessageBoxButtons.OK);
            }
        }
        public void AddEmployee(Employee _employee)
        {
            ListEmployee.Add(_employee);
        }
        public void DeliteEmployee(Employee _employee)
        {
            if(ListEmployee != null) 
                ListEmployee.Remove(_employee);
        }
        
    }


}
