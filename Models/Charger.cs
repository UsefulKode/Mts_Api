using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Charger")]
public partial class Charger
{
    [Key]
    [Column("id_сharger")]
    public int IdСharger { get; set; }

    [Column("id_ch_poduct_group_type")]
    public int? IdChPoductGroupType { get; set; }

    [Column("ch_brand")]
    public int? ChBrand { get; set; }

    [Column("ch_model")]
    [StringLength(50)]
    public string? ChModel { get; set; }

    [Column("ch_index")]
    [StringLength(50)]
    public string? ChIndex { get; set; }

    [Column("ch_price", TypeName = "decimal(10, 2)")]
    public decimal? ChPrice { get; set; }

    [Column("ch_stock")]
    public int? ChStock { get; set; }

    [Column("ch_color")]
    public int? ChColor { get; set; }

    [Column("ch_material")]
    public int? ChMaterial { get; set; }

    [Column("ch_type")]
    public int? ChType { get; set; }

    [Column("ch_port")]
    public int? ChPort { get; set; }

    [Column("ch_power")]
    public byte? ChPower { get; set; }

    [Column("ch_image")]
    [StringLength(255)]
    public string? ChImage { get; set; }

    [ForeignKey("ChBrand")]
    [InverseProperty("Chargers")]
    public virtual BrandName? ChBrandNavigation { get; set; }

    [ForeignKey("ChColor")]
    [InverseProperty("Chargers")]
    public virtual Color? ChColorNavigation { get; set; }

    [ForeignKey("ChMaterial")]
    [InverseProperty("Chargers")]
    public virtual Material? ChMaterialNavigation { get; set; }

    [ForeignKey("ChPort")]
    [InverseProperty("Chargers")]
    public virtual Port? ChPortNavigation { get; set; }

    [ForeignKey("ChType")]
    [InverseProperty("Chargers")]
    public virtual ChargerType? ChTypeNavigation { get; set; }

    [ForeignKey("IdChPoductGroupType")]
    [InverseProperty("Chargers")]
    public virtual Product? IdChPoductGroupTypeNavigation { get; set; }
}
