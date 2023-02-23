using ControlzEx.Standard;
using System.Web.UI;
using System.Windows;
using System.Windows.Input;

namespace PurchasingDepartment.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для CustomToolBar.xaml
    /// </summary>
    public partial class CustomTitleBar : System.Windows.Controls.UserControl
    {
        // Fields
        public static readonly DependencyProperty MinimizeIconHiddenProperty =
            DependencyProperty.Register("MinimizeIconCollapsed", typeof(bool),
                typeof(CustomTitleBar), new PropertyMetadata(false, OnMinimizeIconCollapsedChanged));
        public static readonly DependencyProperty ExpandIconHiddenProperty =
            DependencyProperty.Register("ExpandIconCollapsed", typeof(bool),
                typeof(CustomTitleBar), new PropertyMetadata(false, OnExpandIconCollapsedChanged));
        // Constructor
        public CustomTitleBar()
        {
            InitializeComponent();
        }
        // Custom title bar propetiers
        public bool MinimizeIconHidden
        {
            get => (bool)GetValue(MinimizeIconHiddenProperty);
            set => SetValue(MinimizeIconHiddenProperty, value);
        }

        public bool ExpandIconHidden
        {
            get => (bool)GetValue(ExpandIconHiddenProperty);
            set => SetValue(ExpandIconHiddenProperty, value);
        }
        // Methods
        private static void OnMinimizeIconCollapsedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var bar = d as CustomTitleBar;
            if (bar != null)
            {
                if ((bool)e.NewValue)
                    bar.MinimizeButton.Visibility = Visibility.Collapsed;
                else
                    bar.MinimizeButton.Visibility = Visibility.Visible;
            }
        }

        private static void OnExpandIconCollapsedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var titleBar = d as CustomTitleBar;
            if (titleBar != null)
            {
                if ((bool)e.NewValue)
                    titleBar.ExpandButton.Visibility = Visibility.Collapsed;
                else
                    titleBar.ExpandButton.Visibility = Visibility.Visible;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.Close();
        }

        private void ExpandButton_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (window.WindowState == WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
            }
            else
            {
                window.WindowState = WindowState.Maximized;
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.WindowState = WindowState.Minimized;
        }
    }
}
