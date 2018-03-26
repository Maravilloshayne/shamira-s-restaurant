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

namespace ShamirasRestaurant.POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            Users.List userWindow = new Users.List();
            userWindow.Show();
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            Category.List categoryWindow = new Category.List();
            categoryWindow.Show();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            Products.List productWindow = new Products.List();
            productWindow.Show();
        }

        private void btnDelivery_Click(object sender, RoutedEventArgs e)
        {
            Delivery.List productWindow = new Delivery.List();
            productWindow.Show();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Order.List orderWindow = new Order.List();
            orderWindow.Show();
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            sales.List SaleWindow = new sales.List();
            SaleWindow.Show();
        }

        private void btnRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe.List recipeWindow = new Recipe.List();
            recipeWindow.Show();
        }
    }
}
