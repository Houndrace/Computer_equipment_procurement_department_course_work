using ProcurementDepartment.Models.ProcurementModel;
using ProcurementDepartment.ViewModels;
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
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private readonly Сотрудник _employee;
        private readonly string _employeeLogin;
        private readonly Frame _frame;

        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public MainWindow(/*Сотрудник employee*/)
        {
            InitializeComponent();
            DataContext = this;

            using (var db = new ProcurementModel())
            {
                _employee = db.Сотрудник.ToList()[0];
            }

            _frame = MainWindowFrame;

            FullName = getFullName();
            

        }


        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new OrdersPage(_frame, _employee));
        }

        private void btnSuppliers_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new SuppliersPage(_frame, _employee));
        }

        /*private void btnWarehouses_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate( new WarehousesPage(MainWindowFrame, _employee));
        }*/

        private string getFullName()
        {
            return _employee.Фамилия + " " + _employee.Имя + " " + _employee.Отчество;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
