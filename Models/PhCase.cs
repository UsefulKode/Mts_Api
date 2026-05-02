using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Ph_case")]
public partial class PhCase
{
    [Key]
    [Column("id_ph_case")]
    public int IdPhCase { get; set; }

    [Column("id_ph_case_accessories_type")]
    public int? IdPhCaseAccessoriesType { get; set; }

    [Column("Ph_case_brand")]
    public int? PhCaseBrand { get; set; }

    [Column("Ph_case_model")]
    [StringLength(50)]
    public string? PhCaseModel { get; set; }

    [Column("Ph_case_price")]
    public int? PhCasePrice { get; set; }

    [Column("Ph_case_stock")]
    public bool? PhCaseStock { get; set; }

    [Column("Ph_case_color")]
    public int? PhCaseColor { get; set; }

    [Column("Ph_case_image")]
    [StringLength(50)]
    public string? PhCaseImage { get; set; }

    [Column("Ph_case_type")]
    public int? PhCaseType { get; set; }

    [Column("Ph_case_material")]
    public int? PhCaseMaterial { get; set; }

    [Column("case_slate")]
    public int? CaseSlate { get; set; }

    [Column("Ph_case_phone")]
    public int? PhCasePhone { get; set; }

    [Column("case_gadget")]
    public int? CaseGadget { get; set; }

    [ForeignKey("IdPhCaseAccessoriesType")]
    [InverseProperty("PhCases")]
    public virtual PhAccessory? IdPhCaseAccessoriesTypeNavigation { get; set; }

    [ForeignKey("PhCaseBrand")]
    [InverseProperty("PhCases")]
    public virtual BrandName? PhCaseBrandNavigation { get; set; }

    [ForeignKey("PhCaseColor")]
    [InverseProperty("PhCases")]
    public virtual Color? PhCaseColorNavigation { get; set; }

    [ForeignKey("PhCaseMaterial")]
    [InverseProperty("PhCases")]
    public virtual PhCaseMaterial? PhCaseMaterialNavigation { get; set; }

    [ForeignKey("PhCasePhone")]
    [InverseProperty("PhCases")]
    public virtual Phone? PhCasePhoneNavigation { get; set; }

    [ForeignKey("PhCaseType")]
    [InverseProperty("PhCases")]
    public virtual PhCaseType? PhCaseTypeNavigation { get; set; }
}
