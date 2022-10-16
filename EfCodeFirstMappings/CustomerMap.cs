using System.Data.Entity.ModelConfiguration;

namespace EntityFMysql.EfCodeFirstMappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>    
    {
        public CustomerMap()
        {
            this.HasKey(t=> t.CustomerID);
            this.Property(t => t.CustomerID)
                .IsRequired()
                .HasMaxLength(5);
            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);
            this.Property(t => t.City)
                .HasMaxLength(20);
            this.Property(t => t.ContactName)
                .HasMaxLength(30);
            this.Property(t => t.Country)
                .HasMaxLength(15);
            ToTable("Customers");

            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.City).HasColumnName("City");
        }
    }
}
