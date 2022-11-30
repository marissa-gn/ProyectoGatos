using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiCerveceria.Migrations
{
    /// <inheritdoc />
    public partial class Cerveceria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Provedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    ProvedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Provedores_ProvedorId",
                        column: x => x.ProvedorId,
                        principalTable: "Provedores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Productos_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroVenta = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    IdVendedor = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "MarcaId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Corona" },
                    { 2, "Pacífico" },
                    { 3, "Cuahutemoc" },
                    { 4, "Psicosis Imperial IPA" },
                    { 5, "Heineken" },
                    { 6, "Sol" },
                    { 7, "Modelo" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Lager" },
                    { 2, "Especial" },
                    { 3, "Clara" },
                    { 4, "Negras" },
                    { 5, "Alemana" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Cantidad", "Descripcion", "Imagen", "MarcaId", "Nombre", "Precio", "ProvedorId", "TipoId" },
                values: new object[,]
                {
                    { 1, 18, "Desde 1899 y una tradición detrás, Cerveza Sol es la primer cerveza con botella transparente en México.", "Sol.jpg", 6, "Sol", 25m, null, 3 },
                    { 2, 23, "Nacida para ser leyenda. Tecate cerveza sabe a lo que debe saber una cerveza. Tecate cerveza Ideal para seguir estando juntos aunque sea a la distancia. Tecate Titanium. Tecate Ambar. Tecate Ligth. Tecate Original.", "Tecate.jpg", 3, "Tecate", 30m, null, 1 },
                    { 3, 78, "Cerveza Indio es el nombre de una cerveza mexicana de la Cervecería Cuauhtémoc Moctezuma creada en Nuevo León, México en 1893.", "Indio.jpg", 3, "Indio", 24m, null, 4 },
                    { 4, 12, "Es una cerveza tipo Pilsner de 4.5º de alcohol que actualmente se vende en más de 180 países en los cinco continentes.", "Corona.jpg", 1, "Corona", 25m, null, 3 },
                    { 5, 88, "Carta Blanca es una cerveza mexicana tipo lager con más de un siglo de tradición cervecera. Con un perfil de sabor equilibrado y refrescante gracias a su proceso de elaboración e ingredientes de primera calidad que la han hecho merecedora de 20 galardones internacionales.", "CartaBlanca.jpg", 3, "Carta Blanca", 31m, null, 4 },
                    { 6, 90, "Modelo especial, una cerveza pilsner americana, fue la primera cerveza creada y producida por Grupo Modelo en 1925. Relanzada utilizando la misma receta en 2010, Especial tiene un color dorado brillante, y un sabor dulce y bien equilibrado con lúpulos ligeros y un final fresco.", "Modelo.jpg", 7, "Modelo", 34m, null, 3 },
                    { 7, 54, "Victoria es una deliciosa cerveza tipo Viena que ofrece un sabor único y chingón al estilo mexicano", "Victoria.jpg", 7, "Victoria", 25m, null, 4 },
                    { 8, 34, "La cerveza Dos Equis lager especial, nació en 1984 de la derivación de la Dos Equis ámbar. Esta marca fue creada en el estado de Veracruz para conmemorar la llegada del siglo veinte. Es una cerveza clara que dejará un toque suave y refrescante en tu paladar", "XX.jpg", 5, "XX", 40m, null, 3 },
                    { 9, 12, "Bohemia Vienna es una cerveza hecha con maltas caramelo, dulce y chocolate, destacan los aromas ahumados, a nuez y a café. Cerveza con un buen cuerpo, sabores a dulce y granos tostados. Es un estilo de cerveza Vienna – Fue creada en 1841 en Viena, Austria.", "Bohemia.jpg", 3, "Bohemia", 25m, null, 4 },
                    { 10, 15, "Cerveza Pacífico es la cerveza mexicana tradicional y líder en el noroeste de nuestro país de Grupo Modelo. Creada a principios del siglo XX en la región de Mazatlán, Sinaloa, es de tipo lager y estilo Pilsner, clara, color dorado pálido, muy suave, refrescante y un final muy fresco.", "Pacifico.jpg", 2, "Pacifico", 32m, null, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProvedorId",
                table: "Productos",
                column: "ProvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoId",
                table: "Productos",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductoId",
                table: "Ventas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_VendedorId",
                table: "Ventas",
                column: "VendedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Provedores");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}
