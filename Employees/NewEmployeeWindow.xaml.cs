using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Employees
{
    /// <summary>
    /// Interaction logic for NewEmployeeWindow.xaml
    /// </summary>
    public partial class NewEmployeeWindow : Window
    {
        EmplDelegate d;

        public NewEmployeeWindow(EmplDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        /// <summary>
        /// Тут должно быть что-то вроде _employeesList.Add..., но я пока не знаю как получить доступ к _employeesList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int _id = Int32.Parse(employeeID_textBox.Text);
            d(_id, firstName_textBox.Text, lastName_textBox.Text, department_textBox.Text);
            this.Close();
        }

        /// <summary>
        /// Закрываем текущее окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
