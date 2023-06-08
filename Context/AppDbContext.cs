using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Models;

namespace ApiCatalogo.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria>? Categorias;
    public DbSet<Produto>? Produtos;

}