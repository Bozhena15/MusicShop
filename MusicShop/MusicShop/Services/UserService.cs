using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Services
{
    public class UserService
    {
        private readonly MusicShopContext _musicShopContext;

        public UserService(MusicShopContext musicShopContext)
        {
            _musicShopContext = musicShopContext;
        }

        public IEnumerable<User> GetUsers()
        {
            var users = _musicShopContext.Users.ToList();
            return users;
        }

        public void AddNewUser(User user)
        {
            if(user == null)
                throw new NullReferenceException(nameof(user));
            
            _musicShopContext.Users.Add(user);
            _musicShopContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _musicShopContext.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)

                throw new NullReferenceException(nameof(user));
            _musicShopContext.Users.Remove(user);
            _musicShopContext.SaveChanges();
        }
    }
}
