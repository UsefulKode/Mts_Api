using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Charger_type")]
public partial class ChargerType
{
    [Key]
    [Column("id_charger_type")]
    public int IdChargerType { get; set; }

    [Column("Charger_type")]
    [StringLength(50)]
    public string? ChargerType1 { get; set; }

    [InverseProperty("ChTypeNavigation")]
    public virtual ICollection<Charger> Chargers { get; set; } = new List<Charger>();
}
