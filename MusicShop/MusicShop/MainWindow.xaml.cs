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
using MusicShop.Windows;

namespace MusicShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MusicShopContext musicShopContext;
        private Windows.Users.UsersWindow usersWindow;
        public MainWindow()
        {
            InitializeComponent();
            musicShopContext = new MusicShopContext();
            usersWindow = new Windows.Users.UsersWindow(musicShopContext);
        }

        private void BtnOpenUsers(object sender, RoutedEventArgs e)
        {
            usersWindow.Show();
        }

        private void BtnOpenGenres(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOpenEditions(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOpenOrders(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOpenPlates(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOpenAuthors(object sender, RoutedEventArgs e)
        {

        }
    }
}
