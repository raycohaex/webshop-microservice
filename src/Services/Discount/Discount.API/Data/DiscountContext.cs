using Discount.API.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Discount.API.Data
{
    public class DiscountContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DiscountContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("DatabaseSettings"));
        }

        public DbSet<Coupon> Coupons { get; set; }
    }
}
