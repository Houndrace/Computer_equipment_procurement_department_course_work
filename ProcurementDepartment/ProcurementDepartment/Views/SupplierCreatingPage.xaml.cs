using ProcurementDepartment.Models.ProcurementModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ProcurementDepartment.Views
{
    /// <summary>
    /// Логика взаимодействия для SupplierCreatingPage.xaml
    /// </summary>
    public partial class SupplierCreatingPage : Page, INotifyPropertyChanged
    {
        private readonly Frame _frame;
        private readonly Сотрудник _employee;
        public SupplierCreatingPage(Frame frame, Сотрудник employee)
        {
            InitializeComponent();
            DataContext = this;
            _frame = frame;
            _employee = employee;
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
