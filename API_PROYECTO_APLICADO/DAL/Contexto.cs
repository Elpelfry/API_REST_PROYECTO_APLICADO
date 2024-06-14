using Microsoft.EntityFrameworkCore;

namespace API_PROYECTO_APLICADO.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
}

