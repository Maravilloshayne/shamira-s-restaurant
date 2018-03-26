using ShamirasRestaurant.Domain.BBL;
using ShamirasRestaurant.Domain.CustomModels;
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
using System.Windows.Shapes;

namespace ShamirasRestaurant.POS.Delivery
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public CustomDelivery delivery = new CustomDelivery();
        private Delivery.List _sender;

        public Add(Delivery.List sender)
        {
            InitializeComponent();
            lblDate.Content = DateTime.Now.ToString("ddd dd MMMM yyyy");
            delivery.Date = DateTime.Now;
            this._sender = sender;
        }

        public void ShowList()
        {
            grDeliveryItemList.ItemsSource = null;
            grDeliveryItemList.ItemsSource = this.delivery.Items;
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var saved = DeliveryBLL.Create(delivery);
            this._sender.showList();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Delivery.AddItem addItemWindow = new Delivery.AddItem(this);
            addItemWindow.Show();

        }
    }
}
