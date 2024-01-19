using Microsoft.EntityFrameworkCore;
using ProductStoreWebApi.Entities;

namespace ProductStoreWebApi.Repositories;

public class CollectionContext:DbContext{
    public DbSet<Product> Products{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string ConnectionString = @"server=localhost; port=3306; user=root; password=Strong@123; database=dotnet";
        optionsBuilder.UseMySQL(ConnectionString);
    }
}