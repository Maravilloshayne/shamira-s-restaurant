using ShamirasRestaurant.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Models
{
    
        public class DeliveryItems : BaseModel
    {
        public Guid? MaterialId { get; set; }

        public virtual Materials Material { get; set; }

        public decimal Quantity { get; set; }

        public Guid? DeliveryId { get; set; }
    }
}
   
  
