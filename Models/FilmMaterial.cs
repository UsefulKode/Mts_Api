using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Film_material")]
public partial class FilmMaterial
{
    [Key]
    [Column("id_film_material")]
    public int IdFilmMaterial { get; set; }

    [Column("Film_material_name")]
    [StringLength(50)]
    public string? FilmMaterialName { get; set; }

    [InverseProperty("FilmMaterialNavigation")]
    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
