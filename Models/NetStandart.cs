using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Net_standart")]
public partial class NetStandart
{
    [Key]
    [Column("id_net_standart")]
    public int IdNetStandart { get; set; }

    [Column("Net_standart")]
    [StringLength(10)]
    public string? NetStandart1 { get; set; }

    [InverseProperty("LpNetStandartNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhNetStandartNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlNetStandartNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("WtNetStandartNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
