using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Laptop")]
public partial class Laptop
{
    [Key]
    [Column("id_laptop")]
    public int IdLaptop { get; set; }

    [Column("id_lp_poduct_group_type")]
    public int? IdLpPoductGroupType { get; set; }

    [Column("Lp_brand")]
    public int? LpBrand { get; set; }

    [Column("Lp_model")]
    [StringLength(50)]
    public string? LpModel { get; set; }

    [Column("Lp_index")]
    [StringLength(50)]
    public string? LpIndex { get; set; }

    [Column("Lp_description")]
    [StringLength(255)]
    public string? LpDescription { get; set; }

    [Column("Lp_price", TypeName = "decimal(10, 2)")]
    public decimal? LpPrice { get; set; }

    [Column("Lp_stock")]
    public int? LpStock { get; set; }

    [Column("Lp_color")]
    public int? LpColor { get; set; }

    [Column("Lp_storage")]
    public int? LpStorage { get; set; }

    [Column("Lp_screen_size", TypeName = "decimal(3, 1)")]
    public decimal? LpScreenSize { get; set; }

    [Column("Lp_screen_res_h")]
    public int? LpScreenResH { get; set; }

    [Column("Lp_screen_res_v")]
    public int? LpScreenResV { get; set; }

    [Column("Lp_matrix")]
    public int? LpMatrix { get; set; }

    [Column("Lp_os")]
    public int? LpOs { get; set; }

    [Column("Lp_cpu")]
    public int? LpCpu { get; set; }

    [Column("Lp_core")]
    public int? LpCore { get; set; }

    [Column("Lp_video")]
    public int? LpVideo { get; set; }

    [Column("Lp_hdmi")]
    public byte? LpHdmi { get; set; }

    [Column("Lp_type_c")]
    public byte? LpTypeC { get; set; }

    [Column("Lp_ram")]
    public int? LpRam { get; set; }

    [Column("Lp_cam")]
    public int? LpCam { get; set; }

    [Column("Lp_net_standart")]
    public int? LpNetStandart { get; set; }

    [Column("Lp_wifi")]
    public int? LpWifi { get; set; }

    [Column("Lp_bluetooth")]
    public int? LpBluetooth { get; set; }

    [Column("Lp_acum", TypeName = "decimal(4, 2)")]
    public decimal? LpAcum { get; set; }

    [Column("Lp_material")]
    public int? LpMaterial { get; set; }

    [Column("Lp_massa", TypeName = "decimal(4, 2)")]
    public decimal? LpMassa { get; set; }

    [Column("Lp_image")]
    [StringLength(255)]
    public string? LpImage { get; set; }

    [ForeignKey("IdLpPoductGroupType")]
    [InverseProperty("Laptops")]
    public virtual Product? IdLpPoductGroupTypeNavigation { get; set; }

    [ForeignKey("LpBluetooth")]
    [InverseProperty("Laptops")]
    public virtual Bluetooth? LpBluetoothNavigation { get; set; }

    [ForeignKey("LpBrand")]
    [InverseProperty("Laptops")]
    public virtual BrandName? LpBrandNavigation { get; set; }

    [ForeignKey("LpCam")]
    [InverseProperty("Laptops")]
    public virtual Camera? LpCamNavigation { get; set; }

    [ForeignKey("LpColor")]
    [InverseProperty("Laptops")]
    public virtual Color? LpColorNavigation { get; set; }

    [ForeignKey("LpCpu")]
    [InverseProperty("Laptops")]
    public virtual Processor? LpCpuNavigation { get; set; }

    [ForeignKey("LpMaterial")]
    [InverseProperty("Laptops")]
    public virtual Material? LpMaterialNavigation { get; set; }

    [ForeignKey("LpMatrix")]
    [InverseProperty("Laptops")]
    public virtual Matrix? LpMatrixNavigation { get; set; }

    [ForeignKey("LpNetStandart")]
    [InverseProperty("Laptops")]
    public virtual NetStandart? LpNetStandartNavigation { get; set; }

    [ForeignKey("LpOs")]
    [InverseProperty("Laptops")]
    public virtual O? LpOsNavigation { get; set; }

    [ForeignKey("LpStorage")]
    [InverseProperty("Laptops")]
    public virtual Storage? LpStorageNavigation { get; set; }

    [ForeignKey("LpVideo")]
    [InverseProperty("Laptops")]
    public virtual Video? LpVideoNavigation { get; set; }

    [ForeignKey("LpWifi")]
    [InverseProperty("Laptops")]
    public virtual Wifi? LpWifiNavigation { get; set; }
}
