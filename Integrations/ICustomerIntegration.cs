namespace LIN.Access.MercadoPago.Integrations;

public interface ICustomerIntegration
{
    Task<CustomerModel> Create(CustomerModel model);
    Task<CustomerModel> Read(string id);
    Task<ApiResponse> ReadByMail(string mail);
    Task<CustomerModel> Update(CustomerModel model);
}