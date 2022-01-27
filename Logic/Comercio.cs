
using apiComercio.Data;
using apiComercio.Logic.Services;

namespace apiComercio.Logic;

public class Comercio
{
    public string Version = "0.2.0";
    


    public ArticuloService Articulos
    {
        get
        {
            return new ArticuloService(ComercioHelper.Data);
        }
    }
}

public static class ComercioHelper
{
    public static ComercioData Data = new ComercioData();
}
