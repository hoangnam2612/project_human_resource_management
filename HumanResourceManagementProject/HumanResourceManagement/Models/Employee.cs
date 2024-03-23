using System;
using System.Collections.Generic;

namespace HumanResourceManagement.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? Phone { get; set; }

    public string? Idcart { get; set; }

    public string? Address { get; set; }

    public byte[]? Avatar { get; set; }

    public int? Salary { get; set; }

    public int? DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public int? SkillId { get; set; }

    public int? UserId { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<AwardDiscipline> AwardDisciplines { get; set; } = new List<AwardDiscipline>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<EmployeeAllowance> EmployeeAllowances { get; set; } = new List<EmployeeAllowance>();

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    public virtual ICollection<Overtime> Overtimes { get; set; } = new List<Overtime>();

    public virtual Position? Position { get; set; }

    public virtual ICollection<SalaryAdvance> SalaryAdvances { get; set; } = new List<SalaryAdvance>();

    public virtual Skill? Skill { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
