using apiComercio.Data;
using apiComercio.Logic;
using apiComercio.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiComercio.Controllers;

public abstract class BaseController : Controller
{
    internal Comercio _comercio;

    public BaseController()
    {
        _comercio = new Comercio();
    }
}
