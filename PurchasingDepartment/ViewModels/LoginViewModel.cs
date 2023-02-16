using PurchasingDepartment.CommonComands;
using PurchasingDepartment.Models.DataBase;
using System.Windows;
using System.Windows.Input;

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
                    // Новое окно
                    Window window = new Window();
                    window.Show();
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
