using System.Data.Entity;
using EntityFMysql.EfCodeFirstMappings;
using MySql.Data.EntityFramework;

namespace EntityFMysql.context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class NorthwindContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }

    }
}
