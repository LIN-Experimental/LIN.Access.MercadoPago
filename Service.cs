global using Global.Http.Services;
global using LIN.Access.MercadoPago.Models;
global using Newtonsoft.Json;
global using LIN.Access.MercadoPago.Models.Shared;
global using LIN.Access.MercadoPago.Integrations;

namespace LIN.Access.MercadoPago;

internal class Service
{

    /// <summary>
    /// Servicio.
    /// </summary>

    public static Global.Http.Service _Service = new();

    /// <summary>
    /// Obtener un cliente.
    /// </summary>
    public static Client GetClient(string url) => _Service.GetClient(url);

}