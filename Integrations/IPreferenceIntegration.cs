namespace LIN.Access.MercadoPago.Integrations
{
    public interface IPreferenceIntegration
    {
        Task<PaymentResponse> Create(PaymentRequest model);
    }
}