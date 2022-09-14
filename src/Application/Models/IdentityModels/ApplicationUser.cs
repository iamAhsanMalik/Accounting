namespace Application.Models.IdentityModels;

public class ApplicationUser : IdentityUser
{
    public byte UserType { get; set; }
    public bool Status { get; set; }
}
