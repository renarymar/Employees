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

namespace Employees
{
    public delegate void DeptDelegate(string data);
    public delegate void EmplDelegate(int id, string firstName, string lastName, string departmentName);


    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> _employeesList;
        ObservableCollection<Department> _departmentsList;

        public MainWindow()
        {
            InitializeComponent();
            EmployeesListInitialization();
            DepartmentsListInitialization();
        }

        void deptfunc(string data)
        {
            _departmentsList.Add(new Department(data));
        }

        void emplfunc(int id, string firstName, string lastName, string departmentName)
        {
            _employeesList.Add(new Employee(id, firstName, lastName, departmentName));
        }

        /// <summary>
        /// Заполнение списка сотрудников
        /// </summary>
        void EmployeesListInitialization()
        {
            _employeesList = new ObservableCollection<Employee>()
            {
                new Employee(1, "Jane", "Black", "Marketing"),
                new Employee(2, "Jack", "Black", "Sales"),
                new Employee(3, "Ben", "Rolson", "IT"),
                new Employee(4, "Patrick", "Torsley", "Accounting")
            };
            EmployeeList.ItemsSource = _employeesList;
        }


        /// <summary>
        /// Заполнение списка департаментов
        /// </summary>
        void DepartmentsListInitialization()
        {
            _departmentsList = new ObservableCollection<Department>()
            {
                new Department("Marketing"),
                new Department("Sales"),
                new Department("IT"),
                new Department("Accounting")
            };

            DepartmentList.ItemsSource = _departmentsList;

        }


        /// <summary>
        /// Клик по кнопке ADD открывает новую форму для добавления сотрудника
        /// (не знаю как получить доступ к _employeesList)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddEmplClick_Click(object sender, RoutedEventArgs e)
        {
            NewEmployeeWindow newEmployeeWindow = new NewEmployeeWindow(new EmplDelegate(emplfunc));
            newEmployeeWindow.Show();
            
        }
         

        /// <summary>
        /// Двойной клик по элементу TextBox Департаментов (нужно доделать редактирование)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(DepartmentList.SelectedItem.ToString());
        }

        /// <summary>
        /// Двойной клик по элементу TextBox Сотрудников(нужно доделать редактирование)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(EmployeeList.SelectedItem.ToString());

        }

        private void BtnAddDeptClick_Click(object sender, RoutedEventArgs e)
        {

            NewDepartmentWindow newDepartmentWindow = new NewDepartmentWindow(new DeptDelegate(deptfunc));
            newDepartmentWindow.Owner = this;
            newDepartmentWindow.Show();
            
        }
    }
}
