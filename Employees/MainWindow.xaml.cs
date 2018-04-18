using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Employees
{


    public partial class MainWindow : Window
    {
        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Employees.Load();
            this.DataContext = db.Employees.Local.ToBindingList();

        }

        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow(new Employee());
            if (employeeWindow.ShowDialog() == true)
            {
                Employee employee = employeeWindow.Employee;
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (employeesList.SelectedItem == null) return;
            // получаем выделенный объект
            Employee employee = employeesList.SelectedItem as Employee;

            EmployeeWindow employeeWindow = new EmployeeWindow(new Employee
            {
                ID = employee.ID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                DepartmentName = employee.DepartmentName
            });

            if (employeeWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                employee = db.Employees.Find(employeeWindow.Employee.ID);
                if (employee != null)
                {
                    employee.FirstName = employeeWindow.Employee.FirstName;
                    employee.LastName = employeeWindow.Employee.LastName;
                    employee.DepartmentName = employeeWindow.Employee.DepartmentName;
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}





