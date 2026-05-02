using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Matrix")]
public partial class Matrix
{
    [Key]
    [Column("id_matrix")]
    public int IdMatrix { get; set; }

    [Column("matrix_type")]
    [StringLength(50)]
    public string? MatrixType { get; set; }

    [InverseProperty("LpMatrixNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhMatrixNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlMatrixNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvMatrixNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtMatrixNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
