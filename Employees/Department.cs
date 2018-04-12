using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// Класс Департамент
    /// </summary>
    class Department : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string departmentName;

        public string DepartmentName
        {
            set
            {
                departmentName = value;
                OnPropertyChanged("DepartmentName");
            }
            get => departmentName;
        }

        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }

}
