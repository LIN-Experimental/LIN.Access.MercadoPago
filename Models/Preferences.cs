namespace LIN.Access.MercadoPago.Models;

public class PaymentRequest
{
    [JsonProperty("items")]
    public List<Item> Items { get; set; }

    [JsonProperty("payer")]
    public Payer Payer { get; set; }

    [JsonProperty("payment_methods")]
    public PaymentMethods PaymentMethods { get; set; }

    [JsonProperty("back_urls")]
    public BackUrls BackUrls { get; set; }

    [JsonProperty("notification_url")]
    public string NotificationUrl { get; set; }

    [JsonProperty("external_reference")]
    public string ExternalReference { get; set; }

    [JsonProperty("statement_descriptor")]
    public string StatementDescriptor { get; set; }
}

public class Item
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("picture_url")]
    public string PictureUrl { get; set; }

    [JsonProperty("category_id")]
    public string CategoryId { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    [JsonProperty("currency_id")]
    public string CurrencyId { get; set; }

    [JsonProperty("unit_price")]
    public decimal UnitPrice { get; set; }
}

public class Payer
{
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("identification")]
    public Identification Identification { get; set; }
}

public class Identification
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }
}

public class PaymentMethods
{
    [JsonProperty("excluded_payment_methods")]
    public List<object> ExcludedPaymentMethods { get; set; } = new List<object>();

    [JsonProperty("excluded_payment_types")]
    public List<string> ExcludedPaymentTypes { get; set; } = new List<string>();

    [JsonProperty("installments")]
    public int Installments { get; set; }
}

public class BackUrls
{
    [JsonProperty("success")]
    public string Success { get; set; }

    [JsonProperty("pending")]
    public string Pending { get; set; }

    [JsonProperty("failure")]
    public string Failure { get; set; }
}

public class PaymentResponse
{
    [JsonProperty("additional_info")]
    public string AdditionalInfo { get; set; }

    [JsonProperty("auto_return")]
    public string AutoReturn { get; set; }

    [JsonProperty("back_urls")]
    public BackUrls BackUrls { get; set; }

    [JsonProperty("binary_mode")]
    public bool BinaryMode { get; set; }

    [JsonProperty("client_id")]
    public string ClientId { get; set; }

    [JsonProperty("collector_id")]
    public long CollectorId { get; set; }

    [JsonProperty("coupon_code")]
    public string CouponCode { get; set; }

    [JsonProperty("coupon_labels")]
    public string CouponLabels { get; set; }

    [JsonProperty("date_created")]
    public DateTime? DateCreated { get; set; }

    [JsonProperty("date_of_expiration")]
    public DateTime? DateOfExpiration { get; set; }

    [JsonProperty("expiration_date_from")]
    public DateTime? ExpirationDateFrom { get; set; }

    [JsonProperty("expiration_date_to")]
    public DateTime? ExpirationDateTo { get; set; }

    [JsonProperty("expires")]
    public bool Expires { get; set; }

    [JsonProperty("external_reference")]
    public string ExternalReference { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("init_point")]
    public string InitPoint { get; set; }

    [JsonProperty("sandbox_init_point")]
    public string SandboxInitPoint { get; set; }

    [JsonProperty("site_id")]
    public string SiteId { get; set; }

    [JsonProperty("notification_url")]
    public string NotificationUrl { get; set; }

    [JsonProperty("operation_type")]
    public string OperationType { get; set; }

    [JsonProperty("marketplace")]
    public string Marketplace { get; set; }

    [JsonProperty("marketplace_fee")]
    public decimal MarketplaceFee { get; set; }

    [JsonProperty("metadata")]
    public Dictionary<string, object> Metadata { get; set; }

    [JsonProperty("items")]
    public List<Item> Items { get; set; }

    [JsonProperty("payer")]
    public Payer Payer { get; set; }

    [JsonProperty("payment_methods")]
    public PaymentMethodsResponse PaymentMethods { get; set; }
}

public class PaymentMethodsResponse
{
    [JsonProperty("default_card_id")]
    public string DefaultCardId { get; set; }

    [JsonProperty("default_payment_method_id")]
    public string DefaultPaymentMethodId { get; set; }

    [JsonProperty("installments")]
    public int Installments { get; set; }
}