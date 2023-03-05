using PurchasingDepartment.CommonComands;
using PurchasingDepartment.Models.ProcurementModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PurchasingDepartment.ViewModels {
    internal class OrderCreatingPageViewModel : BaseViewModel{
        #region Order
        // Status fields
        private Статус currentStatus;
        public Статус CurrentStatus {
            get => currentStatus;
            set 
            {
                currentStatus = value;
                OnPropertyChanged(nameof(CurrentStatus));
            }
        }

        private List<Статус> statuses;
        public List<Статус> Statuses {
            get => statuses;
            set {
                statuses = value;
                OnPropertyChanged(nameof(Statuses));
            }
        }
        // Number field
        private string orderNumber;
        public string OrderNumber {
            get => orderNumber;
            set 
            {
                orderNumber = value;
                OnPropertyChanged(nameof(OrderNumber));
            }
        }
        // Date field
        private string orderDate;
        public string OrderDate {
            get => orderDate;
            set 
            {
                orderDate = value;
                OnPropertyChanged(nameof(OrderDate));
            }
        }
        // Organization field
        private Организация currentOrganization;
        public Организация CurrentOrganization {
            get => currentOrganization;
            set 
            {
                currentOrganization = value;
                OnPropertyChanged(nameof(CurrentOrganization));
            }
        }
        // Suppliers fields
        private Поставщик currentSupplier;
        public Поставщик CurrentSupplier {
            get => currentSupplier;
            set 
            {
                currentSupplier = value;
                OnPropertyChanged(nameof(CurrentSupplier));
            }
        }

        private List<Поставщик> suppliers;
        public List<Поставщик> Suppliers {
            get => suppliers;
            set 
            {
                suppliers = value;
                OnPropertyChanged(nameof(Suppliers));
            }
        }
        // Warehouse fields
        private Склад currentWarehouse;
        public Склад CurrentWarehouse {
            get => currentWarehouse;
            set 
            {
                currentWarehouse = value;
                OnPropertyChanged(nameof(CurrentWarehouse));
            }
        }

        private List<Склад> warehouses;
        public List<Склад> Warehouses {
            get => warehouses;
            set 
            {
                warehouses = value;
                OnPropertyChanged(nameof(Warehouses));
            }
        }
        // IsPaid field
        private bool isPaid;
        public bool IsPaid {
            get => isPaid;
            set {
                isPaid = value;
                OnPropertyChanged(nameof(IsPaid));
            }
        }
        #endregion
        public ICommand SaveCommand { get; }

        public OrderCreatingPageViewModel() {
            using (var db = new ProcurementModel()) 
            {
                // Status combobox
                Statuses = new List<Статус>();
                Statuses.AddRange(db.Статус.ToList());
                // Order label
                OrderNumber = generateOrderNumber();
                // Organization label
                //CurrentOrganization = ;
                // Supplier combobox
                Suppliers = new List<Поставщик>();
                Suppliers.AddRange(db.Поставщик.ToList());
                // Warehouse combobox
                Warehouses = new List<Склад>();
                Warehouses.AddRange(db.Склад.ToList());
            }
            SaveCommand = new RelayCommand(saveData);
        }
        private void saveData(object obj) {
            
            using (var db = new ProcurementModel()) 
            {

                MessageBox.Show(CurrentSupplier.КодАдреса.ToString());
            }
            
            return;

            using (var db = new ProcurementModel()) {
                Заказ order = new Заказ() {
                    Оплачено = IsPaid,
                    Номер = OrderNumber,
                    Дата = DateTime.Parse(OrderDate),
                    Поставщик = CurrentSupplier,
                    Склад = CurrentWarehouse,
                    //Сотрудник = db.Сотрудник
                    Статус = CurrentStatus
                };
            }
        }

        private string generateOrderNumber()
        {
            using (var db = new ProcurementModel())
            {
                int currentOrderNumber = db.Заказ.Count() + 1;
                return currentOrderNumber.ToString().PadLeft(6, '0');
            }
        }
    }
}
