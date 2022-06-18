using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(m=>m.FoodId);
            builder.Property(m => m.FoodName).IsRequired().HasMaxLength(100);
            builder.Property(m => m.DateAdded).HasDefaultValueSql("getdate()"); //mssql
                                                                                //builder.Property(m => m.DateAdded).HasDefaultValueSql("date('now')"); //sqlite için

        }
    }
}
