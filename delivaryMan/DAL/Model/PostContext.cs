using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    internal class PostContext: DbContext
    {
        public DbSet<DelivaryMan> Ddetails { get; set; }
        public DbSet<FoodDelivary> Udetails { get; set; }
        public DbSet<OrderPlacement> Odetails { get; set; }

    }
}
