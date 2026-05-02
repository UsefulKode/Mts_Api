using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Role")]
public partial class Role
{
    [Key]
    [Column("id_role")]
    public int IdRole { get; set; }

    [Column("Role_name")]
    [StringLength(50)]
    public string? RoleName { get; set; }

    [InverseProperty("RoleNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
