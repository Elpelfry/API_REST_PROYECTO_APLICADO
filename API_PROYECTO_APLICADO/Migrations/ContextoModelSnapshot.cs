﻿// <auto-generated />
using System;
using API_PROYECTO_APLICADO.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_PROYECTO_APLICADO.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.Admisiones", b =>
                {
                    b.Property<int>("AdmisioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AdmisioneId"));

                    b.Property<byte[]>("ActaNacimiento")
                        .HasColumnType("longblob");

                    b.Property<string>("ActaNacimientoExtension")
                        .HasColumnType("longtext");

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("CertificadoBachiller")
                        .HasColumnType("longblob");

                    b.Property<string>("CertificadoBachillerExtension")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("CertificadoMedico")
                        .HasColumnType("longblob");

                    b.Property<string>("CertificadoMedicoExtension")
                        .HasColumnType("longtext");

                    b.Property<string>("CiudadNacimiento")
                        .HasColumnType("longtext");

                    b.Property<string>("Contrasena")
                        .HasColumnType("longtext");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext");

                    b.Property<int>("EstadoAdmicionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FotoExtension")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Fotografia")
                        .HasColumnType("longblob");

                    b.Property<string>("LugarNacimiento")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombres")
                        .HasColumnType("longtext");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("RecordNotas")
                        .HasColumnType("longblob");

                    b.Property<string>("RecordNotasExtension")
                        .HasColumnType("longtext");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Tarjetavacunacion")
                        .HasColumnType("longblob");

                    b.Property<string>("TarjetavacunacionExtension")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonoCasa")
                        .HasColumnType("longtext");

                    b.HasKey("AdmisioneId");

                    b.ToTable("Admisiones");
                });

            modelBuilder.Entity("Shared.Models.Asignaturas", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AsignaturaId"));

                    b.Property<int>("CantidadEstudiantes")
                        .HasColumnType("int");

                    b.Property<string>("CodigoMateria")
                        .HasColumnType("longtext");

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<bool>("EsLaboratorio")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NombreMateria")
                        .HasColumnType("longtext");

                    b.Property<double>("PrecioCredito")
                        .HasColumnType("double");

                    b.Property<string>("Seccion")
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("AsignaturaId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("Shared.Models.Carreras", b =>
                {
                    b.Property<int>("CarreraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CarreraId"));

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("CarreraId");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("Shared.Models.Configuraciones", b =>
                {
                    b.Property<int>("ConfiguracionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ConfiguracionId"));

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext");

                    b.Property<string>("DominioEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoAdmision")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoInscripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoPublicacion")
                        .HasColumnType("longtext");

                    b.Property<string>("EstadoRetiro")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("LogoEmpresa")
                        .HasColumnType("longblob");

                    b.Property<string>("LogoExtension")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("PeriodoCalendario")
                        .HasColumnType("longtext");

                    b.Property<float>("PorcentajeRegcargo")
                        .HasColumnType("float");

                    b.Property<float>("PrecioAdmision")
                        .HasColumnType("float");

                    b.Property<float>("PrecioCredito")
                        .HasColumnType("float");

                    b.Property<float>("PrecioInscripcion")
                        .HasColumnType("float");

                    b.Property<string>("Rnc")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.Property<string>("URLCalendario")
                        .HasColumnType("longtext");

                    b.Property<string>("VozLectora")
                        .HasColumnType("longtext");

                    b.HasKey("ConfiguracionId");

                    b.ToTable("Configuraciones");

                    b.HasData(
                        new
                        {
                            ConfiguracionId = 1,
                            CorreoElectronico = "info@defaultcompany.com",
                            Direccion = "Default Address",
                            DominioEmpresa = "defaultcompany.com",
                            EstadoAdmision = "Open",
                            EstadoInscripcion = "Open",
                            EstadoPublicacion = "Published",
                            EstadoRetiro = "Active",
                            NombreEmpresa = "Default Company",
                            PeriodoCalendario = "2024-2025",
                            PorcentajeRegcargo = 10f,
                            PrecioAdmision = 500f,
                            PrecioCredito = 1000f,
                            PrecioInscripcion = 200f,
                            Rnc = "123456789",
                            Telefono = "123-456-7890",
                            URLCalendario = "http://defaultcompany.com/calendar",
                            VozLectora = "Default Voice"
                        });
                });

            modelBuilder.Entity("Shared.Models.DetalleAsignaturas", b =>
                {
                    b.Property<int>("DetalleAsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleAsignaturaId"));

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<string>("Aula")
                        .HasColumnType("longtext");

                    b.Property<string>("Comentario")
                        .HasColumnType("longtext");

                    b.Property<int>("DiaId")
                        .HasColumnType("int");

                    b.Property<string>("Edificio")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("HoraFin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DetalleAsignaturaId");

                    b.HasIndex("AsignaturaId");

                    b.ToTable("DetalleAsignaturas");
                });

            modelBuilder.Entity("Shared.Models.DetalleDetalleSemestrePlan", b =>
                {
                    b.Property<int>("DetalleDetalleSemestrePlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleDetalleSemestrePlanId"));

                    b.Property<string>("Aula")
                        .HasColumnType("longtext");

                    b.Property<int>("DetalleSemestrePlanId")
                        .HasColumnType("int");

                    b.Property<int>("DiaId")
                        .HasColumnType("int");

                    b.Property<string>("Grupo")
                        .HasColumnType("longtext");

                    b.Property<string>("HoraFin")
                        .HasColumnType("longtext");

                    b.Property<string>("HoraInicio")
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DetalleDetalleSemestrePlanId");

                    b.HasIndex("DetalleSemestrePlanId");

                    b.ToTable("DetalleDetalleSemestrePlan");
                });

            modelBuilder.Entity("Shared.Models.DetalleInventarioReserva", b =>
                {
                    b.Property<int>("DetalleInventarioReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleInventarioReservaId"));

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaRetorno")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InventarioReservaId")
                        .HasColumnType("int");

                    b.HasKey("DetalleInventarioReservaId");

                    b.HasIndex("InventarioReservaId");

                    b.ToTable("DetalleInventarioReservas");
                });

            modelBuilder.Entity("Shared.Models.DetalleSeleccionAsignatura", b =>
                {
                    b.Property<int>("DetalleSeleccionAsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleSeleccionAsignaturaId"));

                    b.Property<float>("Calificacion")
                        .HasColumnType("float");

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<int>("DetalleDetalleSemestrePlanId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<int>("SeleccionAsignaturaId")
                        .HasColumnType("int");

                    b.HasKey("DetalleSeleccionAsignaturaId");

                    b.HasIndex("SeleccionAsignaturaId");

                    b.ToTable("DetalleSeleccionAsignatura");
                });

            modelBuilder.Entity("Shared.Models.DetalleSemestrePlan", b =>
                {
                    b.Property<int>("DetalleSemestrePlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleSemestrePlanId"));

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<string>("Materia")
                        .HasColumnType("longtext");

                    b.Property<int>("SemestrePlanId")
                        .HasColumnType("int");

                    b.HasKey("DetalleSemestrePlanId");

                    b.HasIndex("SemestrePlanId");

                    b.ToTable("DetalleSemestrePlan");
                });

            modelBuilder.Entity("Shared.Models.Dias", b =>
                {
                    b.Property<int>("DiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DiaId"));

                    b.Property<string>("NombreDia")
                        .HasColumnType("longtext");

                    b.HasKey("DiaId");

                    b.ToTable("Dias");

                    b.HasData(
                        new
                        {
                            DiaId = 1,
                            NombreDia = "Lunes"
                        },
                        new
                        {
                            DiaId = 2,
                            NombreDia = "Martes"
                        },
                        new
                        {
                            DiaId = 3,
                            NombreDia = "Miercoles"
                        },
                        new
                        {
                            DiaId = 4,
                            NombreDia = "Jueves"
                        },
                        new
                        {
                            DiaId = 5,
                            NombreDia = "Viernes"
                        },
                        new
                        {
                            DiaId = 6,
                            NombreDia = "Sabado"
                        },
                        new
                        {
                            DiaId = 7,
                            NombreDia = "Domingo"
                        });
                });

            modelBuilder.Entity("Shared.Models.EstadosAdmision", b =>
                {
                    b.Property<int>("EstadoAdmisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EstadoAdmisionId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("EstadoAdmisionId");

                    b.ToTable("EstadosAdmision");

                    b.HasData(
                        new
                        {
                            EstadoAdmisionId = 1,
                            Descripcion = "Pendiente"
                        },
                        new
                        {
                            EstadoAdmisionId = 2,
                            Descripcion = "Aceptado"
                        },
                        new
                        {
                            EstadoAdmisionId = 3,
                            Descripcion = "Rechazado"
                        });
                });

            modelBuilder.Entity("Shared.Models.Facturaciones", b =>
                {
                    b.Property<int>("FacturacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("FacturacionId"));

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("FechaEmision")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("Monto")
                        .HasColumnType("double");

                    b.Property<string>("Nota")
                        .HasColumnType("longtext");

                    b.Property<int>("SemestreId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("FacturacionId");

                    b.ToTable("Facturaciones");
                });

            modelBuilder.Entity("Shared.Models.InventarioReservas", b =>
                {
                    b.Property<int>("InventarioReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("InventarioReservaId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ExtensionFoto")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("FotoReserva")
                        .HasColumnType("longblob");

                    b.HasKey("InventarioReservaId");

                    b.ToTable("InventarioReservas");
                });

            modelBuilder.Entity("Shared.Models.Reservaciones", b =>
                {
                    b.Property<int>("ReservacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ReservacionId"));

                    b.Property<string>("CodigoReservacion")
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaRetorno")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InventarioReservaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ReservacionId");

                    b.ToTable("Reservaciones");
                });

            modelBuilder.Entity("Shared.Models.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RolId"));

                    b.Property<string>("RolName")
                        .HasColumnType("longtext");

                    b.HasKey("RolId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RolId = 1,
                            RolName = "Administrador"
                        },
                        new
                        {
                            RolId = 2,
                            RolName = "Estudiante"
                        },
                        new
                        {
                            RolId = 3,
                            RolName = "Profesor"
                        },
                        new
                        {
                            RolId = 4,
                            RolName = "Admisor"
                        });
                });

            modelBuilder.Entity("Shared.Models.SeleccionAsignaturas", b =>
                {
                    b.Property<int>("SeleccionAsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SeleccionAsignaturaId"));

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaSeleccion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SemestreId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("SeleccionAsignaturaId");

                    b.ToTable("SeleccionAsignaturas");
                });

            modelBuilder.Entity("Shared.Models.SemestrePlan", b =>
                {
                    b.Property<int>("SemestrePlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SemestrePlanId"));

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("SemestrePlanId");

                    b.ToTable("SemestrePlan");
                });

            modelBuilder.Entity("Shared.Models.Semestres", b =>
                {
                    b.Property<int>("SemestreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SemestreId"));

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaFinSeleccion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaInicioSeleccion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("SemestreId");

                    b.ToTable("Semestres");
                });

            modelBuilder.Entity("Shared.Models.TiposReservaciones", b =>
                {
                    b.Property<int>("TipoReservacioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TipoReservacioneId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("TipoReservacioneId");

                    b.ToTable("TiposReservaciones");

                    b.HasData(
                        new
                        {
                            TipoReservacioneId = 1,
                            Descripcion = "Laboratorio"
                        },
                        new
                        {
                            TipoReservacioneId = 2,
                            Descripcion = "Proyector"
                        });
                });

            modelBuilder.Entity("Shared.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<int>("AdmisionId")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("longtext");

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasColumnType("longtext");

                    b.Property<string>("Contrasena")
                        .HasColumnType("longtext");

                    b.Property<string>("CorreoElectronicoInstitucional")
                        .HasColumnType("longtext");

                    b.Property<string>("CorreoElectronicoPersonal")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("FechaEgreso")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FotoExtension")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("FotoUsuario")
                        .HasColumnType("longblob");

                    b.Property<string>("Matricula")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombres")
                        .HasColumnType("longtext");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefonoCasa")
                        .HasColumnType("longtext");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Shared.Models.DetalleAsignaturas", b =>
                {
                    b.HasOne("Shared.Models.Asignaturas", null)
                        .WithMany("DetalleAsignaturas")
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.DetalleDetalleSemestrePlan", b =>
                {
                    b.HasOne("Shared.Models.DetalleSemestrePlan", null)
                        .WithMany("DetalleDetalleSemestrePlan")
                        .HasForeignKey("DetalleSemestrePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.DetalleInventarioReserva", b =>
                {
                    b.HasOne("Shared.Models.InventarioReservas", null)
                        .WithMany("InventarioReservacionesDetalle")
                        .HasForeignKey("InventarioReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.DetalleSeleccionAsignatura", b =>
                {
                    b.HasOne("Shared.Models.SeleccionAsignaturas", null)
                        .WithMany("DetalleSeleccionAsignaturas")
                        .HasForeignKey("SeleccionAsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.DetalleSemestrePlan", b =>
                {
                    b.HasOne("Shared.Models.SemestrePlan", null)
                        .WithMany("DetalleSemestrePlan")
                        .HasForeignKey("SemestrePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Asignaturas", b =>
                {
                    b.Navigation("DetalleAsignaturas");
                });

            modelBuilder.Entity("Shared.Models.DetalleSemestrePlan", b =>
                {
                    b.Navigation("DetalleDetalleSemestrePlan");
                });

            modelBuilder.Entity("Shared.Models.InventarioReservas", b =>
                {
                    b.Navigation("InventarioReservacionesDetalle");
                });

            modelBuilder.Entity("Shared.Models.SeleccionAsignaturas", b =>
                {
                    b.Navigation("DetalleSeleccionAsignaturas");
                });

            modelBuilder.Entity("Shared.Models.SemestrePlan", b =>
                {
                    b.Navigation("DetalleSemestrePlan");
                });
#pragma warning restore 612, 618
        }
    }
}
