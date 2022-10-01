using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MusicShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public List<UserOrder> userOrders { get; set; }

        
        public string Edit(string obj)
        {
            string final = obj;
            for (int i = 0; i < 50-obj.Length; i++)
            {
                final += " ";
            }
            return final;
        }
        public override string ToString()
        {
            return $"   {Edit(Id.ToString())}  {Edit(UserName)}        {UserSurname}";
        }
    }
}
