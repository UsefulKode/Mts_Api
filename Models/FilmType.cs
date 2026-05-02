using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Film_type")]
public partial class FilmType
{
    [Key]
    [Column("id_film_type")]
    public int IdFilmType { get; set; }

    [Column("Film_type_name")]
    [StringLength(50)]
    public string? FilmTypeName { get; set; }

    [InverseProperty("FilmTypeNavigation")]
    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
