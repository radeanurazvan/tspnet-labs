using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.TablePerInheritance
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>,
        IEntityTypeConfiguration<HourlyEmployee>,
        IEntityTypeConfiguration<FullTimeEmployee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
        }

        public void Configure(EntityTypeBuilder<HourlyEmployee> builder)
        {
            builder.HasBaseType<Employee>();
        }

        public void Configure(EntityTypeBuilder<FullTimeEmployee> builder)
        {
            builder.HasBaseType<Employee>();
        }
    }
}