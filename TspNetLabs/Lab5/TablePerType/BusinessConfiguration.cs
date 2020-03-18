using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.InheritanceSharedTable
{
    public class BusinessConfiguration : IEntityTypeConfiguration<Business>,
        IEntityTypeConfiguration<Retail>,
        IEntityTypeConfiguration<Ecommerce>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.ToTable("Businesses");
            builder.HasKey(b => b.Id);
        }

        public void Configure(EntityTypeBuilder<Retail> builder)
        {
            builder.ToTable("Businesses");
            builder.HasOne(r => r.Business)
                .WithOne()
                .HasForeignKey<Retail>(r => r.Id);
        }

        public void Configure(EntityTypeBuilder<Ecommerce> builder)
        {
            builder.ToTable("Businesses");

            builder.HasOne(r => r.Business)
                .WithOne()
                .HasForeignKey<Ecommerce>(r => r.Id);
        }
    }
}