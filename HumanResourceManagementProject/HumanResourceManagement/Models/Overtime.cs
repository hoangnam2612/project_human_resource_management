using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Overtime
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Day { get; set; }

    public double? NumberOfHours { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShiftTypeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ShiftType? ShiftType { get; set; }
}
