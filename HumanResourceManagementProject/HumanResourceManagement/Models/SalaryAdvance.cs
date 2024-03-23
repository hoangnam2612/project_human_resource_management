using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class SalaryAdvance
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Day { get; set; }

    public double? Amount { get; set; }

    public bool? Status { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }
}
