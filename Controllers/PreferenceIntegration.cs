namespace LIN.Access.MercadoPago.Controllers;

internal class PreferenceIntegration : IPreferenceIntegration
{

    /// <summary>
    /// Crear link con preferencia de pago.
    /// </summary>
    /// <param name="model">Modelo.</param>
    public async Task<PaymentResponse> Create(PaymentRequest model, string accessToken)
    {

        // Cliente.
        Client client = Service.GetClient("checkout/preferences");

        // Headers
        client.AddHeader("Authorization", $"Bearer {accessToken}");

        // Respuesta.
        var response = await client.Post<PaymentResponse>(model);

        return response;
    }

}