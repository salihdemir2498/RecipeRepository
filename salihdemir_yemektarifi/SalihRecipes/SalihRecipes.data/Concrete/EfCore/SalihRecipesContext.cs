using Microsoft.EntityFrameworkCore;
using SalihRecipes.data.Configurations;
using SalihRecipes.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihRecipes.data.Concrete.EfCore
{
    public class SalihRecipesContext : DbContext
    {
        public SalihRecipesContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorFoods> AuthorFoods { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=FoodRecipe");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FoodCategoryConfiguration());

            modelBuilder.Seed();
           
            modelBuilder.Entity<AuthorFoods>()
                .HasKey(c => new { c.AuthorId, c.FoodId });
        }
    }
}
