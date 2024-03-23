using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Insurance
{
    public int InsuranceId { get; set; }

    public string? InsuranceNumber { get; set; }

    public DateTime? CoverageStartDate { get; set; }

    public string? InsuranceProvider { get; set; }

    public string? RegisteredClinic { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }
}
