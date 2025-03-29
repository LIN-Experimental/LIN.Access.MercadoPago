namespace LIN.Access.MercadoPago.Controllers;

internal class PaymentIntegration : IPaymentIntegration
{

    /// <summary>
    /// Obtener los pagos asociados a una referencia externa.
    /// </summary>
    /// <param name="externalReference">Referencia externa.</param>
    public async Task<RootResponse<Payment>> ReadAll(string externalReference)
    {
        // Cliente.
        Client client = Service.GetClient($"v1/payments/search");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Parametros.
        client.AddParameter("sort", "date_created");
        client.AddParameter("criteria", "desc");
        client.AddParameter("external_reference", externalReference);
        client.AddParameter("range", "date_created");
        client.AddParameter("begin_date", $"NOW-100MONTHS");
        client.AddParameter("end_date", "NOW");

        // Respuesta.
        var response = await client.Get<RootResponse<Payment>>();
        return response;
    }

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

    /// <summary>
    /// Reembolsar un pago.
    /// </summary>
    /// <param name="id">Id del pago.</param>
    public async Task<string> Refund(long id)
    {

        // Cliente.
        Client client = Service.GetClient($"v1/payments/{id}/refunds");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");
        client.AddHeader("X-Idempotency-Key", $"{Guid.NewGuid()}");

        // Respuesta.
        var response = await client.Post();
        return response;
    }

}