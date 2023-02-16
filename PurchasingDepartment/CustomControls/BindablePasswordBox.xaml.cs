using System.Windows;
using System.Windows.Controls;

namespace PurchasingDepartment.CustomControls
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty passwordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox));

        public BindablePasswordBox()
        {
            InitializeComponent();
        }

        public string Password
        {
            get => (string)GetValue(passwordProperty);
            set => SetValue(passwordProperty, value);
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = pbPassword.Password;
        }
    }
}
