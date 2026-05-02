using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Ph_case_material")]
public partial class PhCaseMaterial
{
    [Key]
    [Column("id_ph_case_material")]
    public int IdPhCaseMaterial { get; set; }

    [Column("Ph_case_material_name")]
    [StringLength(50)]
    public string? PhCaseMaterialName { get; set; }

    [InverseProperty("PhCaseMaterialNavigation")]
    public virtual ICollection<PhCase> PhCases { get; set; } = new List<PhCase>();
}
