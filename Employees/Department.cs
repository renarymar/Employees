using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// Класс Департамент
    /// </summary>
    class Department
    {
        public string DepartmentName;

        /// <summary>
        /// Конструктор для создания нового департамента
        /// </summary>
        /// <param name="departmentName"></param>
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return $"\t{DepartmentName}";
        }

    }
}
