﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210923205731_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Desempeno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GolesAFavor")
                        .HasColumnType("int");

                    b.Property<int>("GolesEnContra")
                        .HasColumnType("int");

                    b.Property<int>("PartidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosJugados")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Desempeños");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DesempenoID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DesempenoID");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.HasIndex("PartidoId");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Novedad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("MinutoNovedad")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PartidosId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeNovedad")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PartidosId");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EquipoLocal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipoVisitante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcadorInicialLocal")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorInicialVisitante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Persona");

                    b.Property<string>("Colegio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.HasIndex("PartidoId");

                    b.HasDiscriminator().HasValue("Arbitro");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.DT", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Persona");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int")
                        .HasColumnName("DT_EquipoId");

                    b.HasIndex("EquipoId");

                    b.HasDiscriminator().HasValue("DT");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Persona");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("NovedadID")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Posicion")
                        .HasColumnType("int");

                    b.HasIndex("EquipoId");

                    b.HasIndex("NovedadID");

                    b.HasDiscriminator().HasValue("Jugador");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Desempeno", "Desempeno")
                        .WithMany()
                        .HasForeignKey("DesempenoID");

                    b.Navigation("Desempeno");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Partido", null)
                        .WithMany("Estadio")
                        .HasForeignKey("PartidoId");

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Municipio", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", null)
                        .WithMany("Municipio")
                        .HasForeignKey("EquipoId");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Novedad", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidosId");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Partido", null)
                        .WithMany("Arbitro")
                        .HasForeignKey("PartidoId");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.DT", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", null)
                        .WithMany("Director")
                        .HasForeignKey("EquipoId");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", null)
                        .WithMany("Jugadores")
                        .HasForeignKey("EquipoId");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Novedad", null)
                        .WithMany("Jugadores")
                        .HasForeignKey("NovedadID");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.Navigation("Director");

                    b.Navigation("Jugadores");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Novedad", b =>
                {
                    b.Navigation("Jugadores");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.Navigation("Arbitro");

                    b.Navigation("Estadio");
                });
#pragma warning restore 612, 618
        }
    }
}
