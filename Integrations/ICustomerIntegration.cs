namespace LIN.Access.MercadoPago.Integrations;

public interface ICustomerIntegration
{
    Task<CustomerModel> Create(CustomerModel model, string accessToken);
    Task<CustomerModel> Read(string id, string accessToken);
    Task<RootResponse<CustomerModel>> ReadByMail(string mail, string accessToken);
    Task<CustomerModel> Update(CustomerModel model, string accessToken);
}