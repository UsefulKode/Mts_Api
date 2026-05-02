using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

public partial class Film
{
    [Key]
    [Column("id_film")]
    public int IdFilm { get; set; }

    [Column("id_film_protectors")]
    public int? IdFilmProtectors { get; set; }

    [Column("id_film_brend")]
    public int? IdFilmBrend { get; set; }

    [Column("Film_model")]
    [StringLength(50)]
    public string? FilmModel { get; set; }

    [Column("Film_stock")]
    public int? FilmStock { get; set; }

    [Column("Film_type")]
    public int? FilmType { get; set; }

    [Column("Film_antispy")]
    public bool? FilmAntispy { get; set; }

    [Column("Film_camera")]
    public bool? FilmCamera { get; set; }

    [Column("Film_material")]
    public int? FilmMaterial { get; set; }

    [Column("Film_phone")]
    public int? FilmPhone { get; set; }

    [Column("Film_slate")]
    public int? FilmSlate { get; set; }

    [Column("Film_gadget")]
    public int? FilmGadget { get; set; }

    [ForeignKey("FilmGadget")]
    [InverseProperty("Films")]
    public virtual Gadget? FilmGadgetNavigation { get; set; }

    [ForeignKey("FilmMaterial")]
    [InverseProperty("Films")]
    public virtual FilmMaterial? FilmMaterialNavigation { get; set; }

    [ForeignKey("FilmPhone")]
    [InverseProperty("Films")]
    public virtual Phone? FilmPhoneNavigation { get; set; }

    [ForeignKey("FilmType")]
    [InverseProperty("Films")]
    public virtual FilmType? FilmTypeNavigation { get; set; }

    [ForeignKey("IdFilmBrend")]
    [InverseProperty("Films")]
    public virtual BrandName? IdFilmBrendNavigation { get; set; }

    [ForeignKey("IdFilmProtectors")]
    [InverseProperty("Films")]
    public virtual Protector? IdFilmProtectorsNavigation { get; set; }
}
