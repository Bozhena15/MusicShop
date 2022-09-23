using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Services
{
    public class EditionService
    {
        private readonly MusicShopContext _musicShopContext;

        public EditionService(MusicShopContext musicShopContext)
        {
            _musicShopContext = musicShopContext;
        }

        public IEnumerable<Edition> GetEditions()
        {
            var editions = _musicShopContext.Editions.ToList();
            return editions;
        }

        public void AddNewEdition(Edition edition)
        {
            if (edition == null)
                throw new NullReferenceException(nameof(edition));

            _musicShopContext.Editions.Add(edition);
            _musicShopContext.SaveChanges();
        }

        public void DelteUser(int id)
        {
            var edition = _musicShopContext.Editions.FirstOrDefault(x => x.Id == id);

            if (edition == null)
                throw new NullReferenceException(nameof(edition));

            _musicShopContext.Editions.Remove(edition);
            _musicShopContext.SaveChanges();
        }
    }
}
