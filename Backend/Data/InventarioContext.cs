using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Backend.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext()
        {

        }

        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Localidad> Localidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();

//string cadenaConexion = configuration.GetConnectionString("mysqlRemote");
var cadenaConexion = configuration.GetConnectionString("postgresRemote");
            optionsBuilder.UseNpgsql(cadenaConexion);
        }
        // creamos el metodo OnModelCreating para insertar datos semilla en la tabla clientes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { id = 1, Firstname = "Enzo", Lastname = "Cabrera", Dni = "67676767676767", Address = "Calle AURA", LocalidadId = 1 },
                new Cliente { id = 2, Firstname = "María", Lastname = "González", Dni = "87654321", Address = "Avenida Siempre Viva 456", LocalidadId = 2 },
                new Cliente { id = 3, Firstname = "Pedro", Lastname = "López", Dni = "11223344", Address = "Callejón del Beso 789", LocalidadId = 3 }
            );

            // creamos datos semilla para la tabla Localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1, Name = "Buenos Aires" },
                new Localidad { Id = 2, Name = "San Justo" },
                new Localidad { Id = 3, Name = "Santa Fe" }
            );

            //configuramos la propied Created_at para que tenga un valor por defecto de la fecha y hora actual
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Created_at)
                .HasDefaultValueSql("NOW()");
            //configuramos los queries filters para que no traigan los registros eliminados
            modelBuilder.Entity<Cliente>()
                .HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Localidad>()
                .HasQueryFilter(l => !l.IsDeleted);
        }

    }
}
