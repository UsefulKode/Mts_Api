using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Power_bank")]
public partial class PowerBank
{
    [Key]
    [Column("id_power_bank")]
    public int IdPowerBank { get; set; }

    [Column("id_pb_poduct_group_type")]
    public int? IdPbPoductGroupType { get; set; }

    [Column("Pb_brand")]
    public int? PbBrand { get; set; }

    [Column("Pb_model")]
    [StringLength(50)]
    public string? PbModel { get; set; }

    [Column("Pb_index")]
    [StringLength(50)]
    public string PbIndex { get; set; } = null!;

    [Column("Pb_description")]
    [StringLength(255)]
    public string? PbDescription { get; set; }

    [Column("Pb_price", TypeName = "decimal(10, 2)")]
    public decimal? PbPrice { get; set; }

    [Column("Pb_stock")]
    public int? PbStock { get; set; }

    [Column("Pb_color")]
    public int? PbColor { get; set; }

    [Column("Pb_material")]
    public int? PbMaterial { get; set; }

    [Column("Pb_usb_a")]
    public byte? PbUsbA { get; set; }

    [Column("Pb_usb_c")]
    public byte? PbUsbC { get; set; }

    [Column("Pb_usb_micro")]
    public byte? PbUsbMicro { get; set; }

    [Column("Pb_massa")]
    public int? PbMassa { get; set; }

    [Column("Pb_acum", TypeName = "decimal(18, 2)")]
    public decimal? PbAcum { get; set; }

    [Column("Pb_fastcharge")]
    public bool? PbFastcharge { get; set; }

    [Column("Pb_image")]
    [StringLength(255)]
    public string? PbImage { get; set; }

    [ForeignKey("IdPbPoductGroupType")]
    [InverseProperty("PowerBanks")]
    public virtual Product? IdPbPoductGroupTypeNavigation { get; set; }

    [ForeignKey("PbBrand")]
    [InverseProperty("PowerBanks")]
    public virtual BrandName? PbBrandNavigation { get; set; }

    [ForeignKey("PbColor")]
    [InverseProperty("PowerBanks")]
    public virtual Color? PbColorNavigation { get; set; }

    [ForeignKey("PbMaterial")]
    [InverseProperty("PowerBanks")]
    public virtual Material? PbMaterialNavigation { get; set; }
}
