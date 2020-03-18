using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.SelfReference
{
    public class SelfReferenceConfiguration : IEntityTypeConfiguration<SelfReference>
    {
        public void Configure(EntityTypeBuilder<SelfReference> builder)
        {
            builder.ToTable("SelfReferences");
            builder.HasKey(sr => sr.Id);

            builder.HasMany(sr => sr.Children)
                .WithOne(sr => sr.Parent)
                .HasPrincipalKey(sr => sr.Id)
                .HasForeignKey(sr => sr.ParentId);
        }
    }
}