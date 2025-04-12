namespace LIN.Access.MercadoPago.Models.Shared;

public class User
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; } = string.Empty;

    [JsonProperty("registration_date")]
    public DateTime RegistrationDate { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [JsonProperty("last_name")]
    public string LastName { get; set; } = string.Empty;

    [JsonProperty("gender")]
    public string Gender { get; set; } = string.Empty;

    [JsonProperty("country_id")]
    public string CountryId { get; set; } = string.Empty;

    [JsonProperty("email")]
    public string Email { get; set; } = string.Empty;

    [JsonProperty("identification")]
    public Identification? Identification { get; set; } = null;

    [JsonProperty("address")]
    public Address? Address { get; set; }

    [JsonProperty("phone")]
    public Phone? Phone { get; set; }

    [JsonProperty("alternative_phone")]
    public Phone? AlternativePhone { get; set; }

    [JsonProperty("user_type")]
    public string UserType { get; set; } = string.Empty;

    [JsonProperty("logo")]
    public string Logo { get; set; } = string.Empty;

    [JsonProperty("points")]
    public int Points { get; set; }

    [JsonProperty("site_id")]
    public string SiteId { get; set; }

    [JsonProperty("permalink")]
    public string Permalink { get; set; }

    [JsonProperty("seller_experience")]
    public string SellerExperience { get; set; }

    [JsonProperty("bill_data")]
    public BillData BillData { get; set; }

    [JsonProperty("seller_reputation")]
    public SellerReputation SellerReputation { get; set; }

    [JsonProperty("buyer_reputation")]
    public BuyerReputation BuyerReputation { get; set; }

    [JsonProperty("status")]
    public Status Status { get; set; }

    [JsonProperty("company")]
    public Company Company { get; set; }

    [JsonProperty("credit")]
    public Credit Credit { get; set; }

    [JsonProperty("context")]
    public Dictionary<string, object> Context { get; set; }

    [JsonProperty("registration_identifiers")]
    public List<object> RegistrationIdentifiers { get; set; }
}

public class Address
{
    [JsonProperty("address")]
    public string AddressLine { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("zip_code")]
    public string ZipCode { get; set; }
}

public class Phone
{
    [JsonProperty("area_code")]
    public string AreaCode { get; set; }

    [JsonProperty("extension")]
    public string Extension { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }

    [JsonProperty("verified")]
    public bool Verified { get; set; }
}

public class BillData
{
    [JsonProperty("accept_credit_note")]
    public bool? AcceptCreditNote { get; set; }
}

public class SellerReputation
{
    [JsonProperty("level_id")]
    public string LevelId { get; set; }

    [JsonProperty("power_seller_status")]
    public string PowerSellerStatus { get; set; }

    [JsonProperty("transactions")]
    public Transactions Transactions { get; set; }

    [JsonProperty("metrics")]
    public Metrics Metrics { get; set; }
}

public class Transactions
{
    [JsonProperty("canceled")]
    public int? Canceled { get; set; }

    [JsonProperty("completed")]
    public int? Completed { get; set; }

    [JsonProperty("period")]
    public string Period { get; set; }

    [JsonProperty("ratings")]
    public Ratings Ratings { get; set; }

    [JsonProperty("total")]
    public int? Total { get; set; }
}

public class Ratings
{
    [JsonProperty("negative")]
    public decimal Negative { get; set; }

    [JsonProperty("neutral")]
    public decimal Neutral { get; set; }

    [JsonProperty("positive")]
    public decimal Positive { get; set; }
}

public class Metrics
{
    [JsonProperty("sales")]
    public Sales Sales { get; set; }

    [JsonProperty("claims")]
    public MetricDetail Claims { get; set; }

    [JsonProperty("delayed_handling_time")]
    public MetricDetail DelayedHandlingTime { get; set; }

    [JsonProperty("cancellations")]
    public MetricDetail Cancellations { get; set; }
}

public class Sales
{
    [JsonProperty("period")]
    public string Period { get; set; }

    [JsonProperty("completed")]
    public int Completed { get; set; }
}

public class MetricDetail
{
    [JsonProperty("period")]
    public string Period { get; set; }

    [JsonProperty("rate")]
    public decimal Rate { get; set; }

    [JsonProperty("value")]
    public int Value { get; set; }
}

public class BuyerReputation
{
    [JsonProperty("canceled_transactions")]
    public int CanceledTransactions { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("transactions")]
    public BuyerTransactions Transactions { get; set; }
}

public class BuyerTransactions
{
    [JsonProperty("canceled")]
    public PaidTotal Canceled { get; set; }

    [JsonProperty("completed")]
    public int? Completed { get; set; }

    [JsonProperty("not_yet_rated")]
    public PaidTotalUnits NotYetRated { get; set; }

    [JsonProperty("period")]
    public string Period { get; set; }

    [JsonProperty("total")]
    public int? Total { get; set; }

    [JsonProperty("unrated")]
    public PaidTotal Unrated { get; set; }
}

public class PaidTotal
{
    [JsonProperty("paid")]
    public int? Paid { get; set; }

    [JsonProperty("total")]
    public int? Total { get; set; }
}

public class PaidTotalUnits : PaidTotal
{
    [JsonProperty("units")]
    public int? Units { get; set; }
}

public class Status
{
    [JsonProperty("billing")]
    public AllowCodes Billing { get; set; }

    [JsonProperty("buy")]
    public BuySell Buy { get; set; }

    [JsonProperty("confirmed_email")]
    public bool ConfirmedEmail { get; set; }

    [JsonProperty("shopping_cart")]
    public ShoppingCart ShoppingCart { get; set; }

    [JsonProperty("immediate_payment")]
    public bool ImmediatePayment { get; set; }

    [JsonProperty("list")]
    public BuySell List { get; set; }

    [JsonProperty("mercadoenvios")]
    public string MercadoEnvios { get; set; }

    [JsonProperty("mercadopago_account_type")]
    public string MercadoPagoAccountType { get; set; }

    [JsonProperty("mercadopago_tc_accepted")]
    public bool MercadoPagoTcAccepted { get; set; }

    [JsonProperty("required_action")]
    public string RequiredAction { get; set; }

    [JsonProperty("sell")]
    public BuySell Sell { get; set; }

    [JsonProperty("site_status")]
    public string SiteStatus { get; set; }

    [JsonProperty("user_type")]
    public string UserType { get; set; }
}

public class AllowCodes
{
    [JsonProperty("allow")]
    public bool Allow { get; set; }

    [JsonProperty("codes")]
    public List<string> Codes { get; set; }
}

public class BuySell : AllowCodes
{
    [JsonProperty("immediate_payment")]
    public ImmediatePayment ImmediatePayment { get; set; }
}

public class ImmediatePayment
{
    [JsonProperty("reasons")]
    public List<string> Reasons { get; set; }

    [JsonProperty("required")]
    public bool Required { get; set; }
}

public class ShoppingCart
{
    [JsonProperty("buy")]
    public string Buy { get; set; }

    [JsonProperty("sell")]
    public string Sell { get; set; }
}

public class Company
{
    [JsonProperty("brand_name")]
    public string BrandName { get; set; }

    [JsonProperty("city_tax_id")]
    public string CityTaxId { get; set; }

    [JsonProperty("corporate_name")]
    public string CorporateName { get; set; }

    [JsonProperty("identification")]
    public string Identification { get; set; }

    [JsonProperty("state_tax_id")]
    public string StateTaxId { get; set; }

    [JsonProperty("cust_type_id")]
    public string CustTypeId { get; set; }

    [JsonProperty("soft_descriptor")]
    public string SoftDescriptor { get; set; }
}

public class Credit
{
    [JsonProperty("consumed")]
    public int Consumed { get; set; }

    [JsonProperty("credit_level_id")]
    public string CreditLevelId { get; set; }

    [JsonProperty("rank")]
    public string Rank { get; set; }
}
