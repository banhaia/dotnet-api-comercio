using apiComercio.Models;

namespace apiComercio.Controllers;

public class ArticulosController : BaseController
{
    private readonly ILogger<ArticulosController> _logger;

    public ArticulosController(ILogger<ArticulosController> logger)
    {
        _logger = logger;
    }

    public IEnumerable<Articulo> Activos()
    {
        return _comercio.Articulos.Activos();
    }

    public string Nuevo(string codigo, string descripcion, decimal precio)
    {
        return _comercio.Articulos.Nuevo(codigo, descripcion, precio);
    }
}
