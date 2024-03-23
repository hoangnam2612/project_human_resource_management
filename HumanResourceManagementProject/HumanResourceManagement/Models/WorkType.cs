using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class WorkType
{
    public int WorkTypeId { get; set; }

    public string? WorkTypeName { get; set; }

    public double? Coefficient { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}
