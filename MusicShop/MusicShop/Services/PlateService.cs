using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Services
{
    public class PlateService
    {
        private readonly MusicShopContext musicshopcontext;

        public PlateService(MusicShopContext musicshopcontext)
        {
            this.musicshopcontext = musicshopcontext;
        }

        public void AddPlate(Plate newPlate)
        {
            if(newPlate == null)
                throw new Exception($"{nameof(Plate)} cannot be null");

            musicshopcontext.Plates.Add(newPlate);
            musicshopcontext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            Plate? plate = musicshopcontext.Plates.FirstOrDefault(x=> x.Id == id);

            if (plate == null)
                throw new Exception("Wrong object id to delete");

            musicshopcontext.Plates.Remove(plate);
            musicshopcontext.SaveChanges();
        }

        public IEnumerable<Plate> GetPlates()
        {
            var plates = musicshopcontext.Plates.ToList();

            return plates;
        }
    }
}
