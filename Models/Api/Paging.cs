namespace LIN.Access.MercadoPago.Models.Api;

public class Paging
{
    [JsonProperty("limit")]
    public int Limit { get; set; }

    [JsonProperty("offset")]
    public int Offset { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}
