using PurchasingDepartment.CommonComands;
using PurchasingDepartment.Models;
using PurchasingDepartment.Models.ProcurementModel;
using PurchasingDepartment.Views;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PurchasingDepartment.ViewModels
{
    public class LoginWindowViewModel : BaseViewModel
    {
        // Login field
        private string login;
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        // Password field
        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        // ErrorMessage field
        private string errorMessage;
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public ICommand AuthorizeCommand { get; private set; }
        // Constuctor
        public LoginWindowViewModel()
        {
            
            AuthorizeCommand = new RelayCommand(loginEmployee);
        }

        private void loginEmployee(object obj)
        {
            var employee = authenticate();
            if (employee != null)
            {
                ErrorMessage = "";
                var mainWindowViewModel = new MainWindowViewModel(employee);
                MainWindow mainWindow = new MainWindow() { DataContext = mainWindowViewModel };
                Application.Current.Windows[0].Close();
                mainWindow.Show();
            }
            else
            {
                ErrorMessage = "Пользователь или пароль не найдены, проверьте данные и повторите попытку.";
            }
        }

        private Сотрудник authenticate()
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                return null;
            }

            using (var db = new ProcurementModel())
            {
                var employee = db.Сотрудник.FirstOrDefault(u => u.Пароль == Password && u.Логин == Login);
                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    return null;
                }
                
            }
        }
    }
}
