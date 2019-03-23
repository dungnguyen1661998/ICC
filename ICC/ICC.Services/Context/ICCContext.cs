using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICC.Services.Context
{
    public class ICCContext : DbContext
    {
        public ICCContext()
           : base("name=ICCConnectionString")
        {
        }
        public DbSet UserAcount { get; set; }
        public DbSet UserRole { get; set; }
        public DbSet Role { get; set; }
        public DbSet OrderItem { get; set; }
        public DbSet Membership { get; set; }
        public DbSet Machine { get; set; }
        public DbSet Item { get; set; }
        public DbSet Facility { get; set; }
        public DbSet BuyFacility { get; set; }
        public DbSet BookMachine { get; set; }
    }
}