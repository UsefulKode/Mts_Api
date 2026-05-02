using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Headset")]
public partial class Headset
{
    [Key]
    [Column("id_headset")]
    public int IdHeadset { get; set; }

    [Column("id_hd_poduct_group_type")]
    public int? IdHdPoductGroupType { get; set; }

    [Column("Hd_brend")]
    public int? HdBrend { get; set; }

    [Column("Hd_model")]
    [StringLength(50)]
    public string? HdModel { get; set; }

    [Column("Hd_index")]
    [StringLength(50)]
    public string? HdIndex { get; set; }

    [Column("Hd_description")]
    [StringLength(255)]
    public string? HdDescription { get; set; }

    [Column("Hd_price", TypeName = "decimal(10, 2)")]
    public decimal? HdPrice { get; set; }

    [Column("Hd_stock")]
    public int? HdStock { get; set; }

    [Column("Hd_color")]
    public int? HdColor { get; set; }

    [Column("Hd_microphone")]
    public bool? HdMicrophone { get; set; }

    [Column("Hd_noise")]
    public bool? HdNoise { get; set; }

    [Column("Hd_waterproof")]
    public bool? HdWaterproof { get; set; }

    [Column("Hd_wp_standart")]
    public int? HdWpStandart { get; set; }

    [Column("Hd_sensors")]
    public int? HdSensors { get; set; }

    [Column("Hd_specs")]
    public int? HdSpecs { get; set; }

    [Column("Hd_bluetooth")]
    public int? HdBluetooth { get; set; }

    [Column("Hd_acum", TypeName = "decimal(4, 2)")]
    public decimal? HdAcum { get; set; }

    [Column("Hd_acum_box")]
    public int? HdAcumBox { get; set; }

    [Column("Hd_image")]
    [StringLength(255)]
    public string? HdImage { get; set; }

    [ForeignKey("HdBluetooth")]
    [InverseProperty("Headsets")]
    public virtual Bluetooth? HdBluetoothNavigation { get; set; }

    [ForeignKey("HdBrend")]
    [InverseProperty("Headsets")]
    public virtual BrandName? HdBrendNavigation { get; set; }

    [ForeignKey("HdColor")]
    [InverseProperty("Headsets")]
    public virtual Color? HdColorNavigation { get; set; }

    [ForeignKey("HdSensors")]
    [InverseProperty("Headsets")]
    public virtual Sensor? HdSensorsNavigation { get; set; }

    [ForeignKey("HdSpecs")]
    [InverseProperty("Headsets")]
    public virtual Specification? HdSpecsNavigation { get; set; }

    [ForeignKey("HdWpStandart")]
    [InverseProperty("Headsets")]
    public virtual WpStandart? HdWpStandartNavigation { get; set; }

    [ForeignKey("IdHdPoductGroupType")]
    [InverseProperty("Headsets")]
    public virtual Product? IdHdPoductGroupTypeNavigation { get; set; }
}
