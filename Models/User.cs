using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("id_user")]
    public int IdUser { get; set; }

    [StringLength(50)]
    public string? Fname { get; set; }

    [StringLength(50)]
    public string? Lname { get; set; }

    public int? Role { get; set; }

    [StringLength(50)]
    public string? Login { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [InverseProperty("ConsultantUserNavigation")]
    public virtual ICollection<Basket> Baskets { get; set; } = new List<Basket>();

    [ForeignKey("Role")]
    [InverseProperty("Users")]
    public virtual Role? RoleNavigation { get; set; }
}
