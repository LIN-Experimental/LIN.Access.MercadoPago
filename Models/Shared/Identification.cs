namespace LIN.Access.MercadoPago.Models.Shared;

public class Identification
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("number")]
    public string Number { get; set; } = string.Empty;
}
