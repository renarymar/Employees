﻿using System;
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
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>

    public partial class EmployeeWindow : Window
        {
            public Employee Employee { get; private set; }

            public EmployeeWindow(Employee e)
            {
                InitializeComponent();
                Employee = e;
                this.DataContext = Employee;
            }

            private void Accept_Click(object sender, RoutedEventArgs e)
            {
                this.DialogResult = true;
            }

    }

}

