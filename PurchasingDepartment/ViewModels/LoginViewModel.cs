using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Navigation.EventArguments;
using MvvmCross.ViewModels;
using PurchasingDepartment.Models;
using PurchasingDepartment.Models.ProcurementModel;
using PurchasingDepartment.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace PurchasingDepartment.ViewModels
{
    public class LoginViewModel 
    {
       /*#region Fields
        private string login;
        private string password;
        private string errorMessage;
        private Сотрудник employee;

        #endregion

        public LoginViewModel()
        {

            AuthorizeCommand = new MvxCommand(() =>
            {
                using (var db = new ProcurementModel())
                {
                    employee = db.Сотрудник.FirstOrDefault(u => u.Пароль == Password && u.Логин == Login);
                }

                if (employee != null)
                {
                    ErrorMessage = "";
                    //var mainWindowViewModel = new MainWindowViewModel(employee);
                    //MainWindow mainWindow = new MainWindow() { DataContext = mainWindowViewModel };
                    //mainWindow.Show();
                    Application.Current.MainWindow?.Close();
                }
                else
                {
                    ErrorMessage = "Пользователь или пароль не найдены, проверьте данные и повторите попытку.";
                }
            });

        }

        #region Properties
        public IMvxCommand AuthorizeCommand { get; }
        public string Login
        {
            get => login;
            set => SetProperty(ref login, value);
        }
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }
        public string ErrorMessage
        {
            get => errorMessage;
            set => SetProperty(ref errorMessage, value);
        }
        #endregion
    }*/
         
}
