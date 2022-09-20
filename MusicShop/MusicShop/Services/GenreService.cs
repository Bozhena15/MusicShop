using Microsoft.EntityFrameworkCore;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Services
{
    public class GenreService
    {
        private readonly MusicShopContext _musicShopContext;
        
        public GenreService( MusicShopContext musicShopContext)
        {
            _musicShopContext = musicShopContext;
        }

        public IEnumerable<Genre> GetGenres()
        {
            var genres = _musicShopContext.Genres.ToList();
            return genres;
        }

        public void AddNewGenre(Genre genre)
        {
            if (genre == null)
            {
                throw new NullReferenceException(nameof(genre));
            }
            _musicShopContext.Genres.Add(genre);
            _musicShopContext.SaveChanges();
        }

        public void DelelteGenre(int id)
        {
            var genre = _musicShopContext.Genres.FirstOrDefault(x => x.Id == id);
            if (genre == null)
                throw new NullReferenceException(nameof(genre));

            _musicShopContext.Genres.Remove(genre);
            _musicShopContext.SaveChanges();
        }


    }
}
