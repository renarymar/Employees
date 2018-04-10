using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NewDepartmentWindow.xaml
    /// </summary>
    /// 
    public partial class NewDepartmentWindow : Window
        
    {
        DeptDelegate d;
        public NewDepartmentWindow(DeptDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Добавляем новый департамент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddDeptClick_Click(object sender, RoutedEventArgs e)
        {
            d(department_TextBox.Text);
            this.Close();

        }
    }
}
