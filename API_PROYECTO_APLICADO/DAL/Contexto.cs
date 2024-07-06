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
    public DbSet<Configuraciones> Configuraciones { get; set; }

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
            new Roles { RolId = 1, RolName = "Administrador" },
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

        modelBuilder.Entity<Configuraciones>().HasData(new Configuraciones
        {
            ConfiguracionId = 1,
            NombreEmpresa = "Default Company",
            Rnc = "123456789",
            Direccion = "Default Address",
            Telefono = "123-456-7890",
            PrecioCredito = 1000.0f,
            PrecioAdmision = 500.0f,
            PrecioInscripcion = 200.0f,
            PorcentajeRegcargo = 10.0f,
            EstadoRetiro = "Active",
            EstadoInscripcion = "Open",
            EstadoAdmision = "Open",
            EstadoPublicacion = "Published",
            VozLectora = "Default Voice",
            DominioEmpresa = "defaultcompany.com",
            URLCalendario = "http://defaultcompany.com/calendar",
            PeriodoCalendario = "2024-2025",
            CorreoElectronico = "info@defaultcompany.com",
            LogoEmpresa = null,
            LogoExtension = null
        });
    }
}