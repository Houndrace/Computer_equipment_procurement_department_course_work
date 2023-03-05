using PurchasingDepartment.ViewModels;
using System;
using System.Collections.Generic;
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

namespace PurchasingDepartment.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrderCreatingPage page = new OrderCreatingPage();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(new Models.ProcurementModel.Сотрудник());
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MainWindowFrame.Navigate(page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            MainWindowFrame.Navigate(new OrderCreatingPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
   
        }
    }
}
