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
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginWindow : Window, INotifyPropertyChanged
    {
        private Сотрудник _employee;

        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }

        }

        public string Password { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ProcurementModel())
            {
                _employee = db.Сотрудник.FirstOrDefault(u => u.Пароль == Password && u.Логин == Login);
            }

            if (_employee != null)
            {
                MainWindow mainView = new MainWindow(/*_employee*/);
                mainView.Show();
                Close();
            }
            else
            {
                ErrorMessage = "Пользователь или пароль не найдены, проверьте данные и повторите попытку.";
            }
        }

        private void pbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = pbPassword.Password;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
