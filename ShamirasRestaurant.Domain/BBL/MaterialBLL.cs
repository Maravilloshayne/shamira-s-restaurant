using ShamirasRestaurant.Domain.Infrastructure;
using ShamirasRestaurant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.BBL
{
    public class MaterialBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<Materials> GetAll()
        {
            return db.Materials.ToList();
        }

        public static Materials SearchByName(string name)
        {
            return db.Materials.FirstOrDefault(m => m.Name == name);
        }
    }
}
