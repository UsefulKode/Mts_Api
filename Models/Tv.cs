using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Tv")]
public partial class Tv
{
    [Key]
    [Column("id_tv")]
    public int IdTv { get; set; }

    [Column("id_tv_poduct_group_type")]
    public int? IdTvPoductGroupType { get; set; }

    [Column("Tv_brand")]
    public int? TvBrand { get; set; }

    [Column("Tv_model")]
    [StringLength(50)]
    public string? TvModel { get; set; }

    [Column("Tv_index")]
    [StringLength(50)]
    public string? TvIndex { get; set; }

    [Column("Tv_description")]
    [StringLength(255)]
    public string? TvDescription { get; set; }

    [Column("Tv_price", TypeName = "decimal(10, 2)")]
    public decimal? TvPrice { get; set; }

    [Column("Tv_stock")]
    public int? TvStock { get; set; }

    [Column("Tv_screen_size")]
    public int? TvScreenSize { get; set; }

    [Column("Tv_screen_res_h")]
    public int? TvScreenResH { get; set; }

    [Column("Tv_screen_res_v")]
    public int? TvScreenResV { get; set; }

    [Column("Tv_matrix")]
    public int? TvMatrix { get; set; }

    [Column("Tv_format")]
    public int? TvFormat { get; set; }

    [Column("Tv_refresh")]
    public byte? TvRefresh { get; set; }

    [Column("Tv_os")]
    public int? TvOs { get; set; }

    [Column("Tv_storage")]
    public int? TvStorage { get; set; }

    [Column("Tv_ram", TypeName = "decimal(4, 2)")]
    public decimal? TvRam { get; set; }

    [Column("Tv_cpu")]
    public int? TvCpu { get; set; }

    [Column("Tv_core")]
    public int? TvCore { get; set; }

    [Column("Tv_video")]
    public int? TvVideo { get; set; }

    [Column("Tv_sound")]
    public int? TvSound { get; set; }

    [Column("Tv_sound_power")]
    public int? TvSoundPower { get; set; }

    [Column("Tv_wifi")]
    public int? TvWifi { get; set; }

    [Column("Tv_bluetooth")]
    public int? TvBluetooth { get; set; }

    [Column("Tv_hdmi")]
    public byte? TvHdmi { get; set; }

    [Column("Tv_smart")]
    public bool? TvSmart { get; set; }

    [Column("Tv_massa", TypeName = "decimal(4, 2)")]
    public decimal? TvMassa { get; set; }

    [Column("Tv_image")]
    [StringLength(255)]
    public string? TvImage { get; set; }

    [ForeignKey("IdTvPoductGroupType")]
    [InverseProperty("Tvs")]
    public virtual Product? IdTvPoductGroupTypeNavigation { get; set; }

    [ForeignKey("TvBluetooth")]
    [InverseProperty("Tvs")]
    public virtual Bluetooth? TvBluetoothNavigation { get; set; }

    [ForeignKey("TvBrand")]
    [InverseProperty("Tvs")]
    public virtual BrandName? TvBrandNavigation { get; set; }

    [ForeignKey("TvCpu")]
    [InverseProperty("Tvs")]
    public virtual Processor? TvCpuNavigation { get; set; }

    [ForeignKey("TvFormat")]
    [InverseProperty("Tvs")]
    public virtual FormatTv? TvFormatNavigation { get; set; }

    [ForeignKey("TvMatrix")]
    [InverseProperty("Tvs")]
    public virtual Matrix? TvMatrixNavigation { get; set; }

    [ForeignKey("TvOs")]
    [InverseProperty("Tvs")]
    public virtual O? TvOsNavigation { get; set; }

    [ForeignKey("TvSound")]
    [InverseProperty("Tvs")]
    public virtual Sound? TvSoundNavigation { get; set; }

    [ForeignKey("TvStorage")]
    [InverseProperty("Tvs")]
    public virtual Storage? TvStorageNavigation { get; set; }

    [ForeignKey("TvVideo")]
    [InverseProperty("Tvs")]
    public virtual Video? TvVideoNavigation { get; set; }

    [ForeignKey("TvWifi")]
    [InverseProperty("Tvs")]
    public virtual Wifi? TvWifiNavigation { get; set; }
}
