using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnumsRepresentation
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(car => car.Id);

            builder.Property(car => car.CarTypeId)
                .IsRequired();

            builder.HasOne<CarTypeEntity>()
                .WithMany()
                .HasForeignKey(car => car.CarTypeId);
        }
    }
}
