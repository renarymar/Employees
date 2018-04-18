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
    /// Класс Сотрудник
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string lastName;
        private string departmentName;

        public event PropertyChangedEventHandler PropertyChanged;

        public int ID
        {
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
            get => id;
            
        }
        public string FirstName
        {
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
            get => firstName;

        }
        public string LastName
        {
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
            get => lastName;

        }
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
