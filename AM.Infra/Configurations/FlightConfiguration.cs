using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infra.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // Configure many-to-many relationship between Flight and Passenger
            builder.HasMany(f => f.Passengers)
                .WithMany(p => p.Flights)
                .UsingEntity(j => j.ToTable("FlightPassengers"));

            // Configure one-to-many relationship between Plane and Flight
            builder.HasOne(f => f.Plane)
                .WithMany(p => p.Flights)
                .HasForeignKey("PlaneId");
        }
    }
}
