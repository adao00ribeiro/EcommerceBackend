using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.src.Context;

public class DataContext : DbContext
{


    public DbSet<Category> Categorys { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<CartDetail> CartDetails { get; set; }
    public DbSet<CartHeader> CartHeaders { get; set; }


    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>()
        .AreUnicode(false).HaveMaxLength(500);
        base.ConfigureConventions(configurationBuilder);

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new ProductMap());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
