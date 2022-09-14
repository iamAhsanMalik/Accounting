namespace Application.DTOs;
public class GLReferencesDto
{
    public int GLReferenceId { get; set; }
    public string? TypeiCode { get; set; }
    public string? ReferenceNo { get; set; }
    public string? Memorandum { get; set; }
    public bool? IsPosted { get; set; }
    public string? PostedBy { get; set; }
    public DateTime? DatePosted { get; set; }
    public string? AuthorizedBy { get; set; }
    public DateTime? AuthorizedDate { get; set; }
    public int? VoucherNumber { get; set; }
}