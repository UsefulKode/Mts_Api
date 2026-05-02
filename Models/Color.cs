using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Color")]
public partial class Color
{
    [Key]
    [Column("id_color")]
    public int IdColor { get; set; }

    [Column("Color_name")]
    [StringLength(50)]
    public string? ColorName { get; set; }

    [InverseProperty("AdapterColorNavigation")]
    public virtual ICollection<Adapter> Adapters { get; set; } = new List<Adapter>();

    [InverseProperty("ChColorNavigation")]
    public virtual ICollection<Charger> Chargers { get; set; } = new List<Charger>();

    [InverseProperty("FlColorNavigation")]
    public virtual ICollection<Flash> Flashes { get; set; } = new List<Flash>();

    [InverseProperty("HdColorNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();

    [InverseProperty("LpColorNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhCaseColorNavigation")]
    public virtual ICollection<PhCase> PhCases { get; set; } = new List<PhCase>();

    [InverseProperty("PhColorNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("PbColorNavigation")]
    public virtual ICollection<PowerBank> PowerBanks { get; set; } = new List<PowerBank>();

    [InverseProperty("SlColorNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("WtColorNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
