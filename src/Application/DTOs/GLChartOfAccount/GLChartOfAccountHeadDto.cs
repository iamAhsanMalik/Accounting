using Application.DTOs.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.GLChartOfAccount;
public class GLChartOfAccountHeadDto
{
    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public decimal DebiteLimit { get; set; }
    public decimal CreditLimit { get; set; }
    public string? AccountStatus { get; set; }
    //public string? IsHead { get; set; }
    //public string AddedBy { get; set; } = null!;
    //public DateTime AddedDate { get; set; }
    //public string LastModifyBy { get; set; } = null!;
    //public DateTime LastModifyDate { get; set; }

}
