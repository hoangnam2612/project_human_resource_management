using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class AwardDiscipline
{
    public int Id { get; set; }

    public int? Adcount { get; set; }

    public string? Content { get; set; }

    public DateTime? Date { get; set; }

    public int? EmployeeId { get; set; }

    public int? Type { get; set; }

    public virtual Employee? Employee { get; set; }
}
