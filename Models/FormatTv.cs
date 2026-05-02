using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Format_tv")]
public partial class FormatTv
{
    [Key]
    [Column("id_format")]
    public int IdFormat { get; set; }

    [StringLength(50)]
    public string? Format { get; set; }

    [InverseProperty("TvFormatNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();
}
