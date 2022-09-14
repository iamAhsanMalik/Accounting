using Application.DTOs.Common;

namespace Application.DTOs.GLChartOfAccount;
public class GLChartOfAccountsDto : BaseDomainDto
{
    public int AccountId { get; set; }
    public string AccountCode { get; set; } = null!;
    public string? ParentAccountCode { get; set; }
    public string? AccountName { get; set; }
    public string? AccountCodeMask { get; set; }
    public bool? AccountStatus { get; set; }
    public string? AccountDescription { get; set; }
    public short ClassId { get; set; }
    public int? TypeId { get; set; }
    public string? Prefix { get; set; }
    public string? CurrencyISOCode { get; set; }
    public string? CountryISONumericCode { get; set; }
    public bool? RevalueYN { get; set; }
    public decimal? Revalue { get; set; }
    public decimal? DebiteLimit { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? TaxPercentage { get; set; }
    public decimal? VATWithholdingTax { get; set; }
    public bool? Charges { get; set; }
    public bool? IsHead { get; set; }
    public decimal? ForeignCurrencyBalance { get; set; }
    public decimal? LocalCurrencyBalance { get; set; }
}