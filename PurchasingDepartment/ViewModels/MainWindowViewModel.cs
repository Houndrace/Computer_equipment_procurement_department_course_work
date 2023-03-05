using PurchasingDepartment.CommonComands;
using PurchasingDepartment.Models;
using PurchasingDepartment.Models.ProcurementModel;
using PurchasingDepartment.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PurchasingDepartment.ViewModels {
    public class MainWindowViewModel : BaseViewModel  {

        private Uri currentPage;
        public Uri CurrentPage {
            get => currentPage;
            set {
                currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        private Сотрудник employee;
        public Сотрудник Employee
        {
            get => employee;
            set
            {
                employee = value;
                OnPropertyChanged(nameof(Employee));
            }
        }

        private string fullName;
        public string FullName
        {
            get => fullName;
            set
            {
                fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        public ICommand NavigateToPage { get; private set; }
        public MainWindowViewModel(Сотрудник employee) 
        {
            //Employee = employee; разработка
            using (var db = new ProcurementModel())
            {
                Employee = db.Сотрудник.ToList()[0];
            }
            FullName = getFullName();
            NavigateToPage = new RelayCommand(navigateToPage);
        }

        private void navigateToPage(object obj) 
        {
            var navigationService = NavigationService.GetNavigationService(Application.Current.MainWindow);
            
            string page = obj as string;
            Uri uri = new Uri(page, UriKind.Relative);
            navigationService.Navigate(uri);
        }

        private string getFullName()
        {
            return Employee.Фамилия + " " + Employee.Имя + " " + Employee.Отчество;
        }
    }
}
