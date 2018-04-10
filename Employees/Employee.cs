using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// Класс Сотрудник
    /// </summary>
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string DepartmentName;
        public int ID;

        public override string ToString()
        {
            return $"{ID}\t{FirstName}\t{LastName}\t{DepartmentName}";
        }

        /// <summary>
        /// Конструктор для создания нового сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="departmentName"></param>
        public Employee(int id, string firstName, string lastName, string departmentName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DepartmentName = departmentName;
        }

        
    }
}
