namespace Domain.Entities;
public class GLEntriesTemp
{
    public int TransactionId { get; set; }
    public string? GLTransactionTypeiCode { get; set; }
    public string? AccountCode { get; set; }
    public string? Memorandum { get; set; }
    public decimal? BaseAmount { get; set; }
    public decimal? LocalAmount { get; set; }
    public decimal? ForeignCurrencyAmount { get; set; }
    public decimal? LocalCurrencyAmount { get; set; }
    public string? UserRefNo { get; set; }
    public int? GLDimensionsID { get; set; }
    public string? PersonId { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? ForeignCurrencyISOCode { get; set; }
    public string? Payee { get; set; }
    public string? Customer { get; set; }
}