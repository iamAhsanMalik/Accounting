namespace Domain.Entities;
public class GLTransactions : BaseDomainEntity
{
    public int TransactionId { get; set; }
    public int? GLReferenceId { get; set; }
    public short Type { get; set; }
    public string? AccountTypeiCode { get; set; }
    public string AccountCode { get; set; } = null!;
    public string? Memorandum { get; set; }
    public decimal? BaseAmount { get; set; }
    public decimal? LocalAmount { get; set; }
    public string? ForeignCurrencyISOCode { get; set; }
    public decimal? ForeignCurrencyAmount { get; set; }
    public decimal? LocalCurrencyAmount { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? GLPersonTypeiCode { get; set; }
    public string? PersonID { get; set; }
    public short DimensionId { get; set; }
    public short Dimension2Id { get; set; }
    public string? TransactionNumber { get; set; }
    public string? Payee { get; set; }
    public string? Customer { get; set; }
}