using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "First Pencil",
                Price = 10,
                Stock = 100,
                CreatedDate = DateTime.Now
            });

            builder.HasData(new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Second Pencil",
                Price = 20,
                Stock = 50,
                CreatedDate = DateTime.Now
            });

            builder.HasData(new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Third Pencil",
                Price = 30,
                Stock = 85,
                CreatedDate = DateTime.Now
            });

            builder.HasData(new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "First Book",
                Price = 15,
                Stock = 40,
                CreatedDate = DateTime.Now
            });

            builder.HasData(new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Second Book",
                Price = 55,
                Stock = 70,
                CreatedDate = DateTime.Now
            });
        }
    }
}
