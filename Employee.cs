using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh_lb2_v6
{
    class Employee
    {
        public String FullName { private set; get; }
        public Decimal Salary { private set; get; }
        Employee(String _fullName, Decimal _salary)
        {
            if (_fullName.Length > 0)
                FullName = _fullName;
            else
                throw new ArgumentException("Введено неккоректное имя.");

            if (Salary > 0)
                Salary = _salary;
            else
                throw new ArgumentException("Введена неккоректная оплата труда.");
        }
    }
}
