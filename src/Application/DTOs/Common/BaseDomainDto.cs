namespace Application.DTOs.Common;
public class BaseDomainDto
{
    public string AddedBy { get; set; } = null!;
    public DateTime AddedDate { get; set; }
    public string LastModifyBy { get; set; } = null!;
    public DateTime LastModifyDate { get; set; }
}
