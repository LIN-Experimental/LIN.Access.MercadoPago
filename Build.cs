using Microsoft.Extensions.DependencyInjection;

namespace LIN.Access.MercadoPago;

public static class Build
{
    /// <summary>
    /// Token de mercado pago.
    /// </summary>
    internal static string AccessToken { get; set; } = string.Empty;

    /// <summary>
    /// Utilizar Mercado Pago API.
    /// </summary>
    public static IServiceCollection AddMercadoPagoService(this IServiceCollection service, string? token = null)
    {
        Service._Service = new();
        Service._Service.SetDefault("https://api.mercadopago.com/");
        AccessToken = token ?? string.Empty;

        service.AddSingleton<Controllers.Cards>();
        service.AddSingleton<Controllers.Customers>();
        service.AddSingleton<Controllers.Orders>();
        service.AddSingleton<Controllers.Pays>();
        service.AddSingleton<Controllers.Preferences>();

        return service;
    }

}