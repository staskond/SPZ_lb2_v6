using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh_lb2_v6
{
   public class Employee
    {
        public string FullName { private set; get; }
        public decimal Salary { private set; get; }
        public Employee(String _fullName, Decimal _salary)
        {
            ChangeEmployee(_fullName, _salary);
        }
        public void ChangeEmployee(String _fullName, Decimal _salary)
        {
            if (_fullName.Length > 0)
                FullName = _fullName;
            else
                throw new ArgumentException("Введено неккоректное имя.");

            if (_salary > 0)
                Salary = _salary;
            else
                throw new ArgumentException("Введена неккоректная оплата труда.");
        }
    }
}
