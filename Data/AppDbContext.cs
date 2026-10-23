using System;

namespace Company.ClassLibrary1;

public class AppDbContextm: AppDbContext
{
    public DbSet <Producto> Producto { get; set; }
    protected override void OnConfiguring(AppDbContextOptionsBuilder optionsBuilder)
    {
        var connecitionString = "Server=localhost;Database=TiendaPedro;User=root;Password=tupass;";
        optionsBuilder.UseMySql(connecitionString, ServerVersion.AutoDetect(connectionString));
    }
}
