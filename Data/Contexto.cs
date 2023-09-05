namespace Ejemplo1_Ap1.Data;

using Microsoft.EntityFrameworkCore;
using Ejemplo1_Ap1.Models;

public class Contexto: DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }
    public DbSet<Tickets> Tickets { get; set; }
}
