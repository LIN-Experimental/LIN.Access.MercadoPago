namespace LIN.Access.MercadoPago.Integrations;

public interface IOrderIntegration
{
    Task<Order> Read(long id);
    Task<Root> ReadAll(string externalReference);
}