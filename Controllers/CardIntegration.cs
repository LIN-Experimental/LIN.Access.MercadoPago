namespace LIN.Access.MercadoPago.Controllers;

internal class CardIntegration : ICardIntegration
{

    /// <summary>
    /// Crear nueva tarjeta.
    /// </summary>
    /// <param name="model">Modelo de la tarjeta.</param>
    public async Task<CardResponse> Create(Card model)
    {
        // Cliente.
        Client client = Service.GetClient("v1/card_tokens");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Post<CardResponse>(new
        {
            card_number = model.CardNumber,
            expiration_month = model.ExpirationMonth,
            expiration_year = model.ExpirationYear,
            security_code = model.SecurityCode,
            cardholder = new
            {
                name = model.Cardholder?.Name,
                identification = new
                {
                    type = model.Cardholder?.Identification,
                    number = model.Cardholder?.Identification.Number
                }
            }
        });

        return response;
    }

    /// <summary>
    /// Guardar tarjeta a un cliente.
    /// </summary>
    /// <param name="id">Id del cliente.</param>
    /// <param name="token">Token de tarjeta.</param>
    public async Task<CardResponse> Save(string id, string token)
    {
        // Cliente.
        Client client = Service.GetClient($"v1/customers/{id}/cards");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Post<CardResponse>(new
        {
            token = token
        });

        return response;
    }

    /// <summary>
    /// Obtener la lista de tarjetas de un cliente.
    /// </summary>
    /// <param name="id">Id del cliente.</param>
    public async Task<List<Card>> Get(string id)
    {

        // Cliente.
        Client client = Service.GetClient($"v1/customers/{id}/cards");

        // Headers
        client.AddHeader("Authorization", $"Bearer {Build.AccessToken}");

        // Respuesta.
        var response = await client.Get<List<Card>>();

        return response;
    }

}