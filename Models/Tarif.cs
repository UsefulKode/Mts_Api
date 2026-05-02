using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Tarif")]
public partial class Tarif
{
    [Key]
    [Column("id_tarif")]
    public int IdTarif { get; set; }

    [Column("id_tarif_poduct_group_type")]
    public int? IdTarifPoductGroupType { get; set; }

    [Column("Tarif_name")]
    [StringLength(50)]
    public string? TarifName { get; set; }

    [Column("Tarif_description")]
    [StringLength(50)]
    public string? TarifDescription { get; set; }

    [Column("Tarif_gb")]
    public int? TarifGb { get; set; }

    [Column("Tarif_min")]
    public int? TarifMin { get; set; }

    [Column("Tarif_sms")]
    public int? TarifSms { get; set; }

    [Column("Tarif_servise_kion")]
    public bool? TarifServiseKion { get; set; }

    [Column("Tarif_servise_vk")]
    public bool? TarifServiseVk { get; set; }

    [Column("Tarif_servise_ok")]
    public bool? TarifServiseOk { get; set; }

    [Column("Tarif_servise_tg")]
    public bool? TarifServiseTg { get; set; }

    [Column("Tarif_price", TypeName = "decimal(5, 0)")]
    public decimal? TarifPrice { get; set; }

    [Column("Tarif_discount")]
    public int? TarifDiscount { get; set; }

    [Column("Tarif_discount_description")]
    [StringLength(50)]
    public string? TarifDiscountDescription { get; set; }

    [ForeignKey("IdTarifPoductGroupType")]
    [InverseProperty("Tarifs")]
    public virtual Product? IdTarifPoductGroupTypeNavigation { get; set; }
}
