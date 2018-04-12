using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class EmployeeViewModel : INotifyPropertyChanged
    {
        private Employee employee;

        public EmployeeViewModel(Employee e)
        {
            employee = e;
        }

        public int ID
        {
            get => employee.ID; 
            set
            {
                employee.ID = value;
                OnPropertyChanged("ID");
            }
        }
        public string FirstName
        {
            get => employee.FirstName;
            set
            {
                employee.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get =>employee.LastName;
            set
            {
                employee.LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string DepartmentName
        {
            get => employee.DepartmentName;
            set
            {
                employee.DepartmentName = value;
                OnPropertyChanged("DepartmentName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
