using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Basket")]
public partial class Basket
{
    [Key]
    [Column("id_basket")]
    public int IdBasket { get; set; }

    [Column("Consultant_user")]
    public int? ConsultantUser { get; set; }

    public int? Item { get; set; }

    public int? Count { get; set; }

    [Column("Unic_code")]
    [StringLength(10)]
    public string? UnicCode { get; set; }

    [Column("Pers_data")]
    public int? PersData { get; set; }

    [ForeignKey("ConsultantUser")]
    [InverseProperty("Baskets")]
    public virtual User? ConsultantUserNavigation { get; set; }
}
