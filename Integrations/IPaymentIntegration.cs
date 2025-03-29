namespace LIN.Access.MercadoPago.Integrations;

public interface IPaymentIntegration
{
    Task<RootResponse<Payment>> ReadAll(string externalReference);
    Task<Payment> Read(long id);
    Task<string> Refund(long id);
}