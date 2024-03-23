using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Skill
{
    public int SkillId { get; set; }

    public string? SkillName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
