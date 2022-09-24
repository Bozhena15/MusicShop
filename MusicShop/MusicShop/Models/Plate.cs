using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Plate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int EditionId { get; set; }
        public int AuthorId { get; set; }
        public int TrackCount { get; set; }
        public DateTime Year { get; set; }
        public int PlatePrice { get; set; }
        public int PlateCost { get; set; }
        public Genre Genre { get; set; }
        public Edition Edition { get; set; }
        public Author Author { get; set; }
        public List<UserOrder> UserOrders { get; set; }
    }
}
