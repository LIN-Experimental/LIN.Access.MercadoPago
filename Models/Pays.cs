namespace LIN.Access.MercadoPago.Models;

using Newtonsoft.Json;
using System;

public class Payment
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("date_created")]
    public DateTime DateCreated { get; set; }

    [JsonProperty("date_approved")]
    public DateTime DateApproved { get; set; }

    [JsonProperty("date_last_updated")]
    public DateTime DateLastUpdated { get; set; }

    [JsonProperty("money_release_date")]
    public DateTime MoneyReleaseDate { get; set; }

    [JsonProperty("payment_method_id")]
    public string PaymentMethodId { get; set; }

    [JsonProperty("payment_type_id")]
    public string PaymentTypeId { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("status_detail")]
    public string StatusDetail { get; set; }

    [JsonProperty("currency_id")]
    public string CurrencyId { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("collector_id")]
    public long CollectorId { get; set; }

    [JsonProperty("payer")]
    public Payer Payer { get; set; }

    [JsonProperty("metadata")]
    public object Metadata { get; set; }

    [JsonProperty("additional_info")]
    public object AdditionalInfo { get; set; }

    [JsonProperty("external_reference")]
    public string ExternalReference { get; set; }

    [JsonProperty("transaction_amount")]
    public decimal TransactionAmount { get; set; }

    [JsonProperty("transaction_amount_refunded")]
    public decimal TransactionAmountRefunded { get; set; }

    [JsonProperty("coupon_amount")]
    public decimal CouponAmount { get; set; }

    [JsonProperty("transaction_details")]
    public TransactionDetails TransactionDetails { get; set; }

    [JsonProperty("installments")]
    public int Installments { get; set; }

    [JsonProperty("card")]
    public object Card { get; set; }

    [JsonProperty("order")]
    public PayOrder? Order { get; set; }

    [JsonProperty("net_amount")]
    public decimal? NetAmount { get; set; }
}

public class PayOrder
{

    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }
}

public class TransactionDetails
{
    [JsonProperty("net_received_amount")]
    public decimal NetReceivedAmount { get; set; }

    [JsonProperty("total_paid_amount")]
    public decimal TotalPaidAmount { get; set; }

    [JsonProperty("overpaid_amount")]
    public decimal OverpaidAmount { get; set; }

    [JsonProperty("installment_amount")]
    public decimal InstallmentAmount { get; set; }
}
