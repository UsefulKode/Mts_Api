using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Video")]
public partial class Video
{
    [Key]
    [Column("id_video")]
    public int IdVideo { get; set; }

    [Column("Video")]
    [StringLength(50)]
    public string? Video1 { get; set; }

    [InverseProperty("LpVideoNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhVideoNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlVideoNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvVideoNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtVideoNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
