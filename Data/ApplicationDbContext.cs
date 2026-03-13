using GestãoEventos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestãoEventos.Data;
public class ApplicationDbContext: IdentityDbContext 
{

    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Local> Locais { get; set; }
}
