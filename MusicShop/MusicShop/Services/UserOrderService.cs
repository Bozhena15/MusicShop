using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MusicShop.Services
{
    public class UserOrderService
    {
        private readonly MusicShopContext _musicShopContext;

        public UserOrderService(MusicShopContext musicShopContext)
        {
            _musicShopContext = musicShopContext;
        }

        public IEnumerable<UserOrder> GetUsers()
        {
            var orders = _musicShopContext.UserOrders.ToList();
            return orders;
        }

        public void AddNewUser(UserOrder order)
        {
            if (order == null)
                throw new NullReferenceException(nameof(order));

            _musicShopContext.UserOrders.Add(order);
            _musicShopContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var order = _musicShopContext.UserOrders.FirstOrDefault(x => x.Id == id);
            if (order == null)
                throw new NullReferenceException(nameof(order));

            _musicShopContext.UserOrders.Remove(order);
            _musicShopContext.SaveChanges();
        }
    }
}
