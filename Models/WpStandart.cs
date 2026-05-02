using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Wp_standart")]
public partial class WpStandart
{
    [Key]
    [Column("id_wp_standart")]
    public int IdWpStandart { get; set; }

    [Column("wp_standart")]
    [StringLength(10)]
    public string? WpStandart1 { get; set; }

    [InverseProperty("HdWpStandartNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();
}
