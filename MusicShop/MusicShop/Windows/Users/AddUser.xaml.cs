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

namespace MusicShop.Windows.Users
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private MusicShopContext context;
        private UserService Service;
        public AddUser(MusicShopContext musicshopcontext)
        {
            InitializeComponent();
            context = musicshopcontext;
            Service = new UserService(context);
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            Models.User newuser = new Models.User();
            newuser.UserName = UsernameText.Text;
            newuser.UserSurname = SurnameText.Text;

            if (!string.IsNullOrEmpty(UsernameText.Text) && !string.IsNullOrEmpty(SurnameText.Text))
            {
                Service.AddNewUser(newuser);
                this.Close();

            }   
            else
                MessageBox.Show("Empty fields", "Warning!", MessageBoxButton.OK);
        }
    }
}
