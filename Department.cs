using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh_lb2_v6
{
    class Department
    {
        public String departmantName { private set; get; }
        public Int16 numberOfMaxEmployees { private set; get; }
        public String managerName { private set; get; }
        private List<Employee> ListEmployee = new List<Employee>();
        Department(String _depName, Int16 _maxEmployees, String _nameManager)
        {
            ChangeDepartment(_depName, _maxEmployees, _nameManager);
        }
        public void ChangeDepartment(String _depName, Int16 _maxEmployees, String _nameManager)
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
