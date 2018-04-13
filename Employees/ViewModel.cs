using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Employees
{
    class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }
        delegate string AddingDepartment(string departmentName);

        private RelayCommand addEmployee;
        public RelayCommand AddEmployee
        {
            get
            {
                return addEmployee ??
                  (addEmployee = new RelayCommand(obj =>
                  {
                      Employee employee = new Employee();
                      Employees.Add(employee);
                      SelectedEmployee = employee;
                  }));
            }
        }

        private RelayCommand addDepartment;
        public RelayCommand AddDepartment
        {
            get
            {
                return addDepartment ??
                  (addDepartment = new RelayCommand(obj =>
                  {
                      Department department = new Department();
                      Departments.Insert(0,department);
                  }));
            }
        }

        private Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public ViewModel()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee {ID = 1, FirstName = "Jane", LastName = "Black", DepartmentName = "Marketing" },
                new Employee{ID = 2, FirstName = "Jack", LastName = "Black", DepartmentName = "Sales" },
                new Employee{ID = 3, FirstName = "Ben", LastName = "Rolson", DepartmentName = "IT" },
                new Employee{ID = 4, FirstName = "Patrick", LastName = "Torsley", DepartmentName = "Accounting" }
            };

            Departments = new ObservableCollection<Department>
            {
                new Department{DepName = "Marketing" },
                new Department{DepName = "Sales" },
                new Department{DepName = "IT" },
                new Department{DepName = "Accounting" }
            };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
