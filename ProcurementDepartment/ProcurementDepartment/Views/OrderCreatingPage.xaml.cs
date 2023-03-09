using ProcurementDepartment.Models.ProcurementModel;
using ProcurementDepartment.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для OrderCreatingView1.xaml
    /// </summary>
    public partial class OrderCreatingPage : Page
    {
        private readonly Frame  _frame;
        private readonly Сотрудник _employee;
        

        private string _orderNumber;
        private string _orderOrganization;
        private DateTime _orderDate;
        private bool _isPaid;
        private Поставщик _supplier;
        private Склад _warehouse;
        private Статус _status;
        private string _productName;
        private int _productQuantity;
        private ЕдиницаИзмерения _productMUnit;
        private decimal _productPrice;
        private List<Товар> _productList;

        public OrderCreatingPage(Frame frame, Сотрудник employee)
        {
            InitializeComponent();
            DataContext = this;
            
            _frame = frame;
            _employee = employee;

            _productList = new List<Товар>();

            _orderNumber = generateOrderNumber();
            lblOrderNumber.Content = _orderNumber;


            using (var db = new ProcurementModel())
            {
                db.Entry(_employee).State = EntityState.Unchanged;
                _orderOrganization = _employee.Организация.Название;
                lblOrderOrganization.Content = _orderOrganization;
                cbxStatus.ItemsSource = db.Статус.ToList();
                cbxSupplier.ItemsSource = db.Поставщик.ToList();
                cbxWarehouse.ItemsSource = db.Склад.ToList();

                cbxMUnit.ItemsSource = db.ЕдиницаИзмерения.ToList();
            }
        }


        private void btnSaveData_Click(object sender, RoutedEventArgs e)
        {
           /* if (!Validator.checkOrder(cbxSupplier.SelectedItem, cbxWarehouse.SelectedItem, cbxStatus.SelectedItem, dtpOrderDate.Text))
            {
                MessageBox.Show("123123");
                return;
            }

            using (var db = new ProcurementModel())
            {
                _supplier = db.Поставщик.FirstOrDefault(sp => sp.НаименованиеФирмы == cbxSupplier.Text);
                _warehouse = db.Склад.FirstOrDefault(wh => wh.Наименование == cbxWarehouse.Text);
                _status = db.Статус.FirstOrDefault(s => s.Название == cbxStatus.Text);
            }
            _orderDate = DateTime.Parse(dtpOrderDate.Text);
            _isPaid = (bool)chkIsPaid.IsChecked;*/


            /*if (!Validator.checkProduct(ProductName, Quantity, ProductPrice, CurrentProduct.КодЕденицыИзмерения))
            {
                MessageBox.Show("fdsafas");
                return;
            }*/

            Заказ order = new Заказ()
            {
                Дата = _orderDate,
                Номер = _orderNumber,
                Оплачено = _isPaid,
                Поставщик = _supplier,
                Склад = _warehouse,
                Статус = _status,
                Сотрудник = _employee
            };

            order.Товар = _productList;

            using (var db = new ProcurementModel())
            {
                db.ЕдиницаИзмерения.Attach(_productMUnit);
                db.Поставщик.Attach(_supplier);
                db.Склад.Attach(_warehouse);
                db.Статус.Attach(_status);
                db.Сотрудник.Attach(_employee);

                db.Заказ.Add(order);
                db.SaveChanges();
            }


            _frame.Navigate(new OrdersPage(_frame, _employee));
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!Validator.checkProduct(txtProductName.Text, txtProductQuantity.Text, cbxMUnit.SelectedItem, txtProductPrice.Text))
            {
                MessageBox.Show("fdsafas");
                return;
            }

            _productName = txtProductName.Text;

            _productQuantity = Int32.Parse(txtProductQuantity.Text);

            /*using (var db = new ProcurementModel())
            {
                _productMUnit = db.ЕдиницаИзмерения.FirstOrDefault(mu => mu.Название == cbxMUnit.Text);
            }*/

            _productMUnit = (ЕдиницаИзмерения)cbxMUnit.SelectedItem;

            _productPrice = Decimal.Parse(txtProductPrice.Text);


            _supplier = (Поставщик)cbxSupplier.SelectedItem;
            _warehouse = (Склад)cbxWarehouse.SelectedItem;
            _status = (Статус)cbxStatus.SelectedItem;



            _orderDate = DateTime.Parse(dtpOrderDate.Text);
            _isPaid = (bool)chkIsPaid.IsChecked;

                MessageBox.Show(_warehouse.Код.ToString());


            Товар product = new Товар()
            {
                ЕдиницаИзмерения = _productMUnit,
                Количество = _productQuantity,
                Название = _productName,
                Цена = _productPrice
            };

            _productList.Add(product);
        }

        private string generateOrderNumber()
        {
            int currentOrderNumber;
            using (var db = new ProcurementModel())
            {
                currentOrderNumber = db.Заказ.Count() + 1;
            }
            return currentOrderNumber.ToString().PadLeft(6, '0');
      
        }
        
    }
}
