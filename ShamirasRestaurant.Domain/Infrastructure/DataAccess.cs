using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Infrastructure
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(
                new ShamirasRestaurant.Domain.Infrastructure.DataInitializer()
            );
        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Delivery> Deliveries { get; set; }
        public DbSet<Models.DeliveryItems> DeliveryItem { get; set; }
        public DbSet<Models.Materials> Materials { get; set; }
    }
}
