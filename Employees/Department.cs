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
        private string depName;
        public event PropertyChangedEventHandler PropertyChanged;

        public string DepName
        {
            set
            {
                depName = value;
                OnPropertyChanged("DepName");
            }
            get => depName;
        }

        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }

}
