namespace Domain.Entities;
public class GLFiscalYear : BaseDomainEntity
{
    public int FiscalYearId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? Closed { get; set; }
}