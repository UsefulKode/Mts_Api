using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mts_Api.Models;

public partial class Sensor
{
    [Key]
    [Column("id_sensors")]
    public int IdSensors { get; set; }

    [Column("sensor")]
    [StringLength(50)]
    public string? Sensor1 { get; set; }

    [InverseProperty("HdSensorsNavigation")]
    public virtual ICollection<Headset> Headsets { get; set; } = new List<Headset>();
}
