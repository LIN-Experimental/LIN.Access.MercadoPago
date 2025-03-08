namespace LIN.Access.MercadoPago.Integrations
{
    public interface IPaymentIntegration
    {
        Task<Payment> Read(long id);
        Task<string> Refund(long id);
    }
}