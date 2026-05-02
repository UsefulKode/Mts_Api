using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Material")]
public partial class Material
{
    [Key]
    [Column("id_material")]
    public int IdMaterial { get; set; }

    [Column("Material")]
    [StringLength(50)]
    public string? Material1 { get; set; }

    [InverseProperty("ChMaterialNavigation")]
    public virtual ICollection<Charger> Chargers { get; set; } = new List<Charger>();

    [InverseProperty("LpMaterialNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhMaterialNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("PbMaterialNavigation")]
    public virtual ICollection<PowerBank> PowerBanks { get; set; } = new List<PowerBank>();

    [InverseProperty("WtMaterialNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
