using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataAccess.Configurations;

public class ImageConfiguration : IEntityTypeConfiguration<ImageEntity>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ImageEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder
           .Property(x => x.FileName)
           .HasMaxLength(250)
           .IsRequired();
    }
}
