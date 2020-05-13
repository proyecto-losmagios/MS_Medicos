using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace AccessData {

    public class APIDbContext : DbContext {

        public APIDbContext(DbContextOptions<APIDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Especialidad>().HasIndex(e => new {e.Codigo}).IsUnique();
        }

        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }

    }

}
