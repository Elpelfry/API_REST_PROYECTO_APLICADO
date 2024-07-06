using Microsoft.EntityFrameworkCore;
using Shared.Models;
namespace API_PROYECTO_APLICADO.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Admisiones> Admisiones { get; set; }
    public DbSet<Asignaturas> Asignaturas { get; set; }
    public DbSet<Carreras> Carreras { get; set; }
    public DbSet<DetalleAsignaturas> DetalleAsignaturas { get; set; }
    public DbSet<DetalleSeleccionAsignatura> DetalleSeleccionAsignatura { get; set; }
    public DbSet<Dias> Dias { get; set; }
    public DbSet<EstadosAdmision> EstadosAdmision { get; set; }
    public DbSet<Facturaciones> Facturaciones { get; set; }
    public DbSet<Reservaciones> Reservaciones { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<SeleccionAsignaturas> SeleccionAsignaturas { get; set; }
    public DbSet<Semestres> Semestres { get; set; }
    public DbSet<TiposReservaciones> TiposReservaciones { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Dias>().HasData(new List<Dias> {
            new Dias { DiaId = 1, NombreDia = "Lunes" },
            new Dias { DiaId = 2, NombreDia = "Martes" },
            new Dias { DiaId = 3, NombreDia = "Miercoles" },
            new Dias { DiaId = 4, NombreDia = "Jueves" },
            new Dias { DiaId = 5, NombreDia = "Viernes" },
            new Dias { DiaId = 6, NombreDia = "Sabado" },
            new Dias { DiaId = 7, NombreDia = "Domingo" }
        });

        modelBuilder.Entity<Roles>().HasData(new List<Roles>
        {
            new Roles { RolId = 1, RolName = "Admin" },
            new Roles { RolId = 2, RolName = "Estudiante" },
            new Roles { RolId = 3, RolName = "Profesor" },
            new Roles { RolId = 4, RolName = "Admisor" }
        });

        modelBuilder.Entity<TiposReservaciones>().HasData(new List<TiposReservaciones>
        {
            new TiposReservaciones { TipoReservacioneId = 1, Descripcion = "Laboratorio" },
            new TiposReservaciones { TipoReservacioneId = 2, Descripcion = "Proyector" }
        });

        modelBuilder.Entity<EstadosAdmision>().HasData(new List<EstadosAdmision>
        {
            new EstadosAdmision { EstadoAdmisionId = 1, Descripcion = "Pendiente" },
            new EstadosAdmision { EstadoAdmisionId = 2, Descripcion = "Aceptado" },
            new EstadosAdmision { EstadoAdmisionId = 3, Descripcion = "Rechazado" }
        });
    }
}