namespace LIN.Access.MercadoPago.Models;

using Newtonsoft.Json;

public class CustomerModel
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("phone")]
    public PhoneModel Phone { get; set; }

    [JsonProperty("identification")]
    public IdentificationModel Identification { get; set; }

    [JsonProperty("default_address")]
    public string DefaultAddress { get; set; }

    [JsonProperty("date_registered")]
    public string DateRegistered { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("default_card")]
    public string DefaultCard { get; set; }
}

public class PhoneModel
{
    [JsonProperty("area_code")]
    public string AreaCode { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }
}

public class IdentificationModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }
}

public class ApiResponse
{
    [JsonProperty("paging")]
    public Paging Paging { get; set; }

    [JsonProperty("results")]
    public List<CustomerModel> Results { get; set; }
}

public class Paging
{
    [JsonProperty("limit")]
    public int Limit { get; set; }

    [JsonProperty("offset")]
    public int Offset { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}