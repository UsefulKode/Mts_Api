using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Sound")]
public partial class Sound
{
    [Key]
    [Column("id_sound")]
    public int IdSound { get; set; }

    [Column("Sound")]
    [StringLength(50)]
    public string? Sound1 { get; set; }

    [InverseProperty("TvSoundNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();
}
