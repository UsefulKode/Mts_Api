using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Slate")]
public partial class Slate
{
    [Key]
    [Column("id_slate")]
    public int IdSlate { get; set; }

    [Column("id_sl_poduct_group_type")]
    public int? IdSlPoductGroupType { get; set; }

    [Column("Sl_brand")]
    public int? SlBrand { get; set; }

    [Column("Sl_model")]
    [StringLength(50)]
    public string? SlModel { get; set; }

    [Column("Sl_index")]
    [StringLength(50)]
    public string? SlIndex { get; set; }

    [Column("Sl_description")]
    [StringLength(255)]
    public string? SlDescription { get; set; }

    [Column("Sl_price", TypeName = "decimal(10, 2)")]
    public decimal? SlPrice { get; set; }

    [Column("Sl_stock")]
    public int? SlStock { get; set; }

    [Column("Sl_color")]
    public int? SlColor { get; set; }

    [Column("Sl_storage")]
    public int? SlStorage { get; set; }

    [Column("Sl_screen_size", TypeName = "decimal(3, 1)")]
    public decimal? SlScreenSize { get; set; }

    [Column("Sl_screen_res_h")]
    public int? SlScreenResH { get; set; }

    [Column("Sl_screen_res_v")]
    public int? SlScreenResV { get; set; }

    [Column("Sl_os")]
    public int? SlOs { get; set; }

    [Column("Sl_cpu")]
    public int? SlCpu { get; set; }

    [Column("Sl_core")]
    public int? SlCore { get; set; }

    [Column("Sl_ram")]
    public int? SlRam { get; set; }

    [Column("Sl_video")]
    public int? SlVideo { get; set; }

    [Column("Sl_matrix")]
    public int? SlMatrix { get; set; }

    [Column("Sl_cam")]
    public int? SlCam { get; set; }

    [Column("Sl_net_standart")]
    public int? SlNetStandart { get; set; }

    [Column("Sl_count_sim")]
    public int? SlCountSim { get; set; }

    [Column("Sl_wifi")]
    public int? SlWifi { get; set; }

    [Column("Sl_bluetooth")]
    public int? SlBluetooth { get; set; }

    [Column("Sl_acum", TypeName = "decimal(18, 2)")]
    public decimal? SlAcum { get; set; }

    [Column("Sl_image")]
    [StringLength(255)]
    public string? SlImage { get; set; }

    [ForeignKey("IdSlPoductGroupType")]
    [InverseProperty("Slates")]
    public virtual Product? IdSlPoductGroupTypeNavigation { get; set; }

    [ForeignKey("SlBluetooth")]
    [InverseProperty("Slates")]
    public virtual Bluetooth? SlBluetoothNavigation { get; set; }

    [ForeignKey("SlBrand")]
    [InverseProperty("Slates")]
    public virtual BrandName? SlBrandNavigation { get; set; }

    [ForeignKey("SlCam")]
    [InverseProperty("Slates")]
    public virtual Camera? SlCamNavigation { get; set; }

    [ForeignKey("SlColor")]
    [InverseProperty("Slates")]
    public virtual Color? SlColorNavigation { get; set; }

    [ForeignKey("SlCpu")]
    [InverseProperty("Slates")]
    public virtual Processor? SlCpuNavigation { get; set; }

    [ForeignKey("SlMatrix")]
    [InverseProperty("Slates")]
    public virtual Matrix? SlMatrixNavigation { get; set; }

    [ForeignKey("SlNetStandart")]
    [InverseProperty("Slates")]
    public virtual NetStandart? SlNetStandartNavigation { get; set; }

    [ForeignKey("SlOs")]
    [InverseProperty("Slates")]
    public virtual O? SlOsNavigation { get; set; }

    [ForeignKey("SlStorage")]
    [InverseProperty("Slates")]
    public virtual Storage? SlStorageNavigation { get; set; }

    [ForeignKey("SlVideo")]
    [InverseProperty("Slates")]
    public virtual Video? SlVideoNavigation { get; set; }

    [ForeignKey("SlWifi")]
    [InverseProperty("Slates")]
    public virtual Wifi? SlWifiNavigation { get; set; }
}
