using ApiCerveceria.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Data
{
    public class CerveceriaContext:DbContext
    {
        public CerveceriaContext(DbContextOptions<CerveceriaContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Provedor> Provedores { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Vendedor> Vendedores{ get; set; }
        public DbSet<Ventas> Ventas{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.Entity<Marca>().HasData(
                new Marca{ MarcaId = 1, Nombre="Corona"}, 
                new Marca { MarcaId = 2, Nombre = "Pacífico" },
                new Marca { MarcaId = 3, Nombre = "Cuahutemoc" },
                new Marca { MarcaId = 4, Nombre = "Psicosis Imperial IPA" },
                new Marca { MarcaId = 5, Nombre = "Heineken" },
                new Marca { MarcaId = 6, Nombre = "Sol" },
                new Marca { MarcaId = 7, Nombre = "Modelo" }
                );
            modelBuilder.Entity<Tipo>().HasData(
                new Tipo { TipoId = 1, Nombre = "Lager" },
                new Tipo { TipoId = 2, Nombre = "Especial" },
                new Tipo { TipoId = 3, Nombre = "Clara" },
                new Tipo { TipoId = 4, Nombre = "Negras" },
                new Tipo { TipoId = 5, Nombre = "Alemana" }
                );
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Cantidad=18, Nombre="Sol", Imagen= "Sol.jpg", MarcaId=6, TipoId = 3,Precio=25,Descripcion= "Desde 1899 y una tradición detrás, Cerveza Sol es la primer cerveza con botella transparente en México." },
                new Producto { Id = 2, Cantidad = 23, Nombre = "Tecate", Imagen = "Tecate.jpg", MarcaId = 3, TipoId = 1, Precio = 30, Descripcion = "Nacida para ser leyenda. Tecate cerveza sabe a lo que debe saber una cerveza. Tecate cerveza Ideal para seguir estando juntos aunque sea a la distancia. Tecate Titanium. Tecate Ambar. Tecate Ligth. Tecate Original." },
                new Producto { Id = 3, Cantidad = 78, Nombre = "Indio", Imagen = "Indio.jpg", MarcaId = 3, TipoId = 4, Precio = 24, Descripcion = "Cerveza Indio es el nombre de una cerveza mexicana de la Cervecería Cuauhtémoc Moctezuma creada en Nuevo León, México en 1893." },
                new Producto { Id = 4, Cantidad = 12, Nombre = "Corona", Imagen = "Corona.jpg", MarcaId = 1, TipoId = 3, Precio = 25, Descripcion = "Es una cerveza tipo Pilsner de 4.5º de alcohol que actualmente se vende en más de 180 países en los cinco continentes." },
                new Producto { Id = 5, Cantidad = 88, Nombre = "Carta Blanca", Imagen = "CartaBlanca.jpg", MarcaId = 3, TipoId = 4, Precio = 31, Descripcion = "Carta Blanca es una cerveza mexicana tipo lager con más de un siglo de tradición cervecera. Con un perfil de sabor equilibrado y refrescante gracias a su proceso de elaboración e ingredientes de primera calidad que la han hecho merecedora de 20 galardones internacionales." },
                new Producto { Id = 6, Cantidad = 90, Nombre = "Modelo", Imagen = "Modelo.jpg", MarcaId = 7, TipoId = 3, Precio = 34, Descripcion = "Modelo especial, una cerveza pilsner americana, fue la primera cerveza creada y producida por Grupo Modelo en 1925. Relanzada utilizando la misma receta en 2010, Especial tiene un color dorado brillante, y un sabor dulce y bien equilibrado con lúpulos ligeros y un final fresco." },
                new Producto { Id = 7, Cantidad = 54, Nombre = "Victoria", Imagen = "Victoria.jpg", MarcaId = 7, TipoId = 4, Precio = 25, Descripcion = "Victoria es una deliciosa cerveza tipo Viena que ofrece un sabor único y chingón al estilo mexicano" },
                new Producto { Id = 8, Cantidad = 34, Nombre = "XX", Imagen = "XX.jpg", MarcaId = 5, TipoId = 3, Precio = 40, Descripcion = "La cerveza Dos Equis lager especial, nació en 1984 de la derivación de la Dos Equis ámbar. Esta marca fue creada en el estado de Veracruz para conmemorar la llegada del siglo veinte. Es una cerveza clara que dejará un toque suave y refrescante en tu paladar" },
                new Producto { Id = 9, Cantidad = 12, Nombre = "Bohemia", Imagen = "Bohemia.jpg", MarcaId = 3, TipoId = 4, Precio = 25, Descripcion = "Bohemia Vienna es una cerveza hecha con maltas caramelo, dulce y chocolate, destacan los aromas ahumados, a nuez y a café. Cerveza con un buen cuerpo, sabores a dulce y granos tostados. Es un estilo de cerveza Vienna – Fue creada en 1841 en Viena, Austria." },
                new Producto { Id = 10, Cantidad = 15,Nombre = "Pacifico", Imagen = "Pacifico.jpg", MarcaId = 2, TipoId = 4, Precio = 32, Descripcion = "Cerveza Pacífico es la cerveza mexicana tradicional y líder en el noroeste de nuestro país de Grupo Modelo. Creada a principios del siglo XX en la región de Mazatlán, Sinaloa, es de tipo lager y estilo Pilsner, clara, color dorado pálido, muy suave, refrescante y un final muy fresco." }
                );
            modelBuilder.Entity<Marca>()
                .HasMany<Producto>(x => x.Productos)
                .WithOne(s => s.Marca)
                .HasForeignKey(s => s.MarcaId);
            modelBuilder.Entity<Tipo>()
                .HasMany<Producto>(x => x.Productos)
                .WithOne(s => s.Tipo)
                .HasForeignKey(s => s.TipoId);
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3SC43RA;Database=Cerveceria;user=marissa;pwd=3312marissa;Encrypt=False;Trusted_Connection=True;");
        }*/
    }
}
