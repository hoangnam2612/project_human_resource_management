using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Allowance
{
    public int AllowanceId { get; set; }

    public string? AllowanceName { get; set; }

    public double? Amount { get; set; }

    public virtual ICollection<EmployeeAllowance> EmployeeAllowances { get; set; } = new List<EmployeeAllowance>();
}
