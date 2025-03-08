namespace LIN.Access.MercadoPago.Integrations;

public interface ICardIntegration
{
    Task<CardResponse> Create(Card model);
    Task<List<Card>> Get(string id);
    Task<CardResponse> Save(string id, string token);
}