using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infra.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            // Configure PlaneId as primary key
            builder.HasKey(p => p.PlaneId);

            // Configure table name as "MyPlanes"
            builder.ToTable("MyPlanes");

            // Configure column name for Capacity as "PlaneCapacity"
            builder.Property(p => p.Capacity)
                .HasColumnName("PlaneCapacity");
        }
    }
}
