using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class UserOrder
    {
        public int Id { get; set; }
        public int PlateCount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
    }
}
