using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Attendance
{
    public int AttendanceId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Day { get; set; }

    public int? EntryHour { get; set; }

    public int? EntryMinute { get; set; }

    public int? ExitHour { get; set; }

    public int? ExitMinute { get; set; }

    public int? EmployeeId { get; set; }

    public int? WorkTypeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual WorkType? WorkType { get; set; }
}
