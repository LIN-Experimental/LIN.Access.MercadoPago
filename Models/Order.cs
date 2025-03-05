using Newtonsoft.Json;

namespace LIN.Access.MercadoPago.Models;

public class Order
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("external_reference")]
    public string ExternalReference { get; set; }

    [JsonProperty("preference_id")]
    public string PreferenceId { get; set; }

    [JsonProperty("payments")]
    public List<Payment> Payments { get; set; }

    [JsonProperty("shipments")]
    public List<object> Shipments { get; set; }

    [JsonProperty("payouts")]
    public List<object> Payouts { get; set; }

    [JsonProperty("marketplace")]
    public string Marketplace { get; set; }

    [JsonProperty("notification_url")]
    public string NotificationUrl { get; set; }

    [JsonProperty("date_created")]
    public DateTime DateCreated { get; set; }

    [JsonProperty("last_updated")]
    public DateTime LastUpdated { get; set; }

    [JsonProperty("sponsor_id")]
    public long? SponsorId { get; set; }

    [JsonProperty("shipping_cost")]
    public decimal ShippingCost { get; set; }

    [JsonProperty("total_amount")]
    public decimal TotalAmount { get; set; }

    [JsonProperty("site_id")]
    public string SiteId { get; set; }

    [JsonProperty("paid_amount")]
    public decimal PaidAmount { get; set; }

    [JsonProperty("refunded_amount")]
    public decimal RefundedAmount { get; set; }

    [JsonProperty("payer")]
    public Payer Payer { get; set; }

    [JsonProperty("items")]
    public List<Item> Items { get; set; }

    [JsonProperty("cancelled")]
    public bool Cancelled { get; set; }

    [JsonProperty("additional_info")]
    public string AdditionalInfo { get; set; }

    [JsonProperty("application_id")]
    public long? ApplicationId { get; set; }

    [JsonProperty("is_test")]
    public bool IsTest { get; set; }

    [JsonProperty("order_status")]
    public string OrderStatus { get; set; }
}





public class Root
{
    [JsonProperty("elements")]
    public List<Order> Elements { get; set; }

    [JsonProperty("next_offset")]
    public int NextOffset { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
}