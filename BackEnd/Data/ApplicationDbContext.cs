using BackEnd.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

      public DbSet<Contenido> Contenidos { get; set; }
      public DbSet<Categoria> Categorias { get; set; }
      public DbSet<Usuario> Usuarios { get; set; }
      public DbSet<Listado> Listados { get; set; }
    
    
        
        
    
    
    
    
}
