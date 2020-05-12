using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace AccessData {

    public class APIDbContext : DbContext {

        public APIDbContext(DbContextOptions<APIDbContext> options): base(options) { }

        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }

    }

}
