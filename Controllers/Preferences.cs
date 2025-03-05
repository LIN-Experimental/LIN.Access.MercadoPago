namespace LIN.Access.MercadoPago.Controllers;

public class Preferences
{

    /// <summary>
    /// Crear link con preferencia de pago.
    /// </summary>
    /// <param name="model">Modelo.</param>
    public async Task<PaymentResponse> Create(PaymentRequest model)
    {

        // Cliente.
        Client client = Service.GetClient("checkout/preferences");

        // Headers
         client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Post<PaymentResponse>(model);

        return response;
    }

}