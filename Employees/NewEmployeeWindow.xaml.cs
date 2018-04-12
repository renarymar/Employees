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
using System.Windows.Shapes;

namespace Employees
{
    /// <summary>
    /// Interaction logic for NewEmployeeWindow.xaml
    /// </summary>
    public partial class NewEmployeeWindow : Window
    {

        public NewEmployeeWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            

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
