using apiComercio.Models;

namespace apiComercio.Data.Repositories;

public class ArticuloRepository
{
    public List<Articulo> Lista()
    {
        return ComercioContext.Articulos;
    }

    public void Nuevo(Articulo articulo)
    {
        articulo.ArticuloId = SiguienteId();

        ComercioContext.Articulos.Add(articulo);
    }

    public int SiguienteId()
    {
        if (ComercioContext.Articulos.Count == 0)
        {
            return 1;
        }

        return ComercioContext.Articulos.Max(w => w.ArticuloId) + 1;
    }
}