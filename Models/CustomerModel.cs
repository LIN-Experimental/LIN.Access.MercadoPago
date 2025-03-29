namespace LIN.Access.MercadoPago.Models;

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
    public Identification Identification { get; set; }

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