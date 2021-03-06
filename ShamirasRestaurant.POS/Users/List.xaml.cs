﻿using ShamirasRestaurant.Domain.BBL;
using ShamirasRestaurant.Domain.Infrastructure;
using ShamirasRestaurant.Domain.Models;
using ShamirasRestaurant.Domain.Models.Enums;
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

namespace ShamirasRestaurant.POS.Users
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private long pageSize = 3;
        private long pageIndex = 1;
        private long queryCount = 0;
        private long pageCount = 0;
        private SortOrder sortOrder = SortOrder.Ascending;
        private UserSortOrder sortBy = UserSortOrder.UserName;
        private Role? role = null;
        private string keyword = "";

        public List()
        {
            InitializeComponent();
            cboSortBy.ItemsSource = Enum.GetValues(typeof(UserSortOrder)).Cast<UserSortOrder>();
            cboSortOrder.ItemsSource = Enum.GetValues(typeof(SortOrder)).Cast<SortOrder>();
            List<Role> roles = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();

            List<string> roleItems = new List<string>();
            roleItems.Add("All");
            foreach (Role role in roles)
            {
                roleItems.Add(role.ToString());
            }

            cboRole.ItemsSource = roleItems;

            cboSortBy.SelectedIndex = 0;
            cboSortOrder.SelectedIndex = 0;
            cboRole.SelectedIndex = 0;

            showList();
        }
           
            public void showList()
        {
            Page<ShamirasRestaurant.Domain.Models.User> users = UsersBLL.Search(pageSize, pageIndex, sortBy, sortOrder, role, keyword);
            lblPages.Content = "page " + pageIndex + " of " + users.PageCount;
            lblResult.Content = "Search Result : " + users.QueryCount + " Users";
            queryCount = users.QueryCount;
            pageCount = users.PageCount;
            DgList.ItemsSource = users.Items;
            txtPageSize.Text = users.PageSize.ToString();
        }







        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageCount;
            showList();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;

            if (pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }

            showList();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;

            if (pageIndex < 1)
            {
                pageIndex = 1;
            }

            showList();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showList();
        }

        private void cboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortBy.SelectedValue.ToString() == UserSortOrder.UserName.ToString())
            {
                sortBy = UserSortOrder.UserName;
            }
            else if (cboSortBy.SelectedValue.ToString() == UserSortOrder.FirstName.ToString())
            {
                sortBy = UserSortOrder.FirstName;
            }
            else if (cboSortBy.SelectedValue.ToString() == UserSortOrder.LastName.ToString())
            {
                sortBy = UserSortOrder.LastName;
            }

            showList();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString() == SortOrder.Ascending.ToString())
            {
                sortOrder = SortOrder.Ascending;
            }
            else if (cboSortOrder.SelectedValue.ToString() == SortOrder.Descending.ToString())
            {
                sortOrder = SortOrder.Descending;
            }
            showList();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            keyword = txtboxSearch.Text;
            showList();
        }

        private void cboRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
            else if (cboRole.SelectedValue.ToString() == "All")
            {
                role = null;
            }

            showList();
        }

        private void txtPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                int newPageSize = 3;
                bool result = Int32.TryParse(txtPageSize.Text, out newPageSize);

                if (result == false)
                {
                    newPageSize = 3;

                }

                pageSize = newPageSize;
                showList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users.Add AddWindow = new Users.Add(this);
            AddWindow.Show();

        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            User user = ((FrameworkElement)sender).DataContext as User;
            Update updateWindow = new Update(user,this);
            updateWindow.Show();
        }
        private void btnConfirmDelete_Click(object sender, RoutedEventArgs e)
        {
            User user = ((FrameworkElement)sender).DataContext as User;
            if (MessageBox.Show("Are you sure you want to delete " + user.FirstName + " " + user.FirstName + " " + user.LastName + "?", "Delete User", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                UsersBLL.Delete(user);
                MessageBox.Show("User successfully deleted");
                showList();
            }
        }
    }
}
