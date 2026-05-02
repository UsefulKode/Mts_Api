using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Ph_accessories")]
public partial class PhAccessory
{
    [Key]
    [Column("id_ph_accessories")]
    public int IdPhAccessories { get; set; }

    [Column("id_ph_accs_product_group_type")]
    public int? IdPhAccsProductGroupType { get; set; }

    [Column("Ph_accessories_type")]
    [StringLength(50)]
    public string? PhAccessoriesType { get; set; }

    [ForeignKey("IdPhAccsProductGroupType")]
    [InverseProperty("PhAccessories")]
    public virtual Product? IdPhAccsProductGroupTypeNavigation { get; set; }

    [InverseProperty("IdPhCaseAccessoriesTypeNavigation")]
    public virtual ICollection<PhCase> PhCases { get; set; } = new List<PhCase>();

    [InverseProperty("IdPhProtectorAccessoriesTypeNavigation")]
    public virtual ICollection<Protector> Protectors { get; set; } = new List<Protector>();
}
