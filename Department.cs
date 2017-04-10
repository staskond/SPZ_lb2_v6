using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh_lb2_v6
{
    class Department
    {
        public String departmantName { set; get; }
        public Int16 numberOfMaxEmployees { set; get; }
        public String managerName { set; get; }
        private List<Employee> ListEmployee = new List<Employee>();
        private string v1;
        private int v2;
        private string v3;
        public Department()
        { }
        Department(String _depName, Int16 _maxEmployees, String _nameManager)
        {
            ChangeDepartment(_depName, _maxEmployees, _nameManager);
        }

        public Department(string v1, int v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
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
