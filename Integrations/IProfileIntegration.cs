namespace LIN.Access.MercadoPago.Integrations;

public interface IProfileIntegration
{
    Task<User> UserInfo(string accessToken);
}