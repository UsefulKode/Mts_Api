using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Protector")]
public partial class Protector
{
    [Key]
    [Column("id_protectors")]
    public int IdProtectors { get; set; }

    [Column("Protector_name")]
    [StringLength(50)]
    public string? ProtectorName { get; set; }

    [Column("id_ph_protector_accessories_type")]
    public int? IdPhProtectorAccessoriesType { get; set; }

    [InverseProperty("IdFilmProtectorsNavigation")]
    public virtual ICollection<Film> Films { get; set; } = new List<Film>();

    [ForeignKey("IdPhProtectorAccessoriesType")]
    [InverseProperty("Protectors")]
    public virtual PhAccessory? IdPhProtectorAccessoriesTypeNavigation { get; set; }
}
