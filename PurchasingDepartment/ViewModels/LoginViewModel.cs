using PurchasingDepartment.CommonComands;
using PurchasingDepartment.Models.DataBase;
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
        private readonly User user;
        public ICommand AuthorizeCommand { get; private set; }
        // Constuctor
        public LoginViewModel()
        {
            user = new User();
            AuthorizeCommand = new RelayCommand(() =>
            {
                var isUserExists = user.Authenticate();
                if (isUserExists)
                {
                    ErrorMessage = "";
                    // Новое окно
                    MainWindow mainWindow = new MainWindow();
                    Application.Current.Windows[0].Close();
                    mainWindow.Show();
                }
                else
                {
                    ErrorMessage = "Пользователь или пароль не найдены, проверьте данные и повторите попытку.";
                }
            });
        }

        // Properties to be binded
        public string Login
        {
            get => user.Login;
            set
            {
                user.Login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
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
