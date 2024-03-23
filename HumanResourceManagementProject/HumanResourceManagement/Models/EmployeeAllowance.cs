using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class EmployeeAllowance
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? AllowanceId { get; set; }

    public DateTime? Date { get; set; }

    public string? Content { get; set; }

    public double? Amount { get; set; }

    public virtual Allowance? Allowance { get; set; }

    public virtual Employee? Employee { get; set; }
}
