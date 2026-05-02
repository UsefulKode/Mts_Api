using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Service")]
public partial class Service
{
    [Key]
    [Column("id_service")]
    public int IdService { get; set; }

    [Column("id_sv_poduct_group_type")]
    public int? IdSvPoductGroupType { get; set; }

    [Column("Sv_name")]
    [StringLength(50)]
    public string? SvName { get; set; }

    [Column("Sv_description")]
    [StringLength(255)]
    public string? SvDescription { get; set; }

    [Column("Sv_price", TypeName = "decimal(10, 2)")]
    public decimal? SvPrice { get; set; }

    [Column("Sv_image")]
    [StringLength(255)]
    public string? SvImage { get; set; }

    [ForeignKey("IdSvPoductGroupType")]
    [InverseProperty("Services")]
    public virtual Product? IdSvPoductGroupTypeNavigation { get; set; }
}
