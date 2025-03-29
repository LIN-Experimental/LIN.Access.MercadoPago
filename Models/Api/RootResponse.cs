namespace LIN.Access.MercadoPago.Models.Api;

public class RootResponse<T> where T : class
{
    [JsonProperty("paging")]
    public Paging Paging { get; set; } = new();

    [JsonProperty("results")]
    public List<T> Results { get; set; } = [];
}