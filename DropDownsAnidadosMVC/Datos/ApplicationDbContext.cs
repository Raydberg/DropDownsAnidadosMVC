using DropDownsAnidadosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DropDownsAnidadosMVC.Datos
{
    public class ApplicationDbContext:DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }

        //  Creacion de tablas en la base de datos
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sucursal>().HasData(
            new Sucursal { Id = 1, Nombre = "Sucursal Principal", Direccion = "Av. España 1458 Cercado Trujillo" },
            new Sucursal { Id = 2, Nombre = "Sucursal Norte", Direccion = "Av. Teodoro Valcarcel 951 Urb. Primavera" },
            new Sucursal { Id = 3, Nombre = "Sucursal Sur", Direccion = "Av. Moche 456 Urb. Santa María" }
            );
            modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id = 1, Nombre = "Aperitivos", SucursalId = 1 },
            new Categoria { Id = 2, Nombre = "Plato Principal", SucursalId = 1 },
            new Categoria { Id = 3, Nombre = "Postres", SucursalId = 2 },
            new Categoria { Id = 4, Nombre = "Bebidas", SucursalId = 2 },
            new Categoria { Id = 5, Nombre = "Especialidades", SucursalId = 3 }
            );
            modelBuilder.Entity<Producto>().HasData(
            new Producto { Id = 1, Nombre = "Aperitivos", Precio = 4.99, CategoriaId = 1 },
            new Producto { Id = 2, Nombre = "Hamburguesa Vegana", Precio = 9.99, CategoriaId = 2 },
            new Producto { Id = 3, Nombre = "Torta de Chocolate", Precio = 7.99, CategoriaId = 3 },
            new Producto { Id = 4, Nombre = "Jugo de Frutas", Precio = 2.99, CategoriaId = 4 },
            new Producto { Id = 5, Nombre = "Plato Especial", Precio = 12.99, CategoriaId = 5 },
            new Producto { Id = 6, Nombre = "Ensalada Mediterranea", Precio = 8.99, CategoriaId = 2 },
            new Producto { Id = 7, Nombre = "Torta tres leches", Precio = 6.99, CategoriaId = 3 },
            new Producto { Id = 8, Nombre = "Café Capuchino", Precio = 3.99, CategoriaId = 4 },
            new Producto { Id = 9, Nombre = "Pizza Americana", Precio = 10.99, CategoriaId = 5 },
            new Producto { Id = 10, Nombre = "Caldo de Gallina", Precio = 12.99, CategoriaId = 2 }
            );
        }
    }
}
