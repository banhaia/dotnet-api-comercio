using apiComercio.Data;
using apiComercio.Models;
using System.Linq;

namespace apiComercio.Logic.Services;

public class ArticuloService
{
    private ComercioData _data;

    public ArticuloService(ComercioData data)
    {
        _data = data;
    }

    public List<Articulo> Lista()
    {
        return _data.Articulos.Lista();
    }

    public List<Articulo> Activos()
    {
        List<Articulo> lista = _data.Articulos.Lista();

        return lista.Where(w => w.Activo == true).ToList();
    }

    public string Nuevo(string codigo, string descripcion, decimal precio)
    {
        var articulo = new Articulo
        {
            Codigo = codigo,
            Descripcion = descripcion,
            Precio = precio,
            Activo = true
        };

        string mensajeValidacion = ValidarNuevo(articulo);

        if (!string.IsNullOrEmpty(mensajeValidacion)) {
            return mensajeValidacion;
        }

        _data.Articulos.Nuevo(articulo);

        return "Articulo ingresado correctamente";
    }

    private string ValidarNuevo(Articulo articulo)
    {
        if (string.IsNullOrEmpty(articulo.Codigo))
        {
            return "Debe ingresar un codigo";
        }

        // TODO: terminar validaciones

        return null;
    }

}