using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

public partial class O
{
    [Key]
    [Column("id_os")]
    public int IdOs { get; set; }

    [Column("Os_name")]
    [StringLength(50)]
    public string? OsName { get; set; }

    [InverseProperty("LpOsNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhOsNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlOsNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvOsNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtOsNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
