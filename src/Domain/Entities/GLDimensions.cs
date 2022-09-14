namespace Domain.Entities;
public class GLDimensions
{
    public int GLDimensionId { get; set; }
    public string? Title { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public string? Notes { get; set; }
    public bool? Status { get; set; }
}