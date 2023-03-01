using PurchasingDepartment.CommonComands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PurchasingDepartment.ViewModels {
    internal class MainViewModel : BaseViewModel {
        // Fields
        public ICommand UnfoldPlaceOrderPageCommand { get; private set; }
        public ICommand GoBackCommand { get; private set; }
        public ICommand GoForwardCommand { get; private set; }
        // Constuctor
        public MainViewModel() {
            UnfoldPlaceOrderPageCommand = new RelayCommand(obj => {
                
            });

            GoBackCommand = new RelayCommand(obj => {
                var frame = obj as Frame;
                if (frame != null) {
                    frame.GoBack();
                }   
            }, obj => {
                var frame = obj as Frame;
                if (frame != null) {
                    return frame.CanGoBack;
                } else {
                    return false;
                }
            });

            GoForwardCommand = new RelayCommand(obj => {
                var frame = obj as Frame;
                if (frame != null) {
                    frame.GoForward();
                }
            }, obj => {
                var frame = obj as Frame;
                if (frame != null) {
                    return frame.CanGoForward;
                } 
                else 
                { 
                    return false; 
                }
            });
        }
        // Properties to be binded
    }
}
