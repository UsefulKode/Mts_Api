using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Wifi")]
public partial class Wifi
{
    [Key]
    [Column("id_wifi")]
    public int IdWifi { get; set; }

    [Column("Wifi")]
    [StringLength(50)]
    public string? Wifi1 { get; set; }

    [InverseProperty("LpWifiNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhWifiNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlWifiNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvWifiNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtWifiNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
