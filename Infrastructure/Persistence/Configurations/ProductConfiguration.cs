using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Cartitems)
                .WithOne(x => x.Products)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x=>x.Cartitems)
                .WithOne(x => x.Products)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
