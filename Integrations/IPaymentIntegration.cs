namespace LIN.Access.MercadoPago.Integrations;

public interface IPaymentIntegration
{
    Task<RootResponse<Payment>> ReadAll(string externalReference, string accessToken);
    Task<Payment> Read(long id, string accessToken);
    Task<string> Refund(long id, string accessToken);
}