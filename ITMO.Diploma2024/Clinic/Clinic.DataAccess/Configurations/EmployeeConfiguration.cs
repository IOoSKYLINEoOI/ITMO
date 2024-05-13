using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.DataAccess.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
{
    public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.HiringDate)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .HasMaxLength(250);

        builder
            .HasOne(e => e.User)
            .WithOne(e => e.Employee)
            .HasForeignKey<EmployeeEntity>(e => e.UserId)
            .IsRequired();

        builder.HasMany(r => r.Department)
            .WithMany(p => p.Employee)
            .UsingEntity<EmployeeDepartmentEntity>(
                r => r.HasOne<DepartmentEntity>().WithMany().HasForeignKey(e => e.DepartmentId),
                l => l.HasOne<EmployeeEntity>().WithMany().HasForeignKey(e => e.EmployeeId).OnDelete(DeleteBehavior.NoAction));
    }
}
