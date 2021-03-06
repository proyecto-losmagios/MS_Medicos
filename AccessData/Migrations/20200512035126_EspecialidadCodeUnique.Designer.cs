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
    [Migration("20200512035126_EspecialidadCodeUnique")]
    partial class EspecialidadCodeUnique
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
                    b.Property<string>("Codigo")
                        .HasColumnType("character varying(8)")
                        .HasMaxLength(8);

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.HasKey("Codigo");

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

                    b.Property<string>("EspecialidadesCodigo")
                        .IsRequired()
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Nombre")
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.HasKey("MedicoId");

                    b.HasIndex("EspecialidadesCodigo");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Domain.Entities.Medico", b =>
                {
                    b.HasOne("Domain.Entities.Especialidad", "Especialidades")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadesCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
