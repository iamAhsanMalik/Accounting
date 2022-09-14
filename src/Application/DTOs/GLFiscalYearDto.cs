using Application.DTOs.Common;

namespace Application.DTOs;
public class GLFiscalYearDto : BaseDomainDto
{
    public int FiscalYearId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? Closed { get; set; }
}