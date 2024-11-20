

namespace Proyecto_Wasi_Final.Datos
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Carrito> Carrito { get; set; }

        public DbSet<CarritoProducto> CarritoProducto { get; set; }

        public DbSet<HistorialTokens> HistorialTokens { get; set; }

        public DbSet<DetallePedido> DetallePedido { get; set; }

        public DbSet<Pedidos> Pedidos { get; set; }

        public DbSet<MetodoPago> MetodoPago { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

    }
}
