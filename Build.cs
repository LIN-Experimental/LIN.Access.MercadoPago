using Microsoft.Extensions.DependencyInjection;

namespace LIN.Access.MercadoPago;

public static class Build
{
    /// <summary>
    /// Utilizar Mercado Pago API.
    /// </summary>
    public static IServiceCollection AddMercadoPagoService(this IServiceCollection service)
    {
        Service._Service = new();
        Service._Service.SetDefault("https://api.mercadopago.com/");

        service.AddSingleton<ICardIntegration, Controllers.CardIntegration>();
        service.AddSingleton<ICustomerIntegration, Controllers.CustomerIntegration>();
        service.AddSingleton<IOrderIntegration, Controllers.OrderIntegration>();
        service.AddSingleton<IPaymentIntegration, Controllers.PaymentIntegration>();
        service.AddSingleton<IPreferenceIntegration, Controllers.PreferenceIntegration>();
        service.AddSingleton<IProfileIntegration, Controllers.ProfileIntegration>();

        return service;
    }

}