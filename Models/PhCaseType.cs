using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Ph_case_type")]
public partial class PhCaseType
{
    [Key]
    [Column("id_ph_case_type")]
    public int IdPhCaseType { get; set; }

    [Column("Ph_case_type_name")]
    [StringLength(50)]
    public string? PhCaseTypeName { get; set; }

    [InverseProperty("PhCaseTypeNavigation")]
    public virtual ICollection<PhCase> PhCases { get; set; } = new List<PhCase>();
}
