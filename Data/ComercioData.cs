
using apiComercio.Data;
using apiComercio.Data.Repositories;

namespace apiComercio.Data;

public class ComercioData
{
    public ArticuloRepository Articulos
    {
        get
        {
            return new ArticuloRepository();
        }
    }
}