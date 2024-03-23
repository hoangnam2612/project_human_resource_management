using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Devision
{
    public int DivisionId { get; set; }

    public string? DivisionName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
