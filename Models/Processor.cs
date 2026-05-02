using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Processor")]
public partial class Processor
{
    [Key]
    [Column("id_cpu")]
    public int IdCpu { get; set; }

    [Column("Processor")]
    [StringLength(50)]
    public string? Processor1 { get; set; }

    [InverseProperty("LpCpuNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhCpuNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlCpuNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvCpuNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtCpuNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
