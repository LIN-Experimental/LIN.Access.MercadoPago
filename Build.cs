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

        service.AddSingleton<ICardIntegration, Controllers.CardIntegration>();
        service.AddSingleton<ICustomerIntegration, Controllers.CustomerIntegration>();
        service.AddSingleton<IOrderIntegration, Controllers.OrderIntegration>();
        service.AddSingleton<IPaymentIntegration, Controllers.PaymentIntegration>();
        service.AddSingleton<IPreferenceIntegration, Controllers.PreferenceIntegration>();

        return service;
    }

}