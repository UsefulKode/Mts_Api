using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Brand_name")]
public partial class BrandName
{
    [Key]
    [Column("id_brand_name")]
    public int IdBrandName { get; set; }

    [Column("Brand_name")]
    [StringLength(50)]
    public string? BrandName1 { get; set; }

    [InverseProperty("AdapterBrandNavigation")]
    public virtual ICollection<Adapter> Adapters { get; set; } = new List<Adapter>();

    [InverseProperty("ChBrandNavigation")]
    public virtual ICollection<Charger> Chargers { get; set; } = new List<Charger>();

    [InverseProperty("IdFilmBrendNavigation")]
    public virtual ICollection<Film> Films { get; set; } = new List<Film>();

    [InverseProperty("FlBrandNavigation")]
    public virtual ICollection<Flash> Flashes { get; set; } = new List<Flash>();

    [InverseProperty("HdBrendNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();

    [InverseProperty("LpBrandNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhCaseBrandNavigation")]
    public virtual ICollection<PhCase> PhCases { get; set; } = new List<PhCase>();

    [InverseProperty("PhBrandNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("PbBrandNavigation")]
    public virtual ICollection<PowerBank> PowerBanks { get; set; } = new List<PowerBank>();

    [InverseProperty("SlBrandNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvBrandNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtBrandNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
