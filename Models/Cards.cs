namespace LIN.Access.MercadoPago.Models;



public class Issuer
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class PaymentMethod
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("payment_type_id")]
    public string PaymentTypeId { get; set; }

    [JsonProperty("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonProperty("secure_thumbnail")]
    public string SecureThumbnail { get; set; }
}

public class SecurityCode
{
    [JsonProperty("length")]
    public int Length { get; set; }

    [JsonProperty("card_location")]
    public string CardLocation { get; set; }

    [JsonProperty("security_code")]
    public string Code { get; set; }
}

public class Cardholder
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("identification")]
    public IdentificationModel Identification { get; set; }
}

public class Metadata
{
    [JsonProperty("source_sync")]
    public string SourceSync { get; set; }
}




public class CardResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("first_six_digits")]
    public string FirstSixDigits { get; set; }

    [JsonProperty("expiration_month")]
    public int ExpirationMonth { get; set; }

    [JsonProperty("expiration_year")]
    public int ExpirationYear { get; set; }

    [JsonProperty("last_four_digits")]
    public string LastFourDigits { get; set; }

    [JsonProperty("cardholder")]
    public Cardholder Cardholder { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("date_created")]
    public DateTime DateCreated { get; set; }

    [JsonProperty("date_last_updated")]
    public DateTime DateLastUpdated { get; set; }

    [JsonProperty("date_due")]
    public DateTime DateDue { get; set; }

    [JsonProperty("luhn_validation")]
    public bool LuhnValidation { get; set; }

    [JsonProperty("live_mode")]
    public bool LiveMode { get; set; }

    [JsonProperty("require_esc")]
    public bool RequireEsc { get; set; }

    [JsonProperty("card_number_length")]
    public int CardNumberLength { get; set; }

    [JsonProperty("security_code_length")]
    public int SecurityCodeLength { get; set; }
}
