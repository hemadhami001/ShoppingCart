using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.CartItems)
                .WithOne(x => x.Products)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x=>x.CartItems)
                .WithOne(x => x.Products)
                .HasForeignKey(x => x.ProductId);

           builder.HasOne(x => x.Category)
               .WithMany(x=>x.Products)
               .OnDelete(DeleteBehavior.Restrict) 
               .HasForeignKey(x=>x.CategoryId);
               

            //builder.Property(x=>x.CategoryId).IsRequired(false);
        }
    }
}
