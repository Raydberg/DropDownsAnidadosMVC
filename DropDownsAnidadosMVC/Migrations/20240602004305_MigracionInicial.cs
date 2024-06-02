using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DropDownsAnidadosMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sucursal",
                columns: new[] { "Id", "Direccion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Av. España 1458 Cercado Trujillo", "Sucursal Principal" },
                    { 2, "Av. Teodoro Valcarcel 951 Urb. Primavera", "Sucursal Norte" },
                    { 3, "Av. Moche 456 Urb. Santa María", "Sucursal Sur" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nombre", "SucursalId" },
                values: new object[,]
                {
                    { 1, "Aperitivos", 1 },
                    { 2, "Plato Principal", 1 },
                    { 3, "Postres", 2 },
                    { 4, "Bebidas", 2 },
                    { 5, "Especialidades", 3 }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "CategoriaId", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "Aperitivos", 4.9900000000000002 },
                    { 2, 2, "Hamburguesa Vegana", 9.9900000000000002 },
                    { 3, 3, "Torta de Chocolate", 7.9900000000000002 },
                    { 4, 4, "Jugo de Frutas", 2.9900000000000002 },
                    { 5, 5, "Plato Especial", 12.99 },
                    { 6, 2, "Ensalada Mediterranea", 8.9900000000000002 },
                    { 7, 3, "Torta tres leches", 6.9900000000000002 },
                    { 8, 4, "Café Capuchino", 3.9900000000000002 },
                    { 9, 5, "Pizza Americana", 10.99 },
                    { 10, 2, "Caldo de Gallina", 12.99 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_SucursalId",
                table: "Categoria",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
