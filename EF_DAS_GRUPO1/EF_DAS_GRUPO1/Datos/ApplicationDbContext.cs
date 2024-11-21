using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_DAS_GRUPO1.Models;

namespace EF_DAS_GRUPO1.Datos
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
