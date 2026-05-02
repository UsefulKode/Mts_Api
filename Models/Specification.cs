using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

public partial class Specification
{
    [Key]
    [Column("id_specs")]
    public int IdSpecs { get; set; }

    [Column("specifications")]
    [StringLength(50)]
    public string? Specifications { get; set; }

    [InverseProperty("HdSpecsNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();
}
