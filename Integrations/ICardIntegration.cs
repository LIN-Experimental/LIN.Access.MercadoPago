namespace LIN.Access.MercadoPago.Integrations;

public interface ICardIntegration
{
    Task<CardResponse> Create(Card model, string accessToken);
    Task<List<Card>> Get(string id, string accessToken);
    Task<CardResponse> Save(string id, string token, string accessToken);
}