using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Watch")]
public partial class Watch
{
    [Key]
    [Column("id_watch")]
    public int IdWatch { get; set; }

    [Column("id_wt_poduct_group_type")]
    public int? IdWtPoductGroupType { get; set; }

    [Column("Wt_brand")]
    public int? WtBrand { get; set; }

    [Column("Wt_model")]
    [StringLength(50)]
    public string? WtModel { get; set; }

    [Column("Wt_index")]
    [StringLength(50)]
    public string? WtIndex { get; set; }

    [Column("Wt_description")]
    [StringLength(255)]
    public string? WtDescription { get; set; }

    [Column("Wt_price", TypeName = "decimal(10, 2)")]
    public decimal? WtPrice { get; set; }

    [Column("Wt_stock")]
    public int? WtStock { get; set; }

    [Column("Wt_color")]
    public int? WtColor { get; set; }

    [Column("Wt_storage")]
    public int? WtStorage { get; set; }

    [Column("Wt_screen_size", TypeName = "decimal(2, 1)")]
    public decimal? WtScreenSize { get; set; }

    [Column("Wt_screen_res_h")]
    public int? WtScreenResH { get; set; }

    [Column("Wt_screen_res_v")]
    public int? WtScreenResV { get; set; }

    [Column("Wt_os")]
    public int? WtOs { get; set; }

    [Column("Wt_cpu")]
    public int? WtCpu { get; set; }

    [Column("Wt_core")]
    public int? WtCore { get; set; }

    [Column("Wt_ram")]
    public int? WtRam { get; set; }

    [Column("Wt_matrix")]
    public int? WtMatrix { get; set; }

    [Column("Wt_video")]
    public int? WtVideo { get; set; }

    [Column("Wt_cam")]
    public int? WtCam { get; set; }

    [Column("Wt_net_standart")]
    public int? WtNetStandart { get; set; }

    [Column("Wt_count_sim")]
    public int? WtCountSim { get; set; }

    [Column("Wt_wifi")]
    public int? WtWifi { get; set; }

    [Column("Wt_bluetooth")]
    public int? WtBluetooth { get; set; }

    [Column("Wt_material")]
    public int? WtMaterial { get; set; }

    [Column("Wt_port")]
    public int? WtPort { get; set; }

    [Column("Wt_acum", TypeName = "decimal(18, 2)")]
    public decimal? WtAcum { get; set; }

    [Column("Wt_image")]
    [StringLength(255)]
    public string? WtImage { get; set; }

    [ForeignKey("IdWtPoductGroupType")]
    [InverseProperty("Watches")]
    public virtual Product? IdWtPoductGroupTypeNavigation { get; set; }

    [ForeignKey("WtBluetooth")]
    [InverseProperty("Watches")]
    public virtual Bluetooth? WtBluetoothNavigation { get; set; }

    [ForeignKey("WtBrand")]
    [InverseProperty("Watches")]
    public virtual BrandName? WtBrandNavigation { get; set; }

    [ForeignKey("WtCam")]
    [InverseProperty("Watches")]
    public virtual Camera? WtCamNavigation { get; set; }

    [ForeignKey("WtColor")]
    [InverseProperty("Watches")]
    public virtual Color? WtColorNavigation { get; set; }

    [ForeignKey("WtCpu")]
    [InverseProperty("Watches")]
    public virtual Processor? WtCpuNavigation { get; set; }

    [ForeignKey("WtMaterial")]
    [InverseProperty("Watches")]
    public virtual Material? WtMaterialNavigation { get; set; }

    [ForeignKey("WtMatrix")]
    [InverseProperty("Watches")]
    public virtual Matrix? WtMatrixNavigation { get; set; }

    [ForeignKey("WtNetStandart")]
    [InverseProperty("Watches")]
    public virtual NetStandart? WtNetStandartNavigation { get; set; }

    [ForeignKey("WtOs")]
    [InverseProperty("Watches")]
    public virtual O? WtOsNavigation { get; set; }

    [ForeignKey("WtPort")]
    [InverseProperty("Watches")]
    public virtual Port? WtPortNavigation { get; set; }

    [ForeignKey("WtStorage")]
    [InverseProperty("Watches")]
    public virtual Storage? WtStorageNavigation { get; set; }

    [ForeignKey("WtVideo")]
    [InverseProperty("Watches")]
    public virtual Video? WtVideoNavigation { get; set; }

    [ForeignKey("WtWifi")]
    [InverseProperty("Watches")]
    public virtual Wifi? WtWifiNavigation { get; set; }
}
