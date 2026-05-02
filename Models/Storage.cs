using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Storage")]
public partial class Storage
{
    [Key]
    [Column("id_storage")]
    public int IdStorage { get; set; }

    public int? Sorage { get; set; }

    [InverseProperty("FlStorageNavigation")]
    public virtual ICollection<Flash> Flashes { get; set; } = new List<Flash>();

    [InverseProperty("LpStorageNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhStorageNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlStorageNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvStorageNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtStorageNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
