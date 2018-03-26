using ShamirasRestaurant.Domain.BBL;
using ShamirasRestaurant.Domain.Models.Enums;
using System;
using System.Linq;
using System.Windows;

namespace ShamirasRestaurant.POS.Users
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
                public partial class Add : Window
              {

    
                Users.List _sender;

                public Add(Users.List sender)
              {

                InitializeComponent();
                cboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
                this._sender = sender;
              }

                private void btnclose_Click(object sender, RoutedEventArgs e)
              {
                this.Close();
              }

              private void btnsave_Click_1(object sender, RoutedEventArgs e)
              {
                if (Validate() == false)
                {
                return;
                }
           
                if (UsersBLL.GetUserByUserName(txtUserName.Text) != null)
                {
                MessageBox.Show("Username is already used");
                this.Close();

                }
                else
              {
                ShamirasRestaurant.Domain.Models.User user = new ShamirasRestaurant.Domain.Models.User();
                user.Id = Guid.NewGuid();
                user.UserName = txtUserName.Text;
                user.LastName = txtLastName.Text;
                user.FirstName = txtFirstName.Text;
                
                Role role = new Role();
                if (cboRole.SelectedValue.ToString() == Role.Admin.ToString())
              {
                role = Role.Admin;
              }
                else if (cboRole.SelectedValue.ToString() == Role.Cashier.ToString())
              {
                role = Role.Cashier;
              }
                else if (cboRole.SelectedValue.ToString() == Role.Chef.ToString())
              {
                role = Role.Chef;
              }
                else if (cboRole.SelectedValue.ToString() == Role.InventoryController.ToString())
              {
                role = Role.InventoryController;
              }
                else if (cboRole.SelectedValue.ToString() == Role.Waiter.ToString())
              {
                role = Role.Waiter;
              }
                
                user.Role = role;
                user.Password = this.RandomString(6);
                UsersBLL. Create (user);
                MessageBox.Show("User successfully created.");
                this._sender.showList();
                this.Close();
              }
              }

                private bool Validate()
              {
                if(string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                cboRole.SelectedValue == null)
              {
                MessageBox.Show("Please input correct values");
                return false;
              }
                  return true;
              }

                 private Random random = new Random();
                 private string RandomString(int length)
              {
                 const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
                 return new string (Enumerable.Repeat(chars, length)
                 .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
