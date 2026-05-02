using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Adapter")]
public partial class Adapter
{
    [Key]
    [Column("id_adapter")]
    public int IdAdapter { get; set; }

    [Column("id_adapter_poduct_group_type")]
    public int? IdAdapterPoductGroupType { get; set; }

    [Column("adapter_brand")]
    public int? AdapterBrand { get; set; }

    [Column("adapter_model")]
    [StringLength(50)]
    public string? AdapterModel { get; set; }

    [Column("adapter_index")]
    [StringLength(50)]
    public string? AdapterIndex { get; set; }

    [Column("adapter_price", TypeName = "decimal(10, 2)")]
    public decimal? AdapterPrice { get; set; }

    [Column("adapter_stock")]
    public int? AdapterStock { get; set; }

    [Column("adapter_color")]
    public int? AdapterColor { get; set; }

    [Column("adapter_port_1")]
    public int? AdapterPort1 { get; set; }

    [Column("adapter_port_2")]
    public int? AdapterPort2 { get; set; }

    [Column("adapter_image")]
    [StringLength(255)]
    public string? AdapterImage { get; set; }

    [ForeignKey("AdapterBrand")]
    [InverseProperty("Adapters")]
    public virtual BrandName? AdapterBrandNavigation { get; set; }

    [ForeignKey("AdapterColor")]
    [InverseProperty("Adapters")]
    public virtual Color? AdapterColorNavigation { get; set; }

    [ForeignKey("AdapterPort1")]
    [InverseProperty("AdapterAdapterPort1Navigations")]
    public virtual Port? AdapterPort1Navigation { get; set; }

    [ForeignKey("AdapterPort2")]
    [InverseProperty("AdapterAdapterPort2Navigations")]
    public virtual Port? AdapterPort2Navigation { get; set; }

    [ForeignKey("IdAdapterPoductGroupType")]
    [InverseProperty("Adapters")]
    public virtual Product? IdAdapterPoductGroupTypeNavigation { get; set; }
}
