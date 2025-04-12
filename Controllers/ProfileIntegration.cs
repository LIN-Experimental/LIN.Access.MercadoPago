namespace LIN.Access.MercadoPago.Controllers;

internal class ProfileIntegration : IProfileIntegration
{

    /// <summary>
    /// Obtener la información del usuario.
    /// </summary>
    /// <param name="accessToken">Token de acceso.</param>
    public async Task<User> UserInfo(string accessToken)
    {

        // Cliente.
        Client client = Service.GetClient("users/me");

        // Headers
        client.AddHeader("Authorization", $"Bearer {accessToken}");

        // Respuesta.
        var response = await client.Get<User>();

        return response;
    }

}