using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

[Table("Port")]
public partial class Port
{
    [Key]
    [Column("id_port")]
    public int IdPort { get; set; }

    [Column("Port_type")]
    [StringLength(50)]
    public string? PortType { get; set; }

    [InverseProperty("AdapterPort1Navigation")]
    public virtual ICollection<Adapter> AdapterAdapterPort1Navigations { get; set; } = new List<Adapter>();

    [InverseProperty("AdapterPort2Navigation")]
    public virtual ICollection<Adapter> AdapterAdapterPort2Navigations { get; set; } = new List<Adapter>();

    [InverseProperty("ChPortNavigation")]
    public virtual ICollection<Charger> Chargers { get; set; } = new List<Charger>();

    [InverseProperty("FlPortNavigation")]
    public virtual ICollection<Flash> Flashes { get; set; } = new List<Flash>();

    [InverseProperty("PhPortNavigation")]
    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    [InverseProperty("WtPortNavigation")]
    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
