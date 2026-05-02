using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

public partial class PersonalDatum
{
    [Key]
    [Column("id_personal_data")]
    public int IdPersonalData { get; set; }

    [Column("pd_Telefon")]
    public int? PdTelefon { get; set; }

    [Column("pd_First_name")]
    [StringLength(50)]
    public string? PdFirstName { get; set; }

    [Column("pd_Last_name")]
    [StringLength(50)]
    public string? PdLastName { get; set; }

    [Column("pd_Middle_name")]
    [StringLength(50)]
    public string? PdMiddleName { get; set; }

    [Column("pd_Passport_number")]
    public int? PdPassportNumber { get; set; }

    [Column("pd_Kem_vydan")]
    [StringLength(50)]
    public string? PdKemVydan { get; set; }

    [Column("pd_Kogda_vydan")]
    public DateOnly? PdKogdaVydan { get; set; }

    [Column("pd_Kod_podrazdelenia")]
    [StringLength(50)]
    public string? PdKodPodrazdelenia { get; set; }

    [Column("pd_Propiska_gorod")]
    [StringLength(50)]
    public string? PdPropiskaGorod { get; set; }

    [Column("pd_Propiska_ulica")]
    [StringLength(50)]
    public string? PdPropiskaUlica { get; set; }

    [Column("pd_Propiska_dom")]
    [StringLength(50)]
    public string? PdPropiskaDom { get; set; }

    [Column("pd_Propiska_kvartira")]
    public int? PdPropiskaKvartira { get; set; }

    [Column("pd_Propiska_date")]
    public DateOnly? PdPropiskaDate { get; set; }
}
