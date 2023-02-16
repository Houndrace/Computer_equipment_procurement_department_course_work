using System.Windows;
using System.Windows.Input;

namespace PurchasingDepartment.CommonComands
{
    internal class CommonComands
    {
        public ICommand MinimizeCommand { get; private set; }
        public ICommand ExpandCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }

        public CommonComands()
        {
            MinimizeCommand = new RelayCommand(() =>
            {
                var window = Application.Current.MainWindow;
                if (window != null)
                    window.WindowState = WindowState.Minimized;
            });
            ExpandCommand = new RelayCommand(() =>
            {
                var window = Application.Current.MainWindow;
                if (window != null)
                    if (window.WindowState == WindowState.Maximized)
                        window.WindowState = WindowState.Normal;
                    else
                        window.WindowState = WindowState.Maximized;
            });
            CloseCommand = new RelayCommand(() => Application.Current.Shutdown());
        }
    }
}
