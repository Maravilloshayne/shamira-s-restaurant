using ShamirasRestaurant.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
    }
}
