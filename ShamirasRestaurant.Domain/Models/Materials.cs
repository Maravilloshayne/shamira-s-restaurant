using ShamirasRestaurant.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Models
{
   public class Materials : BaseModel
    {
        public string Name { get; set; }
        public string UOM { get; set; } // Unit of Measure
        public decimal Quantity { get; set; }
    }
}
