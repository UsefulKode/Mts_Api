using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Camera")]
public partial class Camera
{
    [Key]
    [Column("id_camera")]
    public int IdCamera { get; set; }

    [Column("Camera_res")]
    public int CameraRes { get; set; }

    [InverseProperty("LpCamNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhCamNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlCamNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("WtCamNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
