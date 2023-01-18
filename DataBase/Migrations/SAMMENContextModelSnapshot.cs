﻿// <auto-generated />
using System;
using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataBase.Migrations
{
    [DbContext(typeof(SAMMENContext))]
    partial class SAMMENContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataBase.Models.Operativo.Cursos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngenieroHerramientas")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Referencia")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vigencia")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.Herramienta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Acuse")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dias")
                        .HasColumnType("int");

                    b.Property<int>("DiasCampo")
                        .HasColumnType("int");

                    b.Property<int>("DiasSinMtto")
                        .HasColumnType("int");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMedidaHerramienta")
                        .HasColumnType("int");

                    b.Property<int>("IdUbicacion")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num")
                        .HasColumnType("int");

                    b.Property<string>("NumeroInforme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimoMtto")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdMedidaHerramienta");

                    b.HasIndex("IdUbicacion");

                    b.ToTable("Herramientas");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.HistorialHerramienta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Acido")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("Agua")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("Diesel")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("Divergente")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Estructura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GelLineal")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("HorasEfectivas")
                        .HasColumnType("int");

                    b.Property<int>("HorasOperativas")
                        .HasColumnType("int");

                    b.Property<int>("IdOperador")
                        .HasColumnType("int");

                    b.Property<decimal>("Inhibidor")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxCircPressure")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("MaxWHP")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Nitrogeno")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OD")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Pozo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfundidadMax")
                        .HasColumnType("int");

                    b.Property<decimal>("Solvente")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("TemperaturaMaxima")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("TipoOperacion")
                        .HasColumnType("int");

                    b.Property<int>("Unidad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdOperador");

                    b.ToTable("HistorialHerramientas");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.MedidaHerramienta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BalinDesconector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BalinPaso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BalinSub")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiametroExterno")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<decimal>("Longitud")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PresionMaxima")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("RoscaCaja")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("RoscaPin")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("TensionMaxima")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MedidaHerramientas");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.MedidaHerramientaEspecial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Acuse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BalinPaso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiametroExterno")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("Dias")
                        .HasColumnType("int");

                    b.Property<int>("DiasEnCampo")
                        .HasColumnType("int");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUbicacion")
                        .HasColumnType("int");

                    b.Property<decimal>("Longitud")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("NumeroInforme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RoscaCaja")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("RoscaGIR")
                        .HasColumnType("decimal(10,4)");

                    b.Property<decimal>("TensionMaxima")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUbicacion");

                    b.ToTable("MedidaHerramientaEspecials");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.Operador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CVSAMMEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursosAbordaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursosOExperiencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursosSSPA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursosTecnicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("ExamenesMedicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NSS")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCelular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VigenciaCursosAbordaje")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VigenciaCursosSSPA")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VigenciaCursosTecnicos")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Operadores");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CantidadUTF")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCelular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.Herramienta", b =>
                {
                    b.HasOne("DataBase.Models.Operativo.MedidaHerramienta", "MedidaHerramienta")
                        .WithMany()
                        .HasForeignKey("IdMedidaHerramienta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.Models.Operativo.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("IdUbicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedidaHerramienta");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.HistorialHerramienta", b =>
                {
                    b.HasOne("DataBase.Models.Operativo.Operador", "Operador")
                        .WithMany()
                        .HasForeignKey("IdOperador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operador");
                });

            modelBuilder.Entity("DataBase.Models.Operativo.MedidaHerramientaEspecial", b =>
                {
                    b.HasOne("DataBase.Models.Operativo.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("IdUbicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");
                });
#pragma warning restore 612, 618
        }
    }
}
