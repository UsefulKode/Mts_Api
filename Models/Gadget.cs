using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

public partial class Gadget
{
    [Key]
    [Column("id_gadget")]
    public int IdGadget { get; set; }

    [Column("Gadget_name")]
    [StringLength(50)]
    public string? GadgetName { get; set; }

    [InverseProperty("FilmGadgetNavigation")]
    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
