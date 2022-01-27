using apiComercio.Models;

namespace apiComercio.Data;


public static class ComercioContext
{
    public static List<Articulo> Articulos = new List<Articulo>();


    public static void Iniciar()
    {
        CargarArticulos();
    }

    public static void CargarArticulos()
    {
        Articulos.Add(new Articulo
        {
            ArticuloId = 1,
            Codigo = "10",
            Descripcion = "Remera larga",
            Activo = true
        });

        Articulos.Add(new Articulo
        {
            ArticuloId = 2,
            Codigo = "11",
            Descripcion = "Remera corta",
            Activo = false
        });

        Articulos.Add(new Articulo
        {
            ArticuloId = 3,
            Codigo = "12",
            Descripcion = "Remera corta",
            Activo = true
        });

        Articulos.Add(new Articulo
        {
            ArticuloId = 4,
            Codigo = "20",
            Descripcion = "Pollera corta",
            Activo = true
        });
    }
}