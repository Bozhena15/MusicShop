using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Services
{
    public class AuthorService
    {
        private readonly MusicShopContext _musicShopContext;

        public AuthorService(MusicShopContext musicShopContext)
        {
            _musicShopContext = musicShopContext;
        }

        public IEnumerable<Author> GetAuthors()
        {
            var authors = _musicShopContext.Authors.ToList();
            return authors;
        }

        public void AddNewAuthor(Author author)
        {
            if (author == null)
            {
                throw new NullReferenceException(nameof(author));
            }
            _musicShopContext.Authors.Add(author);
            _musicShopContext.SaveChanges();
        }

        public void DelelteAuthor(int id)
        {
            var author = _musicShopContext.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
                throw new NullReferenceException(nameof(author));

            _musicShopContext.Authors.Remove(author);
            _musicShopContext.SaveChanges();
        }
    }
}
