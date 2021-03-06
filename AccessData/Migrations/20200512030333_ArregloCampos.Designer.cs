﻿// <auto-generated />
using AccessData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AccessData.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20200512030333_ArregloCampos")]
    partial class ArregloCampos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Entities.Especialidad", b =>
                {
                    b.Property<int>("EspecialidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("EspecialidadId");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Domain.Entities.Medico", b =>
                {
                    b.Property<int>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre")
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.HasKey("MedicoId");

                    b.HasIndex("EspecialidadId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Domain.Entities.Medico", b =>
                {
                    b.HasOne("Domain.Entities.Especialidad", "Especialidades")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
