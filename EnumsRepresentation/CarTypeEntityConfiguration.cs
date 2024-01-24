using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EnumsRepresentation
{
    internal class CarTypeEntityConfiguration : IEntityTypeConfiguration<CarTypeEntity>
    {
        public void Configure(EntityTypeBuilder<CarTypeEntity> builder)
        {
            builder.HasKey(carTypeEntity => carTypeEntity.Id);

            var seed = Enum.GetValues<CarType>().Select(enumValue => new CarTypeEntity
            {
                Id = enumValue,
                Name = enumValue.ToString(),
                Description = $"описание для типа можно взять из аттрибута {enumValue}"
            });

            builder.HasData(seed);
        }
    }
}
