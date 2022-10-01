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
using MusicShop.Services;
using MusicShop.Models;

namespace MusicShop.Windows.Users
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        private MusicShopContext context;
        private UserService Service;
        private List<User> UsersList;
        private AddUser AddUserWindow;
        public UsersWindow(MusicShopContext musicshop_context)
        {
            InitializeComponent();
            UsersList = new List<User>();
            
            this.context = musicshop_context;
            Service = new UserService(context);
            UpdateList();
        }
        public void UpdateList()
        {
            UsersList = Service.GetUsers().ToList();
            UsersListBox.Items.Clear();
            foreach(User user in UsersList)
            {
                UsersListBox.Items.Add(user);
            }
        }

        private void BtnAddUser(object sender, RoutedEventArgs e)
        {
            AddUserWindow = new AddUser(context);
            AddUserWindow.ShowDialog();
            UpdateList();
        }

        private void BtnDeleteUser(object sender, RoutedEventArgs e)
        {
            User dltuser = (User)UsersListBox.SelectedItem;
            Service.DeleteUser(dltuser.Id);
            UpdateList();
        }

        private void NewSelectedCount(object sender, SelectionChangedEventArgs e)
        {
            if (UsersListBox.SelectedItems.Count != 0)
                DeleteUser.Visibility = Visibility.Visible;
            
            if(UsersListBox.SelectedItems.Count == 0)
                DeleteUser.Visibility = Visibility.Hidden;
        }
    }
}
