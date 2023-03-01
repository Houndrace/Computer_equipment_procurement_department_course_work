using PurchasingDepartment.CommonComands;
using PurchasingDepartment.Models.ProcurementModel;
using PurchasingDepartment.Views;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PurchasingDepartment.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        // Fields
        private string errorMessage;
        private readonly Сотрудник employee;
        public ICommand AuthorizeCommand { get; private set; }
        // Constuctor
        public LoginViewModel()
        {
            employee = new Сотрудник();
            AuthorizeCommand = new RelayCommand(obj =>
            {
                var isUserExists = employee.Authenticate();
                if (isUserExists)
                {
                    ErrorMessage = "";
                    MainWindow mainWindow = new MainWindow();
                    Application.Current.Windows[0].Close();
                    mainWindow.Show();
                }
                else
                {
                    ErrorMessage = "Пользователь или пароль не найден, проверьте данные и повторите попытку.";
                }
            });
        }

        // Properties to be binded
        public string Login
        {
            get => employee.Логин;
            set
            {
                employee.Логин = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get => employee.Пароль;
            set
            {
                employee.Пароль = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
    }
}
