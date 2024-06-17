using Microsoft.EntityFrameworkCore;
using RegistroArticulos.Api.Models;

namespace Registro_Articulos.Api.DAL;
public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }

    public DbSet<Articulos> Articulos { get; set; }

}
