using ShamirasRestaurant.Domain.Infrastructure;
using ShamirasRestaurant.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Models
{
    public class Orders : BaseModel
    {
        public decimal OrderNo { get; set; }
        public decimal TableNo { get; set; }
        public OrderStatus Status { get; set; }
        public bool Paid { get; set; }
    }
}
