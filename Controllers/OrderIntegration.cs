namespace LIN.Access.MercadoPago.Controllers;

internal class OrderIntegration : IOrderIntegration
{

    /// <summary>
    /// Obtener una orden.
    /// </summary>
    /// <param name="id">Id de la orden.</param>
    public async Task<Order> Read(long id)
    {

        // Cliente.
        Client client = Service.GetClient($"merchant_orders/{id}");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Get<Order>();

        return response;
    }

    /// <summary>
    /// Obtener las ordenes asociadas.
    /// </summary>
    /// <param name="externalReference">Referencia.</param>
    public async Task<Root> ReadAll(string externalReference)
    {

        // Cliente.
        Client client = Service.GetClient($"merchant_orders/search?external_reference={externalReference}");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Get<Root>();

        return response;
    }

}