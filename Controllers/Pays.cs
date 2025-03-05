namespace LIN.Access.MercadoPago.Controllers;

public class Pays
{

    /// <summary>
    /// Obtener un pago.
    /// </summary>
    /// <param name="id">Id del pago.</param>
    public async Task<Payment> Read(long id)
    {

        // Cliente.
        Client client = Service.GetClient($"v1/payments/{id}");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Get<Payment>();
        return response;
    }
}