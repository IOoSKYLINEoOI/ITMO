﻿using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.DataAccess.Configurations;

public class AdressConfiguration : IEntityTypeConfiguration<AddressEntity>
{
    public void Configure(EntityTypeBuilder<AddressEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Country)
            .HasMaxLength(60)
            .IsRequired();

        builder
            .Property(x => x.Region)
            .HasMaxLength(60)
            .IsRequired();

        builder
           .Property(x => x.City)
           .HasMaxLength(60)
           .IsRequired();

        builder
           .Property(x => x.Street)
           .HasMaxLength(60)
           .IsRequired();

        builder
           .Property(x => x.HouseNumber)
           .IsRequired();

        builder
           .Property(x => x.Pavilion)
           .HasMaxLength(60);

        builder
           .Property(x => x.ApartmentNumber)
           .HasMaxLength(60)
           .IsRequired();

        builder
           .Property(x => x.Description)
           .HasMaxLength(250);
    }
}
