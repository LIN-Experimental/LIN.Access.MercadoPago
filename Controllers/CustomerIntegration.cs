﻿namespace LIN.Access.MercadoPago.Controllers;

internal class CustomerIntegration : ICustomerIntegration
{

    /// <summary>
    /// Crear nuevo cliente.
    /// </summary>
    /// <param name="model">Modelo.</param>
    public async Task<CustomerModel> Create(CustomerModel model, string accessToken)
    {

        // Cliente.
        Client client = Service.GetClient("v1/customers");

        // Headers
        client.AddHeader("Authorization", $"Bearer {accessToken}");

        // Respuesta.
        var response = await client.Post<CustomerModel>(new
        {
            email = model.Email,
            first_name = model.FirstName,
            last_name = model.LastName,
            phone = new
            {
                area_code = model.Phone.AreaCode,
                number = model.Phone.Number
            },
            identification = new
            {
                type = model.Identification.Type,
                number = model.Identification.Number
            },
            default_address = "Home",
            description = model.Description
        });

        return response;
    }

    /// <summary>
    /// Obtener un cliente mediante el Id.
    /// </summary>
    /// <param name="id">Id del cliente.</param>
    public async Task<CustomerModel> Read(string id, string accessToken)
    {

        // Cliente.
        Client client = Service.GetClient($"v1/customers/{id}");

        // Headers
        client.AddHeader("Authorization", $"Bearer {accessToken}");

        // Respuesta.
        var response = await client.Get<CustomerModel>();

        return response;
    }

    /// <summary>
    /// Obtener cliente por correo.
    /// </summary>
    /// <param name="mail">Correo del cliente.</param>
    public async Task<RootResponse<CustomerModel>> ReadByMail(string mail, string accessToken)
    {

        // Cliente.
        Client client = Service.GetClient($"v1/customers/search");

        // Headers
        client.AddHeader("Authorization", $"Bearer {accessToken}");
        client.AddParameter("email", mail);

        // Respuesta.
        var response = await client.Get<RootResponse<CustomerModel>>();

        return response;
    }

    /// <summary>
    /// Actualizar un cliente.
    /// </summary>
    /// <param name="model">Modelo.</param>
    public async Task<CustomerModel> Update(CustomerModel model, string accessToken)
    {

        // Cliente.
        Client client = Service.GetClient($"v1/customers/{model.Id}");

        // Headers
        client.AddHeader("Authorization", $"Bearer {accessToken}");

        // Respuesta.
        var response = await client.Post<CustomerModel>(new
        {
            first_name = model.FirstName,
            last_name = model.LastName,
            phone = new
            {
                area_code = model.Phone.AreaCode,
                number = model.Phone.Number
            },
            identification = new
            {
                type = model.Identification.Type,
                number = model.Identification.Number
            },
            default_address = "Home",
            description = model.Description
        });

        return response;
    }

}