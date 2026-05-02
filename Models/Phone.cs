using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Phone")]
public partial class Phone
{
    [Key]
    [Column("id_phone")]
    public int IdPhone { get; set; }

    [Column("id_ph_poduct_group_type")]
    public int? IdPhPoductGroupType { get; set; }

    [Column("Ph_brand")]
    public int? PhBrand { get; set; }

    [Column("Ph_model")]
    [StringLength(50)]
    public string? PhModel { get; set; }

    [Column("Ph_index")]
    [StringLength(50)]
    public string? PhIndex { get; set; }

    [Column("Ph_description")]
    [StringLength(255)]
    public string? PhDescription { get; set; }

    [Column("Ph_price", TypeName = "decimal(10, 2)")]
    public decimal? PhPrice { get; set; }

    [Column("Ph_stock")]
    public int? PhStock { get; set; }

    [Column("Ph_color")]
    public int? PhColor { get; set; }

    [Column("Ph_storage")]
    public int? PhStorage { get; set; }

    [Column("Ph_screen_size", TypeName = "decimal(2, 1)")]
    public decimal? PhScreenSize { get; set; }

    [Column("Ph_screen_res_h")]
    public int? PhScreenResH { get; set; }

    [Column("Ph_screen_res_v")]
    public int? PhScreenResV { get; set; }

    [Column("Ph_os")]
    public int? PhOs { get; set; }

    [Column("Ph_cpu")]
    public int? PhCpu { get; set; }

    [Column("Ph_core")]
    public int? PhCore { get; set; }

    [Column("Ph_ram")]
    public int? PhRam { get; set; }

    [Column("Ph_matrix")]
    public int? PhMatrix { get; set; }

    [Column("Ph_video")]
    public int? PhVideo { get; set; }

    [Column("Ph_cam")]
    public int? PhCam { get; set; }

    [Column("Ph_net_standart")]
    public int? PhNetStandart { get; set; }

    [Column("Ph_count_sim")]
    public int? PhCountSim { get; set; }

    [Column("Ph_wifi")]
    public int? PhWifi { get; set; }

    [Column("Ph_bluetooth")]
    public int? PhBluetooth { get; set; }

    [Column("Ph_material")]
    public int? PhMaterial { get; set; }

    [Column("Ph_port")]
    public int? PhPort { get; set; }

    [Column("Ph_acum", TypeName = "decimal(18, 2)")]
    public decimal? PhAcum { get; set; }

    [Column("Ph_image")]
    [StringLength(255)]
    public string? PhImage { get; set; }

    [InverseProperty("FilmPhoneNavigation")]
    public virtual ICollection<Film> Films { get; set; } = new List<Film>();

    [ForeignKey("IdPhPoductGroupType")]
    [InverseProperty("Phones")]
    public virtual Product? IdPhPoductGroupTypeNavigation { get; set; }

    [ForeignKey("PhBluetooth")]
    [InverseProperty("Phones")]
    public virtual Bluetooth? PhBluetoothNavigation { get; set; }

    [ForeignKey("PhBrand")]
    [InverseProperty("Phones")]
    public virtual BrandName? PhBrandNavigation { get; set; }

    [ForeignKey("PhCam")]
    [InverseProperty("Phones")]
    public virtual Camera? PhCamNavigation { get; set; }

    [InverseProperty("PhCasePhoneNavigation")]
    public virtual ICollection<PhCase> PhCases { get; set; } = new List<PhCase>();

    [ForeignKey("PhColor")]
    [InverseProperty("Phones")]
    public virtual Color? PhColorNavigation { get; set; }

    [ForeignKey("PhCpu")]
    [InverseProperty("Phones")]
    public virtual Processor? PhCpuNavigation { get; set; }

    [ForeignKey("PhMaterial")]
    [InverseProperty("Phones")]
    public virtual Material? PhMaterialNavigation { get; set; }

    [ForeignKey("PhMatrix")]
    [InverseProperty("Phones")]
    public virtual Matrix? PhMatrixNavigation { get; set; }

    [ForeignKey("PhNetStandart")]
    [InverseProperty("Phones")]
    public virtual NetStandart? PhNetStandartNavigation { get; set; }

    [ForeignKey("PhOs")]
    [InverseProperty("Phones")]
    public virtual O? PhOsNavigation { get; set; }

    [ForeignKey("PhPort")]
    [InverseProperty("Phones")]
    public virtual Port? PhPortNavigation { get; set; }

    [ForeignKey("PhStorage")]
    [InverseProperty("Phones")]
    public virtual Storage? PhStorageNavigation { get; set; }

    [ForeignKey("PhVideo")]
    [InverseProperty("Phones")]
    public virtual Video? PhVideoNavigation { get; set; }

    [ForeignKey("PhWifi")]
    [InverseProperty("Phones")]
    public virtual Wifi? PhWifiNavigation { get; set; }
}
