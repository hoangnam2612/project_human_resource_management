using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Contract
{
    public int ContractId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? SigningDate { get; set; }

    public string? Content { get; set; }

    public int? SigningCount { get; set; }

    public string? ContractTerm { get; set; }

    public double? Salary { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
