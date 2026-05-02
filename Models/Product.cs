using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    [Column("id_product_group")]
    public int IdProductGroup { get; set; }

    [Column("Group_name")]
    [StringLength(50)]
    public string? GroupName { get; set; }

    [InverseProperty("IdAdapterPoductGroupTypeNavigation")]
    public virtual ICollection<Adapter> Adapters { get; set; } = new List<Adapter>();

    [InverseProperty("IdChPoductGroupTypeNavigation")]
    public virtual ICollection<Charger> Chargers { get; set; } = new List<Charger>();

    [InverseProperty("IdFlPoductGroupTypeNavigation")]
    public virtual ICollection<Flash> Flashes { get; set; } = new List<Flash>();

    [InverseProperty("IdHdPoductGroupTypeNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();

    [InverseProperty("IdLpPoductGroupTypeNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("IdPhAccsProductGroupTypeNavigation")]
    public virtual ICollection<PhAccessory> PhAccessories { get; set; } = new List<PhAccessory>();

    [InverseProperty("IdPhPoductGroupTypeNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("IdPbPoductGroupTypeNavigation")]
    public virtual ICollection<PowerBank> PowerBanks { get; set; } = new List<PowerBank>();

    [InverseProperty("IdSvPoductGroupTypeNavigation")]
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    [InverseProperty("IdSlPoductGroupTypeNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("IdTarifPoductGroupTypeNavigation")]
    public virtual ICollection<Tarif> Tarifs { get; set; } = new List<Tarif>();

    [InverseProperty("IdTvPoductGroupTypeNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("IdWtPoductGroupTypeNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
