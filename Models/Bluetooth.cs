using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Bluetooth")]
public partial class Bluetooth
{
    [Key]
    [Column("id_bluetooth")]
    public int IdBluetooth { get; set; }

    [Column("Bluetooth", TypeName = "decimal(2, 1)")]
    public decimal? Bluetooth1 { get; set; }

    [InverseProperty("HdBluetoothNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();

    [InverseProperty("LpBluetoothNavigation")]
    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    [InverseProperty("PhBluetoothNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("SlBluetoothNavigation")]
    public virtual ICollection<Slate> Slates { get; set; } = new List<Slate>();

    [InverseProperty("TvBluetoothNavigation")]
    public virtual ICollection<Tv> Tvs { get; set; } = new List<Tv>();

    [InverseProperty("WtBluetoothNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
