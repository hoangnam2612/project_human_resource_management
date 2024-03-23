using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class ShiftType
{
    public int ShiftTypeId { get; set; }

    public string? ShiftTypeName { get; set; }

    public double? Coefficient { get; set; }

    public virtual ICollection<Overtime> Overtimes { get; set; } = new List<Overtime>();
}
