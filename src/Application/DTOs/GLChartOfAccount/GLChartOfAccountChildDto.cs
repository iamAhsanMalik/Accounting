using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.GLChartOfAccount;
public class GLChartOfAccountChildDto
{
    [Required]
    public int ParentAccountCode { get; set; }
    //public List<SelectListItem> ParentAccountName { get; set; } = new List<SelectListItem>();

    public string? AccountName { get; set; }
    public string? AccountStatus { get; set; }
}
