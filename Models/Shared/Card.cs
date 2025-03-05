namespace LIN.Access.MercadoPago.Models.Shared;

public class Card
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("customer_id")]
    public string? CustomerId { get; set; }

    [JsonProperty("date_created")]
    public string? DateCreated { get; set; }

    [JsonProperty("date_last_updated")]
    public string? DateLastUpdated { get; set; }

    [JsonProperty("expiration_month")]
    public int ExpirationMonth { get; set; }

    [JsonProperty("expiration_year")]
    public int ExpirationYear { get; set; }

    [JsonProperty("first_six_digits")]
    public string? FirstSixDigits { get; set; }

    [JsonProperty("last_four_digits")]
    public string? LastFourDigits { get; set; }

    [JsonProperty("issuer")]
    public Issuer? Issuer { get; set; }

    [JsonProperty("payment_method")]
    public PaymentMethod? PaymentMethod { get; set; }

    [JsonProperty("security_code")]
    public SecurityCode? SecurityCode { get; set; }

    [JsonProperty("cardholder")]
    public Cardholder? Cardholder { get; set; }

    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    [JsonProperty("card_number")]
    public string? CardNumber { get; set; }
}