using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.SharedTable
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>,
        IEntityTypeConfiguration<PhotoFullImage>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("Photos");
            builder.HasKey(p => p.Id);

            builder.HasOne(b => b.FullImage)
                .WithOne(fi => fi.Photo)
                .HasForeignKey<PhotoFullImage>(pi => pi.Id);
        }

        public void Configure(EntityTypeBuilder<PhotoFullImage> builder)
        {
            builder.ToTable("Photos");
            builder.HasKey(p => p.Id);
        }
    }
}