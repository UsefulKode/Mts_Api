using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Flash")]
public partial class Flash
{
    [Key]
    [Column("id_flash")]
    public int IdFlash { get; set; }

    [Column("id_fl_poduct_group_type")]
    public int? IdFlPoductGroupType { get; set; }

    [Column("Fl_brand")]
    public int? FlBrand { get; set; }

    [Column("Fl_model")]
    [StringLength(50)]
    public string? FlModel { get; set; }

    [Column("Fl_index")]
    [StringLength(50)]
    public string? FlIndex { get; set; }

    [Column("Fl_description")]
    [StringLength(255)]
    public string? FlDescription { get; set; }

    [Column("Fl_price", TypeName = "decimal(10, 2)")]
    public decimal? FlPrice { get; set; }

    [Column("Fl_stock")]
    public int? FlStock { get; set; }

    [Column("Fl_color")]
    public int? FlColor { get; set; }

    [Column("Fl_storage")]
    public int? FlStorage { get; set; }

    [Column("Fl_port")]
    public int? FlPort { get; set; }

    [Column("Fl_image")]
    [StringLength(255)]
    public string? FlImage { get; set; }

    [ForeignKey("FlBrand")]
    [InverseProperty("Flashes")]
    public virtual BrandName? FlBrandNavigation { get; set; }

    [ForeignKey("FlColor")]
    [InverseProperty("Flashes")]
    public virtual Color? FlColorNavigation { get; set; }

    [ForeignKey("FlPort")]
    [InverseProperty("Flashes")]
    public virtual Port? FlPortNavigation { get; set; }

    [ForeignKey("FlStorage")]
    [InverseProperty("Flashes")]
    public virtual Storage? FlStorageNavigation { get; set; }

    [ForeignKey("IdFlPoductGroupType")]
    [InverseProperty("Flashes")]
    public virtual Product? IdFlPoductGroupTypeNavigation { get; set; }
}
