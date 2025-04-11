namespace LIN.Access.MercadoPago.Integrations;

public interface IOrderIntegration
{
    Task<Order> Read(long id, string accessToken);
    Task<Root> ReadAll(string externalReference, string accessToken);
}