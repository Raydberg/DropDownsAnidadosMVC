﻿// <auto-generated />
using DropDownsAnidadosMVC.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DropDownsAnidadosMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Aperitivos",
                            SucursalId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Plato Principal",
                            SucursalId = 1
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Postres",
                            SucursalId = 2
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Bebidas",
                            SucursalId = 2
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Especialidades",
                            SucursalId = 3
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Nombre = "Aperitivos",
                            Precio = 4.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Nombre = "Hamburguesa Vegana",
                            Precio = 9.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 3,
                            Nombre = "Torta de Chocolate",
                            Precio = 7.9900000000000002
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 4,
                            Nombre = "Jugo de Frutas",
                            Precio = 2.9900000000000002
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 5,
                            Nombre = "Plato Especial",
                            Precio = 12.99
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Nombre = "Ensalada Mediterranea",
                            Precio = 8.9900000000000002
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 3,
                            Nombre = "Torta tres leches",
                            Precio = 6.9900000000000002
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 4,
                            Nombre = "Café Capuchino",
                            Precio = 3.9900000000000002
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 5,
                            Nombre = "Pizza Americana",
                            Precio = 10.99
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 2,
                            Nombre = "Caldo de Gallina",
                            Precio = 12.99
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sucursal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "Av. España 1458 Cercado Trujillo",
                            Nombre = "Sucursal Principal"
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "Av. Teodoro Valcarcel 951 Urb. Primavera",
                            Nombre = "Sucursal Norte"
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "Av. Moche 456 Urb. Santa María",
                            Nombre = "Sucursal Sur"
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.HasOne("DropDownsAnidadosMVC.Models.Sucursal", "Sucursal")
                        .WithMany("Categorias")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Producto", b =>
                {
                    b.HasOne("DropDownsAnidadosMVC.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Sucursal", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
